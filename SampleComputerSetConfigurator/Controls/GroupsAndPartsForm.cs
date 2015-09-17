using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using SampleComputerSetConfigurator.Database;

namespace SampleComputerSetConfigurator.Controls
{
	public partial class GroupsAndPartsForm : Form
	{
		public GroupsAndPartsForm()
		{
			InitializeComponent();
		}

		private void DiagMsg(string msg)
		{
			toolStripStatusLabelDiagnosticsMessage.Text = msg;
		}

		private void GroupsAndPartsFormLoad(object sender, EventArgs e)
		{
			customTabControl.Visible = false;
			textBoxName.Enabled = false;
			buttonAddNewGroup.Enabled = false;
			buttonAddNewPart.Enabled = false;
			buttonDeleteSelected.Enabled = false;

			InitializeTreeView();
		}

		private void TreeViewGroupsAndPartsAfterSelect(object sender, TreeViewEventArgs e)
		{
			if (e.Action == TreeViewAction.ByMouse || e.Action == TreeViewAction.ByKeyboard)
			{
				textBoxName.Enabled = true;
				customTabControl.Visible = true;

				try
				{
					var g = (ComputerPartGroup) e.Node.Tag;

					SetGroupControls(g);

					DiagMsg(string.Format("wybrano - {0}", g.Name));
					buttonAddNewGroup.Enabled = true;
					buttonAddNewPart.Enabled = false;
				}
				catch(InvalidCastException)
				{
					try
					{
						var p = (ComputerPart) e.Node.Tag;

						customTabControl.Visible = true;
						customTabControl.SelectTab(tabPagePart);

						DiagMsg(string.Format("wybrano - {0}", p.Name));
						buttonAddNewGroup.Enabled = false;
						buttonAddNewPart.Enabled = true;
					}
					catch(InvalidCastException)
					{
						var s = (AdditionalService) e.Node.Tag;

						customTabControl.Visible = true;
						customTabControl.SelectTab(tabPageService);

						DiagMsg(string.Format("wybrano - {0}", s.Name));
						buttonAddNewGroup.Enabled = false;
						buttonAddNewPart.Enabled = false;
					}
				}
			}
		}

		private void ButtonGroupCancelClick(object sender, EventArgs e)
		{
			var g = (ComputerPartGroup) treeViewGroupsAndParts.SelectedNode.Tag;
			SetGroupControls(g);

			DiagMsg(string.Format("przywrócono - {0}", g.Name));
		}

		private void ButtonGroupSaveClick(object sender, EventArgs e)
		{
			var g = (ComputerPartGroup) treeViewGroupsAndParts.SelectedNode.Tag;
			var parentId = (int) comboBoxGroupParents.SelectedValue;

			using (var dbContext = new ComputerSetDatabaseContext())
			{
				dbContext.ComputerPartGroups.Attach(g);

				g.Name = textBoxName.Text;
				g.Parent = parentId == -1 ? null : dbContext.ComputerPartGroups.Single(x => x.Id == parentId);
				g.Show = checkBoxGroupShow.Checked;

				//TODO: g.Sequence

				dbContext.SaveChanges();

				DiagMsg(string.Format("zapisano nowe wartości - {0}", g.Name));
			}
		}

		private void ButtonAddNewGroupClick(object sender, EventArgs e)
		{
			var g = new ComputerPartGroup {Name = "_Nowa grupa", Show = false};
			using (var dbContext = new ComputerSetDatabaseContext())
			{
				var lastSequence = dbContext.ComputerPartGroups.Max(x => x.Sequence);
				g.Sequence = ++lastSequence;

				dbContext.ComputerPartGroups.Add(g);
				dbContext.SaveChanges();
			}

			buttonAddNewGroup.Enabled = false;
			buttonAddNewPart.Enabled = false;
			buttonDeleteSelected.Enabled = false;
			treeViewGroupsAndParts.Nodes.Clear();
			InitializeTreeView();

			DiagMsg(string.Format("utworzono nową grupę."));
		}

		private void ButtonAddNewPartClick(object sender, EventArgs e)
		{
			//NOTE: group;
			//var p = new ComputerPart {Name = "_Nowy produkt",}
		}

		private void ButtonDeleteSelectedClick(object sender, EventArgs e)
		{
			
		}

		private void TreeViewGroupsAndPartsItemDrag(object sender, ItemDragEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				DoDragDrop(e.Item, DragDropEffects.Move);
			}
		}

		private void TreeViewGroupsAndPartsDragDrop(object sender, DragEventArgs e)
		{
			var targetPoint = treeViewGroupsAndParts.PointToClient(new Point(e.X, e.Y));
			var targetNode = treeViewGroupsAndParts.GetNodeAt(targetPoint);
			var draggedNode = (TreeNode) e.Data.GetData(typeof (TreeNode));

			//if (!draggedNode.Equals(targetNode) && !ContainsNode(draggedNode, targetNode))
			//{
			//    // If it is a move operation, remove the node from its current  
			//    // location and add it to the node at the drop location. 
			//    if (e.Effect == DragDropEffects.Move)
			//    {
			//        draggedNode.Remove();
			//        targetNode.Nodes.Add(draggedNode);
			//    }

			//    // If it is a copy operation, clone the dragged node  
			//    // and add it to the node at the drop location. 
			//    else if (e.Effect == DragDropEffects.Copy)
			//    {
			//        targetNode.Nodes.Add((TreeNode)draggedNode.Clone());
			//    }

			//    // Expand the node at the location  
			//    // to show the dropped node.
			//    targetNode.Expand();
			//}
		}

		private void TreeViewGroupsAndPartsDragEnter(object sender, DragEventArgs e)
		{
			e.Effect = e.AllowedEffect;
		}

		//private static bool ContainsNode(TreeNode node1, TreeNode node2)
		//{
		//    if (node2.Parent == null) return false;
		//    if (node2.Parent.Equals(node1)) return true;

		//    // If the parent node is not null or equal to the first node,  
		//    // call the ContainsNode method recursively using the parent of  
		//    // the second node. 
		//    return ContainsNode(node1, node2.Parent);
		//}

		private void SetGroupControls(ComputerPartGroup g)
		{
			customTabControl.SelectTab(tabPageGroup);

			textBoxName.Text = g.Name;
			checkBoxGroupShow.Checked = g.Show;

			using (var dbContext = new ComputerSetDatabaseContext())
			{
				var computerPartGroups = dbContext.ComputerPartGroups.ToList();
				computerPartGroups.Insert(0, new ComputerPartGroup { Id = -1, Name = "..." });

				comboBoxGroupParents.DataSource = computerPartGroups;
				comboBoxGroupParents.DisplayMember = "Name";
				comboBoxGroupParents.ValueMember = "Id";
			}

			comboBoxGroupParents.SelectedValue = g.Parent == null ? -1 : g.Parent.Id;
		}

		private void InitializeTreeView()
		{
			using (var dbContext = new ComputerSetDatabaseContext())
			{
				foreach (var g in dbContext.ComputerPartGroups.OrderBy(x => x.Sequence))
				{
					var nodeGroup = new TreeNode { Tag = g, Text = g.Name };

					foreach (var p in g.ComputerParts.OrderBy(x => x.Name))
					{
						var nodePart = new TreeNode { Tag = p, Text = p.Name };

						nodeGroup.Nodes.Add(nodePart);
					}

					treeViewGroupsAndParts.Nodes.Add(nodeGroup);
				}
			}
		}
	}
}

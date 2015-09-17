namespace SampleComputerSetConfigurator.Controls
{
	partial class GroupsAndPartsForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.treeViewGroupsAndParts = new System.Windows.Forms.TreeView();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabelDiagnostics = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabelDiagnosticsMessage = new System.Windows.Forms.ToolStripStatusLabel();
			this.buttonDeleteSelected = new System.Windows.Forms.Button();
			this.buttonAddNewPart = new System.Windows.Forms.Button();
			this.buttonAddNewGroup = new System.Windows.Forms.Button();
			this.customTabControl = new CustomTabControl();
			this.tabPageGroup = new System.Windows.Forms.TabPage();
			this.label2 = new System.Windows.Forms.Label();
			this.buttonGroupCancel = new System.Windows.Forms.Button();
			this.buttonGroupSave = new System.Windows.Forms.Button();
			this.comboBoxGroupParents = new System.Windows.Forms.ComboBox();
			this.checkBoxGroupShow = new System.Windows.Forms.CheckBox();
			this.tabPagePart = new System.Windows.Forms.TabPage();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.tabPageService = new System.Windows.Forms.TabPage();
			this.button1 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.statusStrip.SuspendLayout();
			this.customTabControl.SuspendLayout();
			this.tabPageGroup.SuspendLayout();
			this.tabPagePart.SuspendLayout();
			this.tabPageService.SuspendLayout();
			this.SuspendLayout();
			// 
			// treeViewGroupsAndParts
			// 
			this.treeViewGroupsAndParts.AllowDrop = true;
			this.treeViewGroupsAndParts.CheckBoxes = true;
			this.treeViewGroupsAndParts.Location = new System.Drawing.Point(12, 12);
			this.treeViewGroupsAndParts.Name = "treeViewGroupsAndParts";
			this.treeViewGroupsAndParts.Size = new System.Drawing.Size(334, 220);
			this.treeViewGroupsAndParts.TabIndex = 1;
			this.treeViewGroupsAndParts.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.TreeViewGroupsAndPartsItemDrag);
			this.treeViewGroupsAndParts.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeViewGroupsAndPartsAfterSelect);
			this.treeViewGroupsAndParts.DragDrop += new System.Windows.Forms.DragEventHandler(this.TreeViewGroupsAndPartsDragDrop);
			this.treeViewGroupsAndParts.DragEnter += new System.Windows.Forms.DragEventHandler(this.TreeViewGroupsAndPartsDragEnter);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(351, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Nazwa";
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(397, 12);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(421, 20);
			this.textBoxName.TabIndex = 0;
			// 
			// statusStrip
			// 
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelDiagnostics,
            this.toolStripStatusLabelDiagnosticsMessage});
			this.statusStrip.Location = new System.Drawing.Point(0, 272);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(826, 22);
			this.statusStrip.TabIndex = 8;
			this.statusStrip.Text = "statusStrip";
			// 
			// toolStripStatusLabelDiagnostics
			// 
			this.toolStripStatusLabelDiagnostics.Name = "toolStripStatusLabelDiagnostics";
			this.toolStripStatusLabelDiagnostics.Size = new System.Drawing.Size(71, 17);
			this.toolStripStatusLabelDiagnostics.Text = "Diagnostics:";
			// 
			// toolStripStatusLabelDiagnosticsMessage
			// 
			this.toolStripStatusLabelDiagnosticsMessage.Name = "toolStripStatusLabelDiagnosticsMessage";
			this.toolStripStatusLabelDiagnosticsMessage.Size = new System.Drawing.Size(16, 17);
			this.toolStripStatusLabelDiagnosticsMessage.Text = "...";
			// 
			// buttonDeleteSelected
			// 
			this.buttonDeleteSelected.Location = new System.Drawing.Point(236, 236);
			this.buttonDeleteSelected.Name = "buttonDeleteSelected";
			this.buttonDeleteSelected.Size = new System.Drawing.Size(110, 23);
			this.buttonDeleteSelected.TabIndex = 10;
			this.buttonDeleteSelected.Text = "Usuń zaznaczone";
			this.buttonDeleteSelected.UseVisualStyleBackColor = true;
			this.buttonDeleteSelected.Click += new System.EventHandler(this.ButtonDeleteSelectedClick);
			// 
			// buttonAddNewPart
			// 
			this.buttonAddNewPart.Location = new System.Drawing.Point(124, 236);
			this.buttonAddNewPart.Name = "buttonAddNewPart";
			this.buttonAddNewPart.Size = new System.Drawing.Size(106, 23);
			this.buttonAddNewPart.TabIndex = 11;
			this.buttonAddNewPart.Text = "Dodaj nową część";
			this.buttonAddNewPart.UseVisualStyleBackColor = true;
			this.buttonAddNewPart.Click += new System.EventHandler(this.ButtonAddNewPartClick);
			// 
			// buttonAddNewGroup
			// 
			this.buttonAddNewGroup.Location = new System.Drawing.Point(12, 236);
			this.buttonAddNewGroup.Name = "buttonAddNewGroup";
			this.buttonAddNewGroup.Size = new System.Drawing.Size(106, 23);
			this.buttonAddNewGroup.TabIndex = 12;
			this.buttonAddNewGroup.Text = "Dodaj nową grupę";
			this.buttonAddNewGroup.UseVisualStyleBackColor = true;
			this.buttonAddNewGroup.Click += new System.EventHandler(this.ButtonAddNewGroupClick);
			// 
			// customTabControl
			// 
			this.customTabControl.Controls.Add(this.tabPageGroup);
			this.customTabControl.Controls.Add(this.tabPagePart);
			this.customTabControl.Controls.Add(this.tabPageService);
			this.customTabControl.Location = new System.Drawing.Point(345, 33);
			this.customTabControl.Name = "customTabControl";
			this.customTabControl.SelectedIndex = 0;
			this.customTabControl.Size = new System.Drawing.Size(478, 256);
			this.customTabControl.TabIndex = 9;
			// 
			// tabPageGroup
			// 
			this.tabPageGroup.BackColor = System.Drawing.SystemColors.Control;
			this.tabPageGroup.Controls.Add(this.label2);
			this.tabPageGroup.Controls.Add(this.buttonGroupCancel);
			this.tabPageGroup.Controls.Add(this.buttonGroupSave);
			this.tabPageGroup.Controls.Add(this.comboBoxGroupParents);
			this.tabPageGroup.Controls.Add(this.checkBoxGroupShow);
			this.tabPageGroup.Location = new System.Drawing.Point(4, 22);
			this.tabPageGroup.Name = "tabPageGroup";
			this.tabPageGroup.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageGroup.Size = new System.Drawing.Size(470, 230);
			this.tabPageGroup.TabIndex = 0;
			this.tabPageGroup.Text = "ComputerPartGroup";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 7);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Zależy od: ";
			// 
			// buttonGroupCancel
			// 
			this.buttonGroupCancel.Location = new System.Drawing.Point(390, 203);
			this.buttonGroupCancel.Name = "buttonGroupCancel";
			this.buttonGroupCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonGroupCancel.TabIndex = 3;
			this.buttonGroupCancel.Text = "Przywróć";
			this.buttonGroupCancel.UseVisualStyleBackColor = true;
			this.buttonGroupCancel.Click += new System.EventHandler(this.ButtonGroupCancelClick);
			// 
			// buttonGroupSave
			// 
			this.buttonGroupSave.Location = new System.Drawing.Point(309, 203);
			this.buttonGroupSave.Name = "buttonGroupSave";
			this.buttonGroupSave.Size = new System.Drawing.Size(75, 23);
			this.buttonGroupSave.TabIndex = 2;
			this.buttonGroupSave.Text = "Zapisz";
			this.buttonGroupSave.UseVisualStyleBackColor = true;
			this.buttonGroupSave.Click += new System.EventHandler(this.ButtonGroupSaveClick);
			// 
			// comboBoxGroupDependsOn
			// 
			this.comboBoxGroupParents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxGroupParents.FormattingEnabled = true;
			this.comboBoxGroupParents.Location = new System.Drawing.Point(71, 4);
			this.comboBoxGroupParents.Name = "comboBoxGroupDependsOn";
			this.comboBoxGroupParents.Size = new System.Drawing.Size(171, 21);
			this.comboBoxGroupParents.TabIndex = 1;
			// 
			// checkBoxGroupShow
			// 
			this.checkBoxGroupShow.AutoSize = true;
			this.checkBoxGroupShow.Location = new System.Drawing.Point(380, 6);
			this.checkBoxGroupShow.Name = "checkBoxGroupShow";
			this.checkBoxGroupShow.Size = new System.Drawing.Size(86, 17);
			this.checkBoxGroupShow.TabIndex = 0;
			this.checkBoxGroupShow.Text = "Pokaż grupę";
			this.checkBoxGroupShow.UseVisualStyleBackColor = true;
			// 
			// tabPagePart
			// 
			this.tabPagePart.BackColor = System.Drawing.SystemColors.Control;
			this.tabPagePart.Controls.Add(this.button2);
			this.tabPagePart.Controls.Add(this.button3);
			this.tabPagePart.Location = new System.Drawing.Point(4, 22);
			this.tabPagePart.Name = "tabPagePart";
			this.tabPagePart.Padding = new System.Windows.Forms.Padding(3);
			this.tabPagePart.Size = new System.Drawing.Size(470, 230);
			this.tabPagePart.TabIndex = 1;
			this.tabPagePart.Text = "ComputerPart";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(390, 203);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 5;
			this.button2.Text = "Przywróć";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(309, 203);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 4;
			this.button3.Text = "Zapisz";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// tabPageService
			// 
			this.tabPageService.BackColor = System.Drawing.SystemColors.Control;
			this.tabPageService.Controls.Add(this.button1);
			this.tabPageService.Controls.Add(this.button4);
			this.tabPageService.Location = new System.Drawing.Point(4, 22);
			this.tabPageService.Name = "tabPageService";
			this.tabPageService.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageService.Size = new System.Drawing.Size(470, 230);
			this.tabPageService.TabIndex = 2;
			this.tabPageService.Text = "AdditionalService";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(390, 203);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 5;
			this.button1.Text = "Przywróć";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(309, 203);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 4;
			this.button4.Text = "Zapisz";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// GroupsAndPartsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(826, 294);
			this.Controls.Add(this.treeViewGroupsAndParts);
			this.Controls.Add(this.buttonAddNewGroup);
			this.Controls.Add(this.buttonAddNewPart);
			this.Controls.Add(this.buttonDeleteSelected);
			this.Controls.Add(this.statusStrip);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.customTabControl);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "GroupsAndPartsForm";
			this.Text = "(Sample) Groups and parts management";
			this.Load += new System.EventHandler(this.GroupsAndPartsFormLoad);
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.customTabControl.ResumeLayout(false);
			this.tabPageGroup.ResumeLayout(false);
			this.tabPageGroup.PerformLayout();
			this.tabPagePart.ResumeLayout(false);
			this.tabPageService.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TreeView treeViewGroupsAndParts;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelDiagnostics;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelDiagnosticsMessage;
		private CustomTabControl customTabControl;
		private System.Windows.Forms.TabPage tabPageGroup;
		private System.Windows.Forms.TabPage tabPagePart;
		private System.Windows.Forms.TabPage tabPageService;
		private System.Windows.Forms.CheckBox checkBoxGroupShow;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button buttonGroupCancel;
		private System.Windows.Forms.Button buttonGroupSave;
		private System.Windows.Forms.ComboBox comboBoxGroupParents;
		private System.Windows.Forms.Button buttonDeleteSelected;
		private System.Windows.Forms.Button buttonAddNewPart;
		private System.Windows.Forms.Button buttonAddNewGroup;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button4;

	}
}
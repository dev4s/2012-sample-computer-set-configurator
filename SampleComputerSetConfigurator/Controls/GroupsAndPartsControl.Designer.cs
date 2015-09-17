namespace SampleComputerSetConfigurator.Controls
{
	partial class GroupsAndPartsControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.labelGroupName = new System.Windows.Forms.Label();
			this.comboBoxParts = new System.Windows.Forms.ComboBox();
			this.labelPrice = new System.Windows.Forms.Label();
			this.tableLayoutPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel
			// 
			this.tableLayoutPanel.ColumnCount = 3;
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56F));
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19F));
			this.tableLayoutPanel.Controls.Add(this.labelGroupName, 0, 0);
			this.tableLayoutPanel.Controls.Add(this.comboBoxParts, 1, 0);
			this.tableLayoutPanel.Controls.Add(this.labelPrice, 2, 0);
			this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel.Name = "tableLayoutPanel";
			this.tableLayoutPanel.RowCount = 1;
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel.Size = new System.Drawing.Size(300, 29);
			this.tableLayoutPanel.TabIndex = 0;
			// 
			// labelGroupName
			// 
			this.labelGroupName.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.labelGroupName.AutoSize = true;
			this.labelGroupName.Location = new System.Drawing.Point(3, 8);
			this.labelGroupName.Name = "labelGroupName";
			this.labelGroupName.Size = new System.Drawing.Size(65, 13);
			this.labelGroupName.TabIndex = 0;
			this.labelGroupName.Text = "Group name";
			// 
			// comboBoxParts
			// 
			this.comboBoxParts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.comboBoxParts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxParts.FormattingEnabled = true;
			this.comboBoxParts.Location = new System.Drawing.Point(78, 4);
			this.comboBoxParts.Name = "comboBoxParts";
			this.comboBoxParts.Size = new System.Drawing.Size(162, 21);
			this.comboBoxParts.TabIndex = 1;
			this.comboBoxParts.SelectedIndexChanged += new System.EventHandler(this.ComboBoxPartsSelectedIndexChanged);
			// 
			// labelPrice
			// 
			this.labelPrice.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.labelPrice.AutoSize = true;
			this.labelPrice.Location = new System.Drawing.Point(266, 8);
			this.labelPrice.Name = "labelPrice";
			this.labelPrice.Size = new System.Drawing.Size(31, 13);
			this.labelPrice.TabIndex = 2;
			this.labelPrice.Text = "Price";
			// 
			// GroupsAndPartsControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel);
			this.Name = "GroupsAndPartsControl";
			this.Size = new System.Drawing.Size(300, 29);
			this.tableLayoutPanel.ResumeLayout(false);
			this.tableLayoutPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
		private System.Windows.Forms.Label labelGroupName;
		private System.Windows.Forms.ComboBox comboBoxParts;
		private System.Windows.Forms.Label labelPrice;

	}
}

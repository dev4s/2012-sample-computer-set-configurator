namespace SampleComputerSetConfigurator.Controls
{
	partial class AdditionalServicesControl
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
			this.labelPrice = new System.Windows.Forms.Label();
			this.checkedListBoxServices = new System.Windows.Forms.CheckedListBox();
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
			this.tableLayoutPanel.Controls.Add(this.labelPrice, 2, 0);
			this.tableLayoutPanel.Controls.Add(this.checkedListBoxServices, 1, 0);
			this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel.Name = "tableLayoutPanel";
			this.tableLayoutPanel.RowCount = 1;
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel.Size = new System.Drawing.Size(300, 112);
			this.tableLayoutPanel.TabIndex = 0;
			// 
			// labelGroupName
			// 
			this.labelGroupName.AutoSize = true;
			this.labelGroupName.Location = new System.Drawing.Point(3, 3);
			this.labelGroupName.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
			this.labelGroupName.Name = "labelGroupName";
			this.labelGroupName.Size = new System.Drawing.Size(65, 13);
			this.labelGroupName.TabIndex = 0;
			this.labelGroupName.Text = "Group name";
			// 
			// labelPrice
			// 
			this.labelPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.labelPrice.AutoSize = true;
			this.labelPrice.Location = new System.Drawing.Point(266, 3);
			this.labelPrice.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
			this.labelPrice.Name = "labelPrice";
			this.labelPrice.Size = new System.Drawing.Size(31, 13);
			this.labelPrice.TabIndex = 2;
			this.labelPrice.Text = "Price";
			// 
			// checkedListBoxServices
			// 
			this.checkedListBoxServices.CheckOnClick = true;
			this.checkedListBoxServices.Dock = System.Windows.Forms.DockStyle.Fill;
			this.checkedListBoxServices.FormattingEnabled = true;
			this.checkedListBoxServices.Location = new System.Drawing.Point(78, 3);
			this.checkedListBoxServices.Name = "checkedListBoxServices";
			this.checkedListBoxServices.ScrollAlwaysVisible = true;
			this.checkedListBoxServices.Size = new System.Drawing.Size(162, 106);
			this.checkedListBoxServices.TabIndex = 3;
			this.checkedListBoxServices.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CheckedListBoxServicesItemCheck);
			// 
			// AdditionalServicesControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel);
			this.Name = "AdditionalServicesControl";
			this.Size = new System.Drawing.Size(300, 112);
			this.Load += new System.EventHandler(this.AdditionalServicesControlLoad);
			this.tableLayoutPanel.ResumeLayout(false);
			this.tableLayoutPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
		private System.Windows.Forms.Label labelGroupName;
		private System.Windows.Forms.Label labelPrice;
		private System.Windows.Forms.CheckedListBox checkedListBoxServices;

	}
}

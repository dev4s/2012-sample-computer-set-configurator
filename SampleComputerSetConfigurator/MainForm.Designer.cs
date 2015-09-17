using SampleComputerSetConfigurator.Controls;

namespace SampleComputerSetConfigurator
{
	partial class MainForm
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
			this.buttonFinishOrder = new System.Windows.Forms.Button();
			this.buttonCleanOrder = new System.Windows.Forms.Button();
			this.label15 = new System.Windows.Forms.Label();
			this.panelGroupsAndParts = new System.Windows.Forms.Panel();
			this.buttonGroupsAndParts = new System.Windows.Forms.Button();
			this.labelPriceControl = new LabelPriceControl();
			this.SuspendLayout();
			// 
			// buttonFinishOrder
			// 
			this.buttonFinishOrder.Location = new System.Drawing.Point(380, 400);
			this.buttonFinishOrder.Name = "buttonFinishOrder";
			this.buttonFinishOrder.Size = new System.Drawing.Size(130, 23);
			this.buttonFinishOrder.TabIndex = 1;
			this.buttonFinishOrder.Text = "Złóż zamówienie";
			this.buttonFinishOrder.UseVisualStyleBackColor = true;
			this.buttonFinishOrder.Click += new System.EventHandler(this.ButtonFinishOrderClick);
			// 
			// buttonCleanOrder
			// 
			this.buttonCleanOrder.Location = new System.Drawing.Point(516, 400);
			this.buttonCleanOrder.Name = "buttonCleanOrder";
			this.buttonCleanOrder.Size = new System.Drawing.Size(130, 23);
			this.buttonCleanOrder.TabIndex = 2;
			this.buttonCleanOrder.Text = "Wyczyść zamówienie";
			this.buttonCleanOrder.UseVisualStyleBackColor = true;
			this.buttonCleanOrder.Click += new System.EventHandler(this.ButtonCleanOrderClick);
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label15.Location = new System.Drawing.Point(480, 378);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(46, 13);
			this.label15.TabIndex = 4;
			this.label15.Text = "SUMA:";
			// 
			// panelGroupsAndParts
			// 
			this.panelGroupsAndParts.AutoScroll = true;
			this.panelGroupsAndParts.Location = new System.Drawing.Point(12, 12);
			this.panelGroupsAndParts.Name = "panelGroupsAndParts";
			this.panelGroupsAndParts.Size = new System.Drawing.Size(634, 360);
			this.panelGroupsAndParts.TabIndex = 7;
			// 
			// buttonGroupsAndParts
			// 
			this.buttonGroupsAndParts.Location = new System.Drawing.Point(12, 400);
			this.buttonGroupsAndParts.Name = "buttonGroupsAndParts";
			this.buttonGroupsAndParts.Size = new System.Drawing.Size(125, 23);
			this.buttonGroupsAndParts.TabIndex = 8;
			this.buttonGroupsAndParts.Text = "Grupy i części";
			this.buttonGroupsAndParts.UseVisualStyleBackColor = true;
			this.buttonGroupsAndParts.Click += new System.EventHandler(this.ButtonGroupsAndPartsClick);
			// 
			// labelPriceControl
			// 
			this.labelPriceControl.Location = new System.Drawing.Point(532, 378);
			this.labelPriceControl.Name = "labelPriceControl";
			this.labelPriceControl.Size = new System.Drawing.Size(114, 13);
			this.labelPriceControl.TabIndex = 9;
			this.labelPriceControl.Text = "0 zł";
			this.labelPriceControl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(658, 435);
			this.Controls.Add(this.buttonGroupsAndParts);
			this.Controls.Add(this.labelPriceControl);
			this.Controls.Add(this.panelGroupsAndParts);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.buttonCleanOrder);
			this.Controls.Add(this.buttonFinishOrder);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "(Sample) Computer set configurator";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonFinishOrder;
		private System.Windows.Forms.Button buttonCleanOrder;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Panel panelGroupsAndParts;
		private System.Windows.Forms.Button buttonGroupsAndParts;
		private LabelPriceControl labelPriceControl;
	}
}


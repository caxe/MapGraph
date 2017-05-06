namespace MapGraph
{
	partial class NewNode
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
			this.OkButton = new System.Windows.Forms.Button();
			this.CancelButton = new System.Windows.Forms.Button();
			this.NameLabel = new System.Windows.Forms.Label();
			this.XCoordLabel = new System.Windows.Forms.Label();
			this.YCoordLabel = new System.Windows.Forms.Label();
			this.NameTextBox = new System.Windows.Forms.TextBox();
			this.XCoordTextBox = new System.Windows.Forms.TextBox();
			this.YCoordTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// OkButton
			// 
			this.OkButton.Location = new System.Drawing.Point(64, 234);
			this.OkButton.Name = "OkButton";
			this.OkButton.Size = new System.Drawing.Size(75, 23);
			this.OkButton.TabIndex = 0;
			this.OkButton.Text = "OK";
			this.OkButton.UseVisualStyleBackColor = true;
			this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
			// 
			// CancelButton
			// 
			this.CancelButton.Location = new System.Drawing.Point(145, 234);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new System.Drawing.Size(75, 23);
			this.CancelButton.TabIndex = 1;
			this.CancelButton.Text = "Cancel";
			this.CancelButton.UseVisualStyleBackColor = true;
			this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// NameLabel
			// 
			this.NameLabel.AutoSize = true;
			this.NameLabel.Location = new System.Drawing.Point(104, 9);
			this.NameLabel.Name = "NameLabel";
			this.NameLabel.Size = new System.Drawing.Size(35, 13);
			this.NameLabel.TabIndex = 2;
			this.NameLabel.Text = "Name";
			// 
			// XCoordLabel
			// 
			this.XCoordLabel.AutoSize = true;
			this.XCoordLabel.Location = new System.Drawing.Point(95, 32);
			this.XCoordLabel.Name = "XCoordLabel";
			this.XCoordLabel.Size = new System.Drawing.Size(44, 13);
			this.XCoordLabel.TabIndex = 3;
			this.XCoordLabel.Text = "X coord";
			// 
			// YCoordLabel
			// 
			this.YCoordLabel.AutoSize = true;
			this.YCoordLabel.Location = new System.Drawing.Point(95, 58);
			this.YCoordLabel.Name = "YCoordLabel";
			this.YCoordLabel.Size = new System.Drawing.Size(44, 13);
			this.YCoordLabel.TabIndex = 4;
			this.YCoordLabel.Text = "Y coord";
			// 
			// NameTextBox
			// 
			this.NameTextBox.Location = new System.Drawing.Point(145, 6);
			this.NameTextBox.Name = "NameTextBox";
			this.NameTextBox.Size = new System.Drawing.Size(100, 20);
			this.NameTextBox.TabIndex = 5;
			// 
			// XCoordTextBox
			// 
			this.XCoordTextBox.Location = new System.Drawing.Point(145, 32);
			this.XCoordTextBox.Name = "XCoordTextBox";
			this.XCoordTextBox.Size = new System.Drawing.Size(100, 20);
			this.XCoordTextBox.TabIndex = 6;
			// 
			// YCoordTextBox
			// 
			this.YCoordTextBox.Location = new System.Drawing.Point(145, 58);
			this.YCoordTextBox.Name = "YCoordTextBox";
			this.YCoordTextBox.Size = new System.Drawing.Size(100, 20);
			this.YCoordTextBox.TabIndex = 7;
			// 
			// NewNode
			// 
			this.AcceptButton = this.OkButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.AutoSize = true;
			this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
			this.CancelButton = this.CancelButton;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.YCoordTextBox);
			this.Controls.Add(this.XCoordTextBox);
			this.Controls.Add(this.NameTextBox);
			this.Controls.Add(this.YCoordLabel);
			this.Controls.Add(this.XCoordLabel);
			this.Controls.Add(this.NameLabel);
			this.Controls.Add(this.CancelButton);
			this.Controls.Add(this.OkButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "NewNode";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "New Node";
			this.TopMost = true;
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button OkButton;
		private System.Windows.Forms.Button CancelButton;
		private System.Windows.Forms.Label NameLabel;
		private System.Windows.Forms.Label XCoordLabel;
		private System.Windows.Forms.Label YCoordLabel;
		private System.Windows.Forms.TextBox NameTextBox;
		private System.Windows.Forms.TextBox XCoordTextBox;
		private System.Windows.Forms.TextBox YCoordTextBox;
	}
}
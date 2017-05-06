namespace MapGraph
{
	partial class MapGraph
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapGraph));
			this.MenuMain = new System.Windows.Forms.MenuStrip();
			this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.NewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.OpenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SaveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ExitSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.ToolMain = new System.Windows.Forms.ToolStrip();
			this.NewNode = new System.Windows.Forms.ToolStripButton();
			this.MenuMain.SuspendLayout();
			this.ToolMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// MenuMain
			// 
			this.MenuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem});
			this.MenuMain.Location = new System.Drawing.Point(0, 0);
			this.MenuMain.Name = "MenuMain";
			this.MenuMain.Size = new System.Drawing.Size(712, 24);
			this.MenuMain.TabIndex = 1;
			this.MenuMain.Text = "MenuMain";
			// 
			// FileMenuItem
			// 
			this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewMenuItem,
            this.OpenMenuItem,
            this.SaveMenuItem,
            this.ExitSeparator,
            this.ExitToolStripMenuItem});
			this.FileMenuItem.Name = "FileMenuItem";
			this.FileMenuItem.Size = new System.Drawing.Size(37, 20);
			this.FileMenuItem.Text = "File";
			// 
			// ExitToolStripMenuItem
			// 
			this.ExitToolStripMenuItem.Image = global::MapGraph.Properties.Resources.Exit;
			this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
			this.ExitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
			this.ExitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.ExitToolStripMenuItem.Text = "Exit";
			this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
			// 
			// NewMenuItem
			// 
			this.NewMenuItem.Name = "NewMenuItem";
			this.NewMenuItem.Size = new System.Drawing.Size(152, 22);
			this.NewMenuItem.Text = "New";
			this.NewMenuItem.Click += new System.EventHandler(this.NewMenuItem_Click);
			// 
			// OpenMenuItem
			// 
			this.OpenMenuItem.Name = "OpenMenuItem";
			this.OpenMenuItem.Size = new System.Drawing.Size(152, 22);
			this.OpenMenuItem.Text = "Open";
			// 
			// SaveMenuItem
			// 
			this.SaveMenuItem.Name = "SaveMenuItem";
			this.SaveMenuItem.Size = new System.Drawing.Size(152, 22);
			this.SaveMenuItem.Text = "Save";
			// 
			// ExitSeparator
			// 
			this.ExitSeparator.Name = "ExitSeparator";
			this.ExitSeparator.Size = new System.Drawing.Size(149, 6);
			// 
			// ToolMain
			// 
			this.ToolMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewNode});
			this.ToolMain.Location = new System.Drawing.Point(0, 24);
			this.ToolMain.Name = "ToolMain";
			this.ToolMain.Size = new System.Drawing.Size(712, 25);
			this.ToolMain.TabIndex = 2;
			this.ToolMain.Text = "ToolMain";
			// 
			// NewNode
			// 
			this.NewNode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.NewNode.Image = ((System.Drawing.Image)(resources.GetObject("NewNode.Image")));
			this.NewNode.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.NewNode.Name = "NewNode";
			this.NewNode.Size = new System.Drawing.Size(23, 22);
			this.NewNode.Text = "NewNode";
			this.NewNode.Click += new System.EventHandler(this.NewNode_Click);
			// 
			// MapGraph
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(712, 486);
			this.Controls.Add(this.ToolMain);
			this.Controls.Add(this.MenuMain);
			this.MainMenuStrip = this.MenuMain;
			this.Name = "MapGraph";
			this.Text = "Map Graph";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.MapGraph_Load);
			this.MenuMain.ResumeLayout(false);
			this.MenuMain.PerformLayout();
			this.ToolMain.ResumeLayout(false);
			this.ToolMain.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip MenuMain;
		private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem NewMenuItem;
		private System.Windows.Forms.ToolStripMenuItem OpenMenuItem;
		private System.Windows.Forms.ToolStripMenuItem SaveMenuItem;
		private System.Windows.Forms.ToolStripSeparator ExitSeparator;
		private System.Windows.Forms.ToolStrip ToolMain;
		private System.Windows.Forms.ToolStripButton NewNode;
	}
}


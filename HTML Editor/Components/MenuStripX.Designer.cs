
namespace HTML_Editor.Components
{
    partial class MenuStripX
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.newMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.undoMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.redoMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cutMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.copyMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.Tools = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.Help = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.Edit,
            this.Tools,
            this.Help});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip.Size = new System.Drawing.Size(667, 45);
            this.menuStrip.TabIndex = 0;
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMenuStrip,
            this.openMenuStrip,
            this.toolStripSeparator1,
            this.saveMenuStrip,
            this.saveAsMenuStrip,
            this.toolStripSeparator3,
            this.exitMenuStrip});
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(80, 41);
            this.File.Text = "File";
            // 
            // newMenuStrip
            // 
            this.newMenuStrip.Name = "newMenuStrip";
            this.newMenuStrip.Size = new System.Drawing.Size(313, 48);
            this.newMenuStrip.Text = "New";
            // 
            // openMenuStrip
            // 
            this.openMenuStrip.Name = "openMenuStrip";
            this.openMenuStrip.Size = new System.Drawing.Size(313, 48);
            this.openMenuStrip.Text = "Open";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(310, 6);
            // 
            // saveMenuStrip
            // 
            this.saveMenuStrip.Name = "saveMenuStrip";
            this.saveMenuStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveMenuStrip.Size = new System.Drawing.Size(313, 48);
            this.saveMenuStrip.Text = "Save";
            // 
            // saveAsMenuStrip
            // 
            this.saveAsMenuStrip.Name = "saveAsMenuStrip";
            this.saveAsMenuStrip.Size = new System.Drawing.Size(313, 48);
            this.saveAsMenuStrip.Text = "Save As";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(310, 6);
            // 
            // exitMenuStrip
            // 
            this.exitMenuStrip.Name = "exitMenuStrip";
            this.exitMenuStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitMenuStrip.Size = new System.Drawing.Size(313, 48);
            this.exitMenuStrip.Text = "Exit";
            // 
            // Edit
            // 
            this.Edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoMenuStrip,
            this.redoMenuStrip,
            this.toolStripSeparator2,
            this.cutMenuStrip,
            this.copyMenuStrip,
            this.pasteMenuStrip});
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(85, 41);
            this.Edit.Text = "Edit";
            // 
            // undoMenuStrip
            // 
            this.undoMenuStrip.Name = "undoMenuStrip";
            this.undoMenuStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoMenuStrip.Size = new System.Drawing.Size(325, 48);
            this.undoMenuStrip.Text = "Undo";
            // 
            // redoMenuStrip
            // 
            this.redoMenuStrip.Name = "redoMenuStrip";
            this.redoMenuStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoMenuStrip.Size = new System.Drawing.Size(325, 48);
            this.redoMenuStrip.Text = "Redo";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(322, 6);
            // 
            // cutMenuStrip
            // 
            this.cutMenuStrip.Name = "cutMenuStrip";
            this.cutMenuStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutMenuStrip.Size = new System.Drawing.Size(325, 48);
            this.cutMenuStrip.Text = "Cut";
            // 
            // copyMenuStrip
            // 
            this.copyMenuStrip.Name = "copyMenuStrip";
            this.copyMenuStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyMenuStrip.Size = new System.Drawing.Size(325, 48);
            this.copyMenuStrip.Text = "Copy";
            // 
            // pasteMenuStrip
            // 
            this.pasteMenuStrip.Name = "pasteMenuStrip";
            this.pasteMenuStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteMenuStrip.Size = new System.Drawing.Size(325, 48);
            this.pasteMenuStrip.Text = "Paste";
            // 
            // Tools
            // 
            this.Tools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsMenuStrip});
            this.Tools.Name = "Tools";
            this.Tools.Size = new System.Drawing.Size(100, 41);
            this.Tools.Text = "Tools";
            // 
            // optionsMenuStrip
            // 
            this.optionsMenuStrip.Name = "optionsMenuStrip";
            this.optionsMenuStrip.Size = new System.Drawing.Size(261, 48);
            this.optionsMenuStrip.Text = "Options";
            // 
            // Help
            // 
            this.Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMenuStrip});
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(95, 41);
            this.Help.Text = "Help";
            // 
            // aboutMenuStrip
            // 
            this.aboutMenuStrip.Name = "aboutMenuStrip";
            this.aboutMenuStrip.Size = new System.Drawing.Size(240, 48);
            this.aboutMenuStrip.Text = "About";
            // 
            // MenuStripX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuStrip);
            this.Name = "MenuStripX";
            this.Size = new System.Drawing.Size(667, 45);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripMenuItem newMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem openMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem saveMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem saveAsMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem exitMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem Edit;
        private System.Windows.Forms.ToolStripMenuItem undoMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem redoMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem cutMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem copyMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem pasteMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem Tools;
        private System.Windows.Forms.ToolStripMenuItem optionsMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem Help;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

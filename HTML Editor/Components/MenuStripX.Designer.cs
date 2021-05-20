using System.IO;
using System.Windows.Forms;

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
            this.newMenuStrip.Click += new System.EventHandler(this.newMenuStrip_Click);
            // 
            // openMenuStrip
            // 
            this.openMenuStrip.Name = "openMenuStrip";
            this.openMenuStrip.Size = new System.Drawing.Size(313, 48);
            this.openMenuStrip.Text = "Open";
            this.openMenuStrip.Click += new System.EventHandler(this.openMenuStrip_Click);
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
            this.saveMenuStrip.Enabled = false;
            this.saveMenuStrip.Click += new System.EventHandler(this.saveMenuStrip_Click);
            // 
            // saveAsMenuStrip
            // 
            this.saveAsMenuStrip.Name = "saveAsMenuStrip";
            this.saveAsMenuStrip.Size = new System.Drawing.Size(313, 48);
            this.saveAsMenuStrip.Text = "Save As";
            this.saveAsMenuStrip.Click += new System.EventHandler(this.saveAsMenuStrip_Click);
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
            this.exitMenuStrip.Click += new System.EventHandler(this.exitMenuStrip_Click);
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
            this.undoMenuStrip.Click += new System.EventHandler(this.undoMenuStrip_Click);
            // 
            // redoMenuStrip
            // 
            this.redoMenuStrip.Name = "redoMenuStrip";
            this.redoMenuStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoMenuStrip.Size = new System.Drawing.Size(325, 48);
            this.redoMenuStrip.Text = "Redo";
            this.redoMenuStrip.Click += new System.EventHandler(this.redoMenuStrip_Click);
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
            this.cutMenuStrip.Click += new System.EventHandler(this.cutMenuStrip_Click);
            // 
            // copyMenuStrip
            // 
            this.copyMenuStrip.Name = "copyMenuStrip";
            this.copyMenuStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyMenuStrip.Size = new System.Drawing.Size(325, 48);
            this.copyMenuStrip.Text = "Copy";
            this.copyMenuStrip.Click += new System.EventHandler(this.copyMenuStrip_Click);
            // 
            // pasteMenuStrip
            // 
            this.pasteMenuStrip.Name = "pasteMenuStrip";
            this.pasteMenuStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteMenuStrip.Size = new System.Drawing.Size(325, 48);
            this.pasteMenuStrip.Text = "Paste";
            this.pasteMenuStrip.Click += new System.EventHandler(this.pasteMenuStrip_Click);
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
            this.optionsMenuStrip.Click += new System.EventHandler(this.optionsMenuStrip_Click);
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
            this.aboutMenuStrip.Click += new System.EventHandler(this.aboutMenuStrip_Click);
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

        #region Component Methods

        private void newMenuStrip_Click(object sender, System.EventArgs e)
        {
            new Form1().Show();
        }
        private void openMenuStrip_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.DefaultExt = "*.html";
            file.Filter = "HTML Files|*.html|Text Files|*.txt|All files|*.*";
            if (file.ShowDialog() == System.Windows.Forms.DialogResult.OK && file.FileName.Length > 0)
            {
                HTMLEdt.richTextBoxX.Text = System.IO.File.ReadAllText(file.FileName).ToString();
                HTMLEdt.richTextBoxX.SelectionStart = HTMLEdt.richTextBoxX.Text.Length;

                this.saveMenuStrip.Enabled = false;
                HTMLEdt.toolStripX.saveToolStripButton.Enabled = false;

                HTMLEdt.isSavedBefore = true;
                HTMLEdt.path = file.FileName;
            }
        }
        private void saveMenuStrip_Click(object sender, System.EventArgs e)
        {
            DialogResult result = DialogResult.Cancel;

            SaveFileDialog file = new SaveFileDialog();
            file.DefaultExt = "*.html";
            file.Filter = "HTML Files|*.html|Text Files|*.txt";

            if (!HTMLEdt.isSavedBefore)
            {
                result = file.ShowDialog();
                if (result == System.Windows.Forms.DialogResult.OK && file.FileName.Length > 0)
                {
                    HTMLEdt.isSavedBefore = true;
                    HTMLEdt.path = file.FileName;
                }
            }

            if (result == System.Windows.Forms.DialogResult.OK && HTMLEdt.path.Length > 0)
            {
                System.IO.File.WriteAllText(HTMLEdt.path, HTMLEdt.richTextBoxX.Text.ToString());
                HTMLEdt.isSaved = true;

                this.saveMenuStrip.Enabled = false;
                HTMLEdt.toolStripX.saveToolStripButton.Enabled = false;
            }
            else if (HTMLEdt.path.Length > 0)
            {
                System.IO.File.WriteAllText(HTMLEdt.path, HTMLEdt.richTextBoxX.Text.ToString());
                HTMLEdt.isSaved = true;

                this.saveMenuStrip.Enabled = false;
                HTMLEdt.toolStripX.saveToolStripButton.Enabled = false;
            }
        }
        private void saveAsMenuStrip_Click(object sender, System.EventArgs e)
        {
            SaveFileDialog file = new SaveFileDialog();
            file.DefaultExt = "*.html";
            file.Filter = "HTML Files|*.html|Text Files|*.txt";


            if (file.ShowDialog() == System.Windows.Forms.DialogResult.OK && file.FileName.Length > 0)
            {
                System.IO.File.WriteAllText(file.FileName, HTMLEdt.richTextBoxX.Text.ToString());
                HTMLEdt.path = file.FileName;
                HTMLEdt.isSaved = true;
            }
        }
        private void exitMenuStrip_Click(object sender, System.EventArgs e)
        {
            HTMLEdt.Close();
        }
        private void undoMenuStrip_Click(object sender, System.EventArgs e)
        {
            HTMLEdt.richTextBoxX.Undo();
        }
        private void redoMenuStrip_Click(object sender, System.EventArgs e)
        {
            HTMLEdt.richTextBoxX.Redo();
        }
        private void cutMenuStrip_Click(object sender, System.EventArgs e)
        {
            HTMLEdt.richTextBoxX.Cut();
        }
        private void copyMenuStrip_Click(object sender, System.EventArgs e)
        {
            HTMLEdt.richTextBoxX.Copy();
        }
        private void pasteMenuStrip_Click(object sender, System.EventArgs e)
        {
            HTMLEdt.richTextBoxX.Paste();
        }
        private void optionsMenuStrip_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Daha sonra eklenecek..");
        }
        private void aboutMenuStrip_Click(object sender, System.EventArgs e)
        {

        }
        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripMenuItem newMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem openMenuStrip;
        public System.Windows.Forms.ToolStripMenuItem saveMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem saveAsMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem exitMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem Edit;
        public System.Windows.Forms.ToolStripMenuItem undoMenuStrip;
        public System.Windows.Forms.ToolStripMenuItem redoMenuStrip;
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

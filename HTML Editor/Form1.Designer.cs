
namespace HTML_Editor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            HTML_Editor.Components.KeywordTable keywordTable1 = new HTML_Editor.Components.KeywordTable();
            this.menuStripX = new HTML_Editor.Components.MenuStripX();
            this.toolStripX = new HTML_Editor.Components.ToolStripX();
            this.richTextBoxX = new HTML_Editor.Components.RichTextBoxX(this.components);
            this.SuspendLayout();
            // 
            // menuStripX
            // 
            this.menuStripX.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuStripX.Location = new System.Drawing.Point(0, 0);
            this.menuStripX.Name = "menuStripX";
            this.menuStripX.Size = new System.Drawing.Size(1522, 45);
            this.menuStripX.TabIndex = 1;
            this.menuStripX.TabStop = false;
            // 
            // toolStripX
            // 
            this.toolStripX.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolStripX.Location = new System.Drawing.Point(0, 45);
            this.toolStripX.Name = "toolStripX";
            this.toolStripX.Size = new System.Drawing.Size(1522, 46);
            this.toolStripX.TabIndex = 2;
            this.toolStripX.TabStop = false;
            // 
            // richTextBoxX
            // 
            this.richTextBoxX.DetectUrls = false;
            this.richTextBoxX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxX.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            keywordTable1.Color = new string[0];
            keywordTable1.Keyword = new string[0];
            keywordTable1.Pattern = new string[0];
            this.richTextBoxX.KeywordTable = keywordTable1;
            this.richTextBoxX.Location = new System.Drawing.Point(0, 91);
            this.richTextBoxX.Name = "richTextBoxX";
            this.richTextBoxX.Size = new System.Drawing.Size(1522, 797);
            this.richTextBoxX.TabIndex = 0;
            this.richTextBoxX.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1522, 888);
            this.Controls.Add(this.richTextBoxX);
            this.Controls.Add(this.toolStripX);
            this.Controls.Add(this.menuStripX);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Components.MenuStripX menuStripX;
        private Components.ToolStripX toolStripX;
        private Components.RichTextBoxX richTextBoxX;
    }
}


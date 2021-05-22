
using System.IO;
using System.Windows.Forms;

namespace HTML_Editor.Components
{
    partial class ToolStripX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolStripX));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveAsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.undoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.redoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.saveAsToolStripButton,
            this.toolStripSeparator,
            this.undoToolStripButton,
            this.redoToolStripButton,
            this.toolStripSeparator2,
            this.cutToolStripButton,
            this.copyToolStripButton,
            this.pasteToolStripButton,
            this.toolStripSeparator1,
            this.helpToolStripButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(732, 46);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(52, 40);
            this.newToolStripButton.Text = "&New";
            this.newToolStripButton.Click += new System.EventHandler(this.newToolStripButton_Click);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(52, 40);
            this.openToolStripButton.Text = "&Open";
            this.openToolStripButton.Click += new System.EventHandler(this.openToolStripButton_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Enabled = false;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(52, 40);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // saveAsToolStripButton
            // 
            this.saveAsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveAsToolStripButton.Image = global::HTML_Editor.Properties.Resources.saveAs;
            this.saveAsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveAsToolStripButton.Name = "saveAsToolStripButton";
            this.saveAsToolStripButton.Size = new System.Drawing.Size(52, 40);
            this.saveAsToolStripButton.Text = "Save As";
            this.saveAsToolStripButton.Click += new System.EventHandler(this.saveAsToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 46);
            // 
            // undoToolStripButton
            // 
            this.undoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.undoToolStripButton.Image = global::HTML_Editor.Properties.Resources.undo1;
            this.undoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.undoToolStripButton.Name = "undoToolStripButton";
            this.undoToolStripButton.Size = new System.Drawing.Size(52, 40);
            this.undoToolStripButton.Text = "Undo";
            this.undoToolStripButton.Click += new System.EventHandler(this.undoToolStripButton_Click);
            // 
            // redoToolStripButton
            // 
            this.redoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.redoToolStripButton.Image = global::HTML_Editor.Properties.Resources.redo1;
            this.redoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.redoToolStripButton.Name = "redoToolStripButton";
            this.redoToolStripButton.Size = new System.Drawing.Size(52, 40);
            this.redoToolStripButton.Text = "Redo";
            this.redoToolStripButton.Click += new System.EventHandler(this.redoToolStripButton_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 46);
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(52, 40);
            this.cutToolStripButton.Text = "C&ut";
            this.cutToolStripButton.Click += new System.EventHandler(this.cutToolStripButton_Click);
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(52, 40);
            this.copyToolStripButton.Text = "&Copy";
            this.copyToolStripButton.Click += new System.EventHandler(this.copyToolStripButton_Click);
            // 
            // pasteToolStripButton
            // 
            this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripButton.Image")));
            this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripButton.Name = "pasteToolStripButton";
            this.pasteToolStripButton.Size = new System.Drawing.Size(52, 40);
            this.pasteToolStripButton.Text = "&Paste";
            this.pasteToolStripButton.Click += new System.EventHandler(this.pasteToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 46);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(52, 40);
            this.helpToolStripButton.Text = "He&lp";
            this.helpToolStripButton.Click += new System.EventHandler(this.helpToolStripButton_Click);
            // 
            // ToolStripX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStrip);
            this.Name = "ToolStripX";
            this.Size = new System.Drawing.Size(732, 46);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        #region Component Methods

        /// <summary>
        /// * * * * * * * * * *
        /// newToolStripButton un Click eventine eklenen metotu. Yeni bir HTMLEditor formu olusturur.
        /// * * * * * * * * * *
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newToolStripButton_Click(object sender, System.EventArgs e)
        {
            new HTMLEditor().Show();
        }

        /// <summary>
        /// * * * * * * * * * *
        /// openToolStripButton un Click eventine eklenen metotu. File Open islemi yapar.
        /// * * * * * * * * * *
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void openToolStripButton_Click(object sender, System.EventArgs e)
        {
            /// * * * * * * * * * *
            /// OpenFileDialog tipinde bir file nesnesi olusturuluyor ve default dosya tipi ile diger dosya tipleri belirleniyor.
            /// * * * * * * * * * *
            OpenFileDialog file = new OpenFileDialog();
            file.DefaultExt = "*.html";
            file.Filter = "HTML Files|*.html|Text Files|*.txt|All files|*.*";

            /// * * * * * * * * * *
            /// result OK ise ve gecerli bir fileName varsa,
            /// Dialogtan alinan path teki dosya okunur ve richTextBox a yazilir.
            /// Imleci sona getirmek icin SelectionStart Text in length ine esitlenir.
            /// * * * * * * * * * *
            if (file.ShowDialog() == System.Windows.Forms.DialogResult.OK && file.FileName.Length > 0)
            {
                HTMLEdt.richTextBoxX.Text = File.ReadAllText(file.FileName).ToString();
                HTMLEdt.richTextBoxX.SelectionStart = HTMLEdt.richTextBoxX.Text.Length;

                // Kaydetmeyi saglayan menuStrip ve toolStrip false yapilir.
                this.saveToolStripButton.Enabled = false;
                HTMLEdt.menuStripX.saveMenuStrip.Enabled = false;

                // isSavedBefore true yapilir ve fileName path degiskenine aktarilir.
                HTMLEdt.isSavedBefore = true;
                HTMLEdt.path = file.FileName;
            }
        }

        /// <summary>
        /// * * * * * * * * * *
        /// saveToolStripButton un Click eventine eklenen metotu. File save islemi yapar.
        /// * * * * * * * * * *
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripButton_Click(object sender, System.EventArgs e)
        {
            /// * * * * * * * * * *
            /// DialogResult tipinde bir result olusturuluyor. Degeri false durumu ifade eden Cancel a esitleniyor.
            /// SaveFileDialog tipinde bir file nesnesi olusturuluyor ve default dosya tipi ile diger dosya tipleri belirleniyor.
            /// * * * * * * * * * *
            DialogResult result = DialogResult.Cancel;

            SaveFileDialog file = new SaveFileDialog();
            file.DefaultExt = "*.html";
            file.Filter = "HTML Files|*.html|Text Files|*.txt";

            // Dosya daha once kaydedilmediyse saveDialog gosterilir ve kaydedilecek yer kullaniciya sorulur.
            if (!HTMLEdt.isSavedBefore)
            {
                // Dialogtan donen sonuc result a aktarilir.
                result = file.ShowDialog();

                /// * * * * * * * * * *
                /// result OK ise ve gecerli bir fileName varsa,
                /// isSavedBefore true yapilir ve fileName path degiskenine aktarilir.
                /// * * * * * * * * * *
                if (result == System.Windows.Forms.DialogResult.OK && file.FileName.Length > 0)
                {
                    HTMLEdt.isSavedBefore = true;
                    HTMLEdt.path = file.FileName;
                }
            }

            /// * * * * * * * * * *
            /// path degiskeni gecerli bir degere sahipse yazilan text kaydedilir ve isSaved true yapilir.
            /// Kaydetmeyi saglayan menuStrip ve toolStrip false yapilir.
            /// * * * * * * * * * *
            if (HTMLEdt.path.Length > 0)
            {
                File.WriteAllText(HTMLEdt.path, HTMLEdt.richTextBoxX.Text.ToString());
                HTMLEdt.isSaved = true;

                this.saveToolStripButton.Enabled = false;
                HTMLEdt.menuStripX.saveMenuStrip.Enabled = false;
            }
        }

        /// <summary>
        /// * * * * * * * * * *
        /// saveAsToolStripButton un Click eventine eklenen metotu. Save As islemini gerceklestirir.
        /// * * * * * * * * * *
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveAsToolStripButton_Click(object sender, System.EventArgs e)
        {
            /// * * * * * * * * * *
            /// SaveFileDialog tipinde bir file nesnesi olusturuluyor ve default dosya tipi ile diger dosya tipleri belirleniyor.
            /// * * * * * * * * * *
            SaveFileDialog file = new SaveFileDialog();
            file.DefaultExt = "*.html";
            file.Filter = "HTML Files|*.html|Text Files|*.txt";

            /// * * * * * * * * * *
            /// Dialog gosterilip sonuc olarak OK donmesi ve gecerli bir dosya ismi saglanmasi taktirinde if blogu calisiyor.
            /// * * * * * * * * * *
            if (file.ShowDialog() == System.Windows.Forms.DialogResult.OK && file.FileName.Length > 0)
            {

                // Belirtilen dosyaya richTextBoxX taki text yaziliyor.
                File.WriteAllText(file.FileName, HTMLEdt.richTextBoxX.Text.ToString());

                // path degiskenine dosyanin path i aktariliyor.
                HTMLEdt.path = file.FileName;

                // isSaved degiskeni true yapiliyor.
                HTMLEdt.isSaved = true;
            }
        }

        /// <summary>
        /// * * * * * * * * * *
        /// undoToolStripButton un Click eventine eklenen metotu.
        /// * * * * * * * * * *
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void undoToolStripButton_Click(object sender, System.EventArgs e)
        {
            // ***** Richtextbox in Undo metotu. *****
            HTMLEdt.richTextBoxX.Undo();
        }
        /// <summary>
        /// * * * * * * * * * *
        /// redoToolStripButton un Click eventine eklenen metotu.
        /// * * * * * * * * * *
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void redoToolStripButton_Click(object sender, System.EventArgs e)
        {
            // ***** Richtextbox in Redo metotu. *****
            HTMLEdt.richTextBoxX.Redo();
        }

        /// <summary>
        /// * * * * * * * * * *
        /// cutToolStripButton un Click eventine eklenen metotu.
        /// * * * * * * * * * *
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cutToolStripButton_Click(object sender, System.EventArgs e)
        {
            // ***** Richtextbox in Cut metotu. *****
            HTMLEdt.richTextBoxX.Cut();
        }

        /// <summary>
        /// * * * * * * * * * *
        /// copyToolStripButton un Click eventine eklenen metotu.
        /// * * * * * * * * * *
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void copyToolStripButton_Click(object sender, System.EventArgs e)
        {
            // ***** Richtextbox in Copy metotu. *****
            HTMLEdt.richTextBoxX.Copy();
        }

        /// <summary>
        /// * * * * * * * * * *
        /// pasteToolStripButton un Click eventine eklenen metotu.
        /// * * * * * * * * * *
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pasteToolStripButton_Click(object sender, System.EventArgs e)
        {
            // ***** Richtextbox in Paste metotu. *****
            HTMLEdt.richTextBoxX.Paste();
        }

        /// <summary>
        /// helpToolStripButton un Click eventine eklenen metotu. Credit formunu dialog olarak gosterir.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void helpToolStripButton_Click(object sender, System.EventArgs e)
        {
            // ***** CreditDialog Formu orneklenip Dialog olarak gosteriliyor. *****
            new CreditDialog().ShowDialog();
        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        public System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton saveAsToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.ToolStripButton undoToolStripButton;
        public System.Windows.Forms.ToolStripButton redoToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripButton pasteToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
    }
}

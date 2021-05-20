
namespace HTML_Editor
{
    partial class CreditDialog
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.Num = new System.Windows.Forms.Label();
            this.creditGroupBox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Github = new System.Windows.Forms.Button();
            this.LinkedIn = new System.Windows.Forms.Button();
            this.creditGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Open Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameLabel.ForeColor = System.Drawing.Color.Lavender;
            this.NameLabel.Location = new System.Drawing.Point(318, 54);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(326, 82);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Berk KAYA";
            // 
            // Num
            // 
            this.Num.AutoSize = true;
            this.Num.Font = new System.Drawing.Font("Open Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Num.ForeColor = System.Drawing.Color.Lavender;
            this.Num.Location = new System.Drawing.Point(214, 188);
            this.Num.Name = "Num";
            this.Num.Size = new System.Drawing.Size(535, 45);
            this.Num.TabIndex = 1;
            this.Num.Text = "School Number -> 201913709057";
            // 
            // creditGroupBox
            // 
            this.creditGroupBox.Controls.Add(this.button1);
            this.creditGroupBox.Controls.Add(this.Github);
            this.creditGroupBox.Controls.Add(this.LinkedIn);
            this.creditGroupBox.Controls.Add(this.Num);
            this.creditGroupBox.Controls.Add(this.NameLabel);
            this.creditGroupBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.creditGroupBox.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.creditGroupBox.Location = new System.Drawing.Point(12, 12);
            this.creditGroupBox.Name = "creditGroupBox";
            this.creditGroupBox.Size = new System.Drawing.Size(963, 414);
            this.creditGroupBox.TabIndex = 2;
            this.creditGroupBox.TabStop = false;
            this.creditGroupBox.Text = "Credit";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("SansSerif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(909, 23);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 52);
            this.button1.TabIndex = 4;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Github
            // 
            this.Github.BackgroundImage = global::HTML_Editor.Properties.Resources.github;
            this.Github.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Github.FlatAppearance.BorderSize = 0;
            this.Github.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Github.Location = new System.Drawing.Point(508, 290);
            this.Github.Name = "Github";
            this.Github.Size = new System.Drawing.Size(70, 70);
            this.Github.TabIndex = 3;
            this.Github.UseVisualStyleBackColor = true;
            this.Github.Click += new System.EventHandler(this.Github_Click);
            // 
            // LinkedIn
            // 
            this.LinkedIn.BackgroundImage = global::HTML_Editor.Properties.Resources.linkedin;
            this.LinkedIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LinkedIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LinkedIn.Location = new System.Drawing.Point(372, 290);
            this.LinkedIn.Name = "LinkedIn";
            this.LinkedIn.Size = new System.Drawing.Size(70, 70);
            this.LinkedIn.TabIndex = 2;
            this.LinkedIn.UseVisualStyleBackColor = true;
            this.LinkedIn.Click += new System.EventHandler(this.LinkedIn_Click);
            // 
            // CreditDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(987, 444);
            this.Controls.Add(this.creditGroupBox);
            this.ForeColor = System.Drawing.Color.Lavender;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreditDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Credit";
            this.TopMost = true;
            this.creditGroupBox.ResumeLayout(false);
            this.creditGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label Num;
        private System.Windows.Forms.GroupBox creditGroupBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Github;
        private System.Windows.Forms.Button LinkedIn;
    }
}
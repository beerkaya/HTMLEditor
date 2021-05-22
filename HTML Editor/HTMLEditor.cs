using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HTML_Editor.Components;

namespace HTML_Editor
{
    public partial class HTMLEditor : Form
    {
        public HTMLEditor()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Formda son kayittan sonra duzenleme yapilip yapilmadigi bilgisini tutar. 
        /// Default degeri true dur. TextChanged oldugunda false olur. Dosya kaydedildiginde true olur.
        /// </summary>
        public bool isSaved { get; set; } = true;

        /// <summary>
        /// Yazilan kodlarin daha once kaydedilip edilmedigi bilgisini tutar. 
        /// Daha once kaydedilmisse saveDialog gosterilmez.
        /// </summary>
        public bool isSavedBefore { get; set; } = false;

        /// <summary>
        /// Kaydedilen veya acilan dosyanin dosya yolunu tutar.
        /// </summary>
        public string path { get; set; } = "";

        /// <summary>
        /// Renklendirilmek istenen kelimeler, regex ifadeleri ve istenen renkleri tutan tablo.
        /// </summary>
        private static readonly string[,] table = new[,]
        {
            { "DOCTYPE", @"(<(!DOCTYPE)( html)?>)", "blue" },
            { "html", @"(<\/?(html)( [a-z=""]+)?>)", "blue" },
            { "head", @"(<\/?(head)( [a-z=""]+)?>)",  "blue" },
            { "body", @"(<\/?(body)( [a-z=""]+)?>)", "blue" },
            { "meta", @"(<\/?(meta)( [a-z=""]+)?>)", "blue" },
            { "div", @"(<\/?(div)( [a-z=""]+)?>)", "blue" },
            { "span", @"(<\/?(span)( [a-z=""]+)?>)", "blue" },
            { "img", @"(<\/?(img)( [a-z=""]+)?>)", "blue" },
            { "a", @"(<\/?(a)( [a-z=""]+)?>)", "blue" },
            { "title", @"(<\/?(title)( [a-z=""]+)?>)", "blue" },
            { "p", @"(<\/?(p)( [a-z=""]+)?>)", "blue" },
            { "link", @"(<\/?(link)( [a-z=""]+)?>)", "blue" },
            //{ "style", @"(<[a-z] (style)[=""].+"">)", "red" },
            { "style", @"\bstyle\b", "red" },
            { "height", @"\bheight\b", "red" },
            { "width", @"\bwidth\b", "red" },
            { "href",  @"\bhref\b", "red" },
        };

        /// <summary>
        /// HTMLEditor Formunun Load eventinin metotu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HTMLEditor_Load(object sender, EventArgs e)
        {
            // KeywordTable Sinifinin ogeleri orneklenir.
            richTextBoxX.KeywordTable.Keyword = new string[table.GetLength(0)];
            richTextBoxX.KeywordTable.Pattern = new string[table.GetLength(0)];
            richTextBoxX.KeywordTable.Color = new string[table.GetLength(0)];

            // table daki degerler bu sinifin ilgili dizilerine aktarilir.
            for (int i = 0; i < table.GetLength(0); i++)
            {
                richTextBoxX.KeywordTable.Keyword[i] = table.GetValue(i, 0).ToString();
                richTextBoxX.KeywordTable.Pattern[i] = table.GetValue(i, 1).ToString();
                richTextBoxX.KeywordTable.Color[i] = table.GetValue(i, 2).ToString();
            }
        }

        /// <summary>
        /// HTMLEditor Formunun Closing eventinin metotu. isSaved false ise islem yapilir.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HTMLEditor_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            if (!this.isSaved)
            {
                /// * * * * * * * * * *
                /// Bir MessageBox olusturuluyor. Donen sonuc resultQustion a esitleniyor.
                /// MessageBox tan donen sonuc YES ise if blogu calisiyor.
                /// * * * * * * * * * *
                DialogResult resultQuestion = MessageBox.Show("Do you want to save code?", "Are you Sure?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (resultQuestion == DialogResult.Yes)
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
                    if (!this.isSavedBefore)
                    {
                        // Dialogtan donen sonuc result a aktarilir.
                        result = file.ShowDialog();

                        /// * * * * * * * * * *
                        /// result OK ise ve gecerli bir fileName varsa,
                        /// isSavedBefore true yapilir ve fileName path degiskenine aktarilir.
                        /// * * * * * * * * * *
                        if (result == System.Windows.Forms.DialogResult.OK && file.FileName.Length > 0)
                        {
                            this.isSavedBefore = true;
                            this.path = file.FileName;
                        }
                    }

                    /// * * * * * * * * * *
                    /// path degiskeni gecerli bir degere sahipse yazilan text kaydedilir ve isSaved true yapilir.
                    /// Kaydetmeyi saglayan menuStrip ve toolStrip false yapilir.
                    /// * * * * * * * * * *
                    if (this.path.Length > 0)
                    {
                        System.IO.File.WriteAllText(this.path, this.richTextBoxX.Text.ToString());
                        this.isSaved = true;
                    }
                }
                else if(resultQuestion == DialogResult.Cancel)
                {
                    // resultQuestion Cancel ise kapatma iptal ediliyor.
                    e.Cancel = true;
                }
            }
        }
    }
}

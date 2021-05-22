using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTML_Editor.Components
{
    public partial class RichTextBoxX : RichTextBox
    {
        /// <summary>
        /// KeywordTable olusturulur ve new lenir.
        /// </summary>
        public KeywordTable KeywordTable { get; set; } = new();

        /// <summary>
        /// HTMLEditor formuna MenuStripX uzerinden erismeyi saglayan property.
        /// </summary>
        private HTMLEditor HTMLEdt;

        /// <summary>
        /// RichTextBoxX yapici metotu. Metot HTMLEditor tipinde bir nesne de alir.
        /// </summary>
        /// <param name="container"></param>
        /// <param name="HTMLEdt"></param>
        public RichTextBoxX(IContainer container, HTMLEditor HTMLEdt)
        {
            // ***
            //  richTextBoxX olusturulurken gonderilen HTMLEditor tipindeki nesne siniftaki nesneye aktariliyor,
            //  container e bu nesne ekleniyor bilesenlerin ozelliklerini iceren InitializeComponent metotu calistiriliyor.
            // ***
            this.HTMLEdt = HTMLEdt;

            container.Add(this);

            InitializeComponent();

            // TextChanged eventine hazirlanan metot ekleniyor.
            this.TextChanged += RichTextBoxX_TextChanged;
        }

        /// <summary>
        /// Klavyede basilan ozel tuslari yakalayan metot. TAB ve Shift+TAB kombinasyonlarini yakalamak icin kullanilmaktadir.
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="keyData"></param>
        /// <returns></returns>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) // finalde editlenecek
        {
            // Imlec pozisyonu integer a aktarilir.
            int position = this.SelectionStart;

            // Basilan tus TAB ise ve richTextBoxX a focus edilmisse text burdan bolunur ve 3 spacelik bosluk eklenir. Imlec pozisyonu 3 arttirilir.
            if (keyData == Keys.Tab && this.Focused)
            {
                //this.Text += "   ";
                this.Text = String.Concat(this.Text.Substring(0, position), "   ", this.Text[position..]);
                this.SelectionStart = position + 3;
            }
            
            this.Invalidate();


            #region  -----   Daha sonra düzenlenecek   -----
            //if (keyData == (Keys.Tab | Keys.Shift) && this.Focused)
            //{
            //    this.Text = String.Concat(this.Text.Substring(0, position - 3), this.Text[position..]);
            //    this.SelectionStart = position - 3;
            //}
            #endregion

            // Metot return edilir.
            return base.ProcessCmdKey(ref msg, keyData);
        }
        /// <summary>
        /// RichTextBoxX in TextChanged metotu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RichTextBoxX_TextChanged(object sender, EventArgs e)
        {
            /// * * * * * * * * * *
            /// isSaved false yapilir, Kaydetmeyi saglayan menuStrip ve toolStrip true yapilir.
            /// * * * * * * * * * *
            HTMLEdt.isSaved = false;
            HTMLEdt.toolStripX.saveToolStripButton.Enabled = true;
            HTMLEdt.menuStripX.saveMenuStrip.Enabled = true;

            /// * * * * * * * * * *
            /// undo-redo toolStrip ve menuStrip leri duzenlenir.
            /// * * * * * * * * * *
            HTMLEdt.toolStripX.undoToolStripButton.Enabled = this.CanUndo;
            HTMLEdt.toolStripX.redoToolStripButton.Enabled = this.CanRedo;
            HTMLEdt.menuStripX.undoMenuStrip.Enabled = this.CanUndo;
            HTMLEdt.menuStripX.redoMenuStrip.Enabled = this.CanRedo;

            /// * * * * * * * * * * * * * * * * * * * *
            ///         RENK DEGISTIRME ISLEMI
            /// * * * * * * * * * * * * * * * * * * * *


            // richTextBoxX Disable yapilir..
            this.Enabled = false;
            // TextChanged metotu eventten cikarilir.
            this.TextChanged -= RichTextBoxX_TextChanged;
            // Renk degistirme metotu calistirilir.
            ChgColorKeywords();
            // richTextBox Invalidate edilir.
            this.Invalidate();
            // TextChanged metotu evente eklenir.
            this.TextChanged += RichTextBoxX_TextChanged;
            // richTextBox Enable yapilir.
            this.Enabled = true;
            // richTextBox a focuslanir.
            this.Focus();

            /// * * * * * * * * * * * * * * * * * * * *
            /// * * * * * * * * * * * * * * * * * * * *
        }
        /// <summary>
        /// * * * * * * * * * * RENK DEGISTIRME METOTU * * * * * * * * * *
        /// </summary>
        public void ChgColorKeywords()
        {
            // Imlec pozisyonu integer a aktarilir.
            int position = SelectionStart;

            /// * * * * * * * * * * * * * * * * * * * *
            /// Burada tablodaki kelimeler teker teker geziliyor. Her kelime icin metin kontrol ediliyor.
            /// Metindeki ilgili kelime her seferinde seciliyor ve selectioncolor ozelligiyle renk tablosundaki karsilik gelen renk uygulaniyor.
            /// * * * * * * * * * * * * * * * * * * * *
            for (int i = 0; i < KeywordTable.Keyword.Length; i++)
            {
                // Regex ifadesinin olusturulmasi
                Regex regex = new(KeywordTable.Pattern[i]);
                // Eslesen regexleri gezen foreach
                foreach (Match match in regex.Matches(this.Text))
                {
                    /// * * * * * * * * * *
                    /// Burada selection isleminin dogru yapilabilmesi icin a ve b degerleri duzenleniyor.
                    /// '<' varsa indexe 1 ekleniyor ve secimin sonunda length ten 2 cikariliyor.
                    /// '<' ve '/' varsa indexe 2 ekleniyor ve secimin sonunda length ten 3 cikariliyor.
                    /// iki karakter de yoksa a ve b degerleri 0 degeri aliyor ve herhangi bir degisiklik olmuyor.
                    /// * * * * * * * * * *
                    int a = !match.Value.Contains("<") ? 0 : match.Value.Contains("/") ? 2 : 1;
                    int b = !match.Value.Contains("<") ? 0 : match.Value.Contains("/") ? 3 : 2;


                    MatchCollection temp = regex.Matches(match.Value);
                    string attribute = temp[^1].Groups[2].Value;

                    this.Select(match.Index + a, attribute != "" ? attribute.Length : match.Length - b);
                    this.SelectionColor = Color.FromName(KeywordTable.Color[i]);
                }
            }

            // Burada deselect yapiliyor. Secimler kaldiriliyor.
            this.DeselectAll();

            // SelectionStart ayarlanip imlec yeri belirleniyor.
            this.SelectionStart = position;

            // Renk sonraki yazimlarda devam etmemesi icin color black yapiliyor.
            this.SelectionColor = Color.Black;
        }
        /// * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
    }
    /// <summary>
    /// KeywordTable sinifi. Keywordleri, Regex patternlerini ve Color lari tutar.
    /// </summary>
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class KeywordTable
    {
        public string[] Keyword { get; set; } = new List<string>().ToArray();

        public string[] Pattern { get; set; } = new List<string>().ToArray();

        public string[] Color { get; set; } = new List<string>().ToArray();
    }
}

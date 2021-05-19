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
        public KeywordTable KeywordTable { get; set; } = new();
        public RichTextBoxX(IContainer container)
        {
            container.Add(this);

            InitializeComponent();

            this.TextChanged += RichTextBoxX_TextChanged;

            EventInfo eventInfo = this.GetType().GetEvent("TextChanged");

            //this.Selectable = true;
        }
        //const int WM_SETFOCUS = 0x0007;
        //const int WM_KILLFOCUS = 0x0008;
        //[DefaultValue(true)]
        //public bool Selectable { get; set; }
        //protected override void WndProc(ref Message m)
        //{
        //    if (m.Msg == WM_SETFOCUS && !Selectable)
        //        m.Msg = WM_KILLFOCUS;

        //    base.WndProc(ref m);
        //}
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) // finalde editlenecek
        {
            int position = this.SelectionStart;

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

            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void RichTextBoxX_TextChanged(object sender, EventArgs e)
        {
            this.Enabled = false;
            this.TextChanged -= RichTextBoxX_TextChanged;

            ChgColorKeywords();

            this.Invalidate();
            this.TextChanged += RichTextBoxX_TextChanged;
            this.Enabled = true;
            this.Focus();
        }
        public void ChgColorKeywords()
        {
            int position = SelectionStart;
            for (int i = 0; i < KeywordTable.Keyword.Length; i++)
            {
                Regex regex = new(KeywordTable.Pattern[i]);
                foreach (Match match in regex.Matches(this.Text))
                {
                    int a = !match.Value.Contains("<") ? 0 : match.Value.Contains("/") ? 2 : 1;
                    int b = !match.Value.Contains("<") ? 0 : match.Value.Contains("/") ? 3 : 2;

                    MatchCollection test1 = regex.Matches(match.Value);
                    string test = test1[^1].Groups[2].Value;
                    this.Select(match.Index + a, test != "" ? test.Length : match.Length - b);
                    this.SelectionColor = Color.FromName(KeywordTable.Color[i]);
                }
            }

            this.DeselectAll();

            this.SelectionStart = position;

            this.SelectionColor = Color.Black;
        }
    }
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class KeywordTable
    {
        public string[] Keyword { get; set; } = new List<string>().ToArray();

        public string[] Pattern { get; set; } = new List<string>().ToArray();

        public string[] Color { get; set; } = new List<string>().ToArray();
    }
}

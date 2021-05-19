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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool isSaved { get; set; } = true;
        public bool isSavedBefore { get; set; } = false;
        public string path { get; set; } = "";

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
        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBoxX.KeywordTable.Keyword = new string[table.GetLength(0)];
            richTextBoxX.KeywordTable.Pattern = new string[table.GetLength(0)];
            richTextBoxX.KeywordTable.Color = new string[table.GetLength(0)];
            for (int i = 0; i < table.GetLength(0); i++)
            {
                richTextBoxX.KeywordTable.Keyword[i] = table.GetValue(i, 0).ToString();
                richTextBoxX.KeywordTable.Pattern[i] = table.GetValue(i, 1).ToString();
                richTextBoxX.KeywordTable.Color[i] = table.GetValue(i, 2).ToString();
            }
        }

        
    }
}

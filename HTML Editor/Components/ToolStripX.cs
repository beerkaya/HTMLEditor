using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTML_Editor.Components
{
    public partial class ToolStripX : UserControl
    {
        //public OpenFileDialog openFile { get; set; }
        //public SaveFileDialog saveFile { get; set; }
        private RichTextBoxX richTextBoxX;
        public ToolStripX(RichTextBoxX richTextBoxX)
        {
            this.richTextBoxX = richTextBoxX;
            InitializeComponent();
        }
    }
}

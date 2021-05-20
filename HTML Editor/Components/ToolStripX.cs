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
        private HTMLEditor HTMLEdt;
        public ToolStripX(HTMLEditor HTMLEdt)
        {
            this.HTMLEdt = HTMLEdt;
            InitializeComponent();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTML_Editor.Components
{
    public partial class MenuStripX : UserControl
    {
        private Form1 HTMLEdt;
        public MenuStripX(Form1 HTMLEdt)
        {
            this.HTMLEdt = HTMLEdt;
            InitializeComponent();
        }
    }
}

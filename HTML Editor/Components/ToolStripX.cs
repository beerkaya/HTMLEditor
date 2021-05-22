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
        /// <summary>
        /// HTMLEditor formuna ToolStripX uzerinden erismeyi saglayan property.
        /// </summary>
        private HTMLEditor HTMLEdt;
        /// <summary>
        /// ToolStripX yapici metotu.
        /// </summary>
        /// <param name="HTMLEdt"></param>
        public ToolStripX(HTMLEditor HTMLEdt)
        {
            // ***
            //  ToolstripX olusturulurken gonderilen HTMLEditor tipindeki nesne siniftaki nesneye aktariliyor ve
            //  bilesenlerin ozelliklerini iceren InitializeComponent metotu calistiriliyor.
            // ***
            this.HTMLEdt = HTMLEdt;
            InitializeComponent();
        }
    }
}

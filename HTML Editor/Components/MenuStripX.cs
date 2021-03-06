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
        /// <summary>
        /// HTMLEditor formuna MenuStripX uzerinden erismeyi saglayan property.
        /// </summary>
        private HTMLEditor HTMLEdt;

        /// <summary>
        /// MenuStripX yapici metotu
        /// </summary>
        /// <param name="HTMLEdt"></param>
        public MenuStripX(HTMLEditor HTMLEdt)
        {

        // ***
        //  MenustripX olusturulurken gonderilen HTMLEditor tipindeki nesne siniftaki nesneye aktariliyor ve
        //  bilesenlerin ozelliklerini iceren InitializeComponent metotu calistiriliyor.
        // ***
            this.HTMLEdt = HTMLEdt;
            InitializeComponent();
        }
    }
}

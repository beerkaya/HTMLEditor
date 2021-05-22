using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTML_Editor
{
    public partial class CreditDialog : Form
    {
        /// <summary>
        /// CreditDialog Formunun kurucu metotu.
        /// </summary>
        public CreditDialog()
        {
            InitializeComponent();
        }

        /// <summary>
        /// * * * * * * * * * *
        /// LinkedIn pictureBox unun Click metotu. Tarayicida LinkedIn sayfasina yonlendirir.
        /// * * * * * * * * * *
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LinkedIn_Click(object sender, EventArgs e)
        {
            // Process.Start metotuna ProcessStartInfo tipinde link bilgisi gonderiliyor.
            Process.Start(
            new ProcessStartInfo
            {
                FileName = "https://www.linkedin.com/in/beerkaya/",
                UseShellExecute = true
            });
        }

        /// <summary>
        /// * * * * * * * * * *
        /// Github pictureBox unun Click metotu. Tarayicida Github sayfasina yonlendirir.
        /// * * * * * * * * * *
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Github_Click(object sender, EventArgs e)
        {
            // Process.Start metotuna ProcessStartInfo tipinde link bilgisi gonderiliyor.
            Process.Start(
            new ProcessStartInfo
            {
                FileName = "https://github.com/beerkaya",
                UseShellExecute = true
            });
        }

        /// <summary>
        /// CreditDialog formunun kapatma butonu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClose_Click(object sender, EventArgs e)
        {
            // Bu formun close metotu calistiriliyor.
            this.Close();
        }
    }
}

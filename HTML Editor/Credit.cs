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
        public CreditDialog()
        {
            InitializeComponent();
        }

        private void LinkedIn_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psInfo = new ProcessStartInfo
            {
                FileName = "https://www.linkedin.com/in/beerkaya/",
                UseShellExecute = true
            };
            Process.Start(psInfo);
        }

        private void Github_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psInfo = new ProcessStartInfo
            {
                FileName = "https://github.com/beerkaya",
                UseShellExecute = true
            };
            Process.Start(psInfo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

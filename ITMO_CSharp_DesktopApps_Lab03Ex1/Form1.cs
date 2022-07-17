using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO_CSharp_DesktopApps_Lab03Ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkTimer_CheckedChanged(object sender, EventArgs e)
        {
            if (checkTimer.Checked == true)
            {
                userControlTimer1.TimeEnabled = true;
            }
            else
            {
                userControlTimer1.TimeEnabled = false;
            }
        }
    }
}

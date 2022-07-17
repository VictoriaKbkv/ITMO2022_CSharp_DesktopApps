using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO_CSharp_DesktopApps_FinalProject
{
    public partial class EditShareForm : Form
    {
        public string ShareDesc
        {
            get { return ShareDescTxtBx.Text; }
            set { ShareDescTxtBx.Text = value; }
        }
        public string ShareTicker
        {
            get { return ShareTickerTxtBx.Text; }
            set { ShareTickerTxtBx.Text = value; }
        }
        public decimal SharePrice
        {
            get { return Convert.ToDecimal(SharePriceTxtBx.Text); }
            set { SharePriceTxtBx.Text = value.ToString(); }
        }

        public EditShareForm()
        {
            InitializeComponent();
            ShareDescTxtBx.Select();
        }

        public void ShareDescTxtBx_Validating(object sender, CancelEventArgs e)
        {
            if (ShareDescTxtBx.Text == "")
            {
                e.Cancel = true;
                MessageBox.Show("Share description must be filled");
            }
            else
            {
                SharePriceTxtBx.Select();
                e.Cancel = false;
            }
        }

        public void SharePriceTxtBx_Validating(object sender, CancelEventArgs e)
        {
            if (SharePriceTxtBx.Text == "")
            {
                e.Cancel = true;
                MessageBox.Show("Share price must be filled");
            }
            else
            {
                try
                {
                    Convert.ToDecimal(SharePriceTxtBx.Text);
                    e.Cancel = false;
                }
                catch
                {
                    e.Cancel = true;
                    MessageBox.Show("Please, enter correct decimal price");
                }
            }
        }

    }
}

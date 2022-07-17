using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ITMO_CSharp_DesktopApps_FinalProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            string connection = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=ApressFinancial;Data Source=LAPTOP-O2PP9KP6\SQLEXPRESS";
            string query = @"select [ShareDesc],[ShareTickerID],[CurrentPrice] from [ShareDetails].[Shares]";

            listViewShares.Items.Clear();

            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query,conn))
                {
                    using (SqlDataReader read = cmd.ExecuteReader())
                    {
                        while (read.Read())
                        {
                            ListViewItem newItem = listViewShares.Items.Add(read["ShareDesc"].ToString());
                            newItem.SubItems.Add(read["ShareTickerID"].ToString());
                            newItem.SubItems.Add(read["CurrentPrice"].ToString());
                        }
                        read.Close();
                    }
                }
                conn.Close();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            
                string connection = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=ApressFinancial;Data Source=LAPTOP-O2PP9KP6\SQLEXPRESS";
                

                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();
                    if (listViewShares.SelectedItems.Count == 0)
                        return;
                    foreach (ListViewItem item in listViewShares.SelectedItems)
                    {
                        string query = "delete from [ShareDetails].[Shares] where [ShareTickerID] = '"+ item.SubItems[1].Text + "' and [ShareDesc] = '"+ item.Text + "'";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.ExecuteNonQuery();
                        }
                        item.Remove();
                    }
                    conn.Close();

                }
            
        }

       
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            SearchForm SForm = new SearchForm();
            if (SForm.ShowDialog() != DialogResult.OK) return;
            string connection = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=ApressFinancial;Data Source=LAPTOP-O2PP9KP6\SQLEXPRESS";
            string query = @"select [ShareDesc], [ShareTickerID], [CurrentPrice] from [ShareDetails].[Shares] where ([ShareDesc] like '"+ SForm.SearchShareDesc + "%') and ([ShareTickerID] like '"+SForm.SearchShareTicker+"%')";

            listViewShares.Items.Clear();

            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader read = cmd.ExecuteReader())
                    {
                        while (read.Read())
                        {
                            ListViewItem newItem = listViewShares.Items.Add(read["ShareDesc"].ToString());
                            newItem.SubItems.Add(read["ShareTickerID"].ToString());
                            newItem.SubItems.Add(read["CurrentPrice"].ToString());
                        }
                        read.Close();
                    }
                }
                conn.Close();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            authorizationForm login = new authorizationForm();
            login.ShowDialog();
        }

        private void tsbtnAdd_Click(object sender, EventArgs e)
        {
            EditShareForm editForm = new EditShareForm();
            if (editForm.ShowDialog() != DialogResult.OK) return;

            string connection = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=ApressFinancial;Data Source=LAPTOP-O2PP9KP6\SQLEXPRESS";
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO [ShareDetails].[Shares] ([ShareDesc],[ShareTickerID],[CurrentPrice]) VALUES (@desc,@ticker,@price)", conn))
                {
                    cmd.Parameters.AddWithValue("@desc", editForm.ShareDesc);
                    cmd.Parameters.AddWithValue("@ticker", editForm.ShareTicker);
                    cmd.Parameters.AddWithValue("@price", editForm.SharePrice);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();

            }

            ListViewItem newItem = listViewShares.Items.Add(editForm.ShareDesc);
            newItem.SubItems.Add(editForm.ShareTicker);
            newItem.SubItems.Add(editForm.SharePrice.ToString());
        }

        private void tsbtnClear_Click(object sender, EventArgs e)
        {
            listViewShares.Items.Clear();
        }
    }
}

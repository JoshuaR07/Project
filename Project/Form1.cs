using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Project
{
    public partial class Form1 : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;
        private DataSet ds = new DataSet();
        private string alamat, query;
        public Form1()
        {
            alamat = "server=localhost; database=db_vispro24; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                query = string.Format("select * from tbl_penumpang where username = '{0}'", txtuser.Text);
                ds.Clear();
                koneksi.Open();
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                adapter.Fill(ds);
                koneksi.Close();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow kolom in ds.Tables[0].Rows)
                    {
                        string sandi;
                        string level;
                        level = kolom["level"].ToString();
                        sandi = kolom["password"].ToString();
                        if (sandi == txtpass.Text)
                        {
                            if (level == "1")
                            {
                                FrmWelcome form1 = new FrmWelcome();
                                form1.Show();
                                this.Hide();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Password Not Found");
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Username Not Found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

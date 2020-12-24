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

namespace libraryManagement
{
    public partial class loginstudent : Form
    {
        public loginstudent()
        {
            InitializeComponent();
        }

        private void passlb_Click(object sender, EventArgs e)
        {

        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void loginbtn_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from  Tbl_Student where StudentTC=@k1 and StudentPassword=@k2", bgl.baglanti());
            komut.Parameters.AddWithValue("@k1", idtb.Text);
            komut.Parameters.AddWithValue("@k2", passtb.Text);
            SqlDataReader dr = komut.ExecuteReader();
            string id = idtb.Text.Trim();
            string pass = passtb.Text.Trim();

            if (dr.Read())
            {
                Form1 fr = new Form1();
                fr.Show();
                this.Hide();

            }

            else
            {
                if (String.IsNullOrEmpty(id))
                {
                    MessageBox.Show("please enter your ID");
                    idtb.Focus();
                    return;
                }
                if (String.IsNullOrEmpty(pass))
                {
                    MessageBox.Show("please enter your PASSWORD");
                    passtb.Focus();
                    return;
                }
                else
                {
                    MessageBox.Show("ID or PASSWORD is wrong");
                }

            }
            bgl.baglanti().Close();
        }
    }
}

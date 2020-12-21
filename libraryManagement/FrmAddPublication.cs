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
    public partial class FrmAddPublication : Form
    {
        public FrmAddPublication()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Adding new Publication to DataBase
            SqlCommand komut = new SqlCommand("insert into Tbl_Publication (PublicationName) values (@p1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",txtName.Text);


            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Successfull");
            txtName.Clear();
        }
    }
}

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
    public partial class FrmAddBook : Form
    {
        public FrmAddBook()
        {
            InitializeComponent();
        }

        private void btnPicture_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            lblDosyaName.Text = openFileDialog1.FileName;
            pictureBoxPic.ImageLocation = openFileDialog1.FileName;
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Adding new student to DataBase
            SqlCommand komut = new SqlCommand("insert into Tbl_Book (BookName,BookDetail,BookAuthor," +
                "BookPublication,BookCategories,BookPrice,BookQuantity,BookPhoto,BookShelf) values " +
                "(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtBookName.Text);
            komut.Parameters.AddWithValue("@p2", rchDetail.Text);
            komut.Parameters.AddWithValue("@p3", txtAuthor.Text);
            komut.Parameters.AddWithValue("@p4", cmbPublication.Text);
            komut.Parameters.AddWithValue("@p5", cmbCategories.Text);
            komut.Parameters.AddWithValue("@p6", txtPrice.Text);
            komut.Parameters.AddWithValue("@p7", txtQuantity.Text);
            komut.Parameters.AddWithValue("@p8", lblDosyaName.Text);
            komut.Parameters.AddWithValue("@p9", txtShelf.Text);
            
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Successfull");

            txtBookName.Clear();
            rchDetail.Clear();
            txtAuthor.Clear();
            cmbPublication.Items.Clear();
            cmbCategories.Items.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
            txtShelf.Clear();

            
            
        }
    }
}

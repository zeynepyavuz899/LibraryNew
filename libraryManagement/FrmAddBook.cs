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
                "BookPublication,BookCategories,BookPrice,BookQuantity,BookPhoto,BookShelf,BookAvailable,BookRent) values " +
                "(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtBookName.Text);
            komut.Parameters.AddWithValue("@p2", rchDetail.Text);
            komut.Parameters.AddWithValue("@p3", txtAuthor.Text);
            komut.Parameters.AddWithValue("@p4", cmbPublication.Text);
            komut.Parameters.AddWithValue("@p5", cmbCategories.Text);
            komut.Parameters.AddWithValue("@p6", txtPrice.Text);
            komut.Parameters.AddWithValue("@p7", txtQuantity.Text);
            komut.Parameters.AddWithValue("@p8", lblDosyaName.Text);
            komut.Parameters.AddWithValue("@p9", txtShelf.Text);
            komut.Parameters.AddWithValue("p10", txtQuantity.Text);
            komut.Parameters.AddWithValue("p11", "0");
            
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Successfull");

            txtBookName.Clear();
            rchDetail.Clear();
            txtAuthor.Clear();
            cmbPublication.Text = "";
            cmbCategories.Text = "";
            txtPrice.Clear();
            txtQuantity.Clear();
            txtShelf.Clear();
            pictureBoxPic.ImageLocation = "";




        }

        private void FrmAddBook_Load(object sender, EventArgs e)
        {
            //Getting Department Names form DataBase
            SqlCommand getPub = new SqlCommand("Select PublicationName From Tbl_Publication", bgl.baglanti());
            SqlDataReader getPubRd = getPub.ExecuteReader();
            while (getPubRd.Read())
            {
                cmbPublication.Items.Add(getPubRd[0]);
            }
            bgl.baglanti().Close();


            //Getting Categories Names form DataBase
            SqlCommand getCat = new SqlCommand("Select CategorieName From Tbl_Categorie", bgl.baglanti());
            SqlDataReader drgetCat = getCat.ExecuteReader();
            while (drgetCat.Read())
            {
                cmbCategories.Items.Add(drgetCat[0]);
            }
            bgl.baglanti().Close();
        }

       
    }
}

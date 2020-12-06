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
    public partial class FrmLibrarianEdit : Form
    {
        public FrmLibrarianEdit()
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
        public string TCno;

        private void FrmLibrarianEdit_Load(object sender, EventArgs e)
        {

            //Getting informations from data base 
            lblTC2.Text = TCno;

            SqlCommand GetLibrarian = new SqlCommand("Select LibrarianName,LibrarianSurname,LibrarianEmail,LibrarianGender,LibrarianPhone,LibrarianPassword,LibrarianPicture From Tbl_Librarian where LibrarianTC=@p1", bgl.baglanti());
            GetLibrarian.Parameters.AddWithValue("@p1", lblTC2.Text);
            SqlDataReader GetLibrarianDr = GetLibrarian.ExecuteReader();
            while (GetLibrarianDr.Read())
            {
                txtName.Text = GetLibrarianDr[0].ToString();
                txtSurname.Text = GetLibrarianDr[1].ToString();
                txtMail.Text = GetLibrarianDr[2].ToString();
                cmbGender.Text = GetLibrarianDr[3].ToString();
                mskPhone.Text = GetLibrarianDr[4].ToString();
                txtPassword.Text = GetLibrarianDr[5].ToString();
                lblDosyaName.Text = GetLibrarianDr[6].ToString();
                bgl.baglanti().Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //update new profile informations
            SqlCommand updateLibrarian = new SqlCommand("update Tbl_Librarian set LibrarianName=@p1,LibrarianSurname=@p2,LibrarianEmail=@p3,LibrarianGender=@p4,LibrarianPhone=@p5,LibrarianPassword=@p6,LibrarianPicture=@p7 where LibrarianTC=@p8", bgl.baglanti());
            updateLibrarian.Parameters.AddWithValue("@p1", txtName.Text);
            updateLibrarian.Parameters.AddWithValue("@p2", txtSurname.Text);
            updateLibrarian.Parameters.AddWithValue("@p3", txtMail.Text);
            updateLibrarian.Parameters.AddWithValue("@p4", cmbGender.Text);
            updateLibrarian.Parameters.AddWithValue("@p5", mskPhone.Text);
            updateLibrarian.Parameters.AddWithValue("@p6", txtPassword.Text);
            updateLibrarian.Parameters.AddWithValue("@p7", lblDosyaName.Text);
            updateLibrarian.Parameters.AddWithValue("@p8", lblTC2.Text);
            updateLibrarian.ExecuteNonQuery();
            bgl.baglanti().Close();
            this.Close();
            MessageBox.Show("Succesfull");
        }
    }
}

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
    public partial class FrmStudentEditAccount : Form
    {
        public FrmStudentEditAccount()
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

        private void FrmStudentEditAccount_Load(object sender, EventArgs e)
        {
            //Getting informations from data base 
            lblTC2.Text = TCno;

            SqlCommand GetLibrarian = new SqlCommand("Select StudentName,StudentSurname,StudentEmail,StudentGender,StudentPhone,StudentDepartment,StudentPassword,StudentPicture From Tbl_Student where StudentTC=@p1", bgl.baglanti());
            GetLibrarian.Parameters.AddWithValue("@p1", lblTC2.Text);
            SqlDataReader GetLibrarianDr = GetLibrarian.ExecuteReader();
            while (GetLibrarianDr.Read())
            {
                txtName.Text = GetLibrarianDr[0].ToString();
                txtSurname.Text = GetLibrarianDr[1].ToString();
                txtMail.Text = GetLibrarianDr[2].ToString();
                cmbGender.Text = GetLibrarianDr[3].ToString();
                mskPhone.Text = GetLibrarianDr[4].ToString();
                lblDepartment2.Text = GetLibrarianDr[5].ToString();
                txtPassword.Text = GetLibrarianDr[6].ToString();
                pictureBoxPic.ImageLocation = GetLibrarianDr[7].ToString();
                bgl.baglanti().Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
             //update new profile informations
            SqlCommand updateStudent = new SqlCommand("update Tbl_Student set StudentName=@p1,StudentSurname=@p2,StudentEmail=@p3,StudentGender=@p4,StudentPhone=@p5,StudentPassword=@p6,StudentPicture=@p7 where StudentTC=@p8", bgl.baglanti());
            updateStudent.Parameters.AddWithValue("@p1", txtName.Text);
            updateStudent.Parameters.AddWithValue("@p2", txtSurname.Text);
            updateStudent.Parameters.AddWithValue("@p3", txtMail.Text);
            updateStudent.Parameters.AddWithValue("@p4", cmbGender.Text);
            updateStudent.Parameters.AddWithValue("@p5", mskPhone.Text);
            updateStudent.Parameters.AddWithValue("@p6", txtPassword.Text);
            updateStudent.Parameters.AddWithValue("@p7", lblDosyaName.Text);
            updateStudent.Parameters.AddWithValue("@p8", lblTC2.Text);
            updateStudent.ExecuteNonQuery();
            bgl.baglanti().Close();
            this.Close();
            MessageBox.Show("Succesfull");
        }
    }
}

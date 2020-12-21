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
    public partial class FrmAddStudent : Form
    {

        
        sqlbaglantisi bgl = new sqlbaglantisi();
        public FrmAddStudent()
        {
            InitializeComponent();
        }


        private void FrmAddStudent_Load(object sender, EventArgs e)
        {
            //Getting Department Names form DataBase
            SqlCommand getDep = new SqlCommand("Select DepartmentName From Tbl_Department", bgl.baglanti());
            SqlDataReader getDepRd = getDep.ExecuteReader();
            while (getDepRd.Read())
            {
                cmbDepartment.Items.Add(getDepRd[0]);
            }
        }

        private void ıconButton1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            lblDosyaName.Text = openFileDialog1.FileName;
            pictureBoxPic.ImageLocation = openFileDialog1.FileName;
        }



        

        //Add  Student  Button
        private void btnAdd_Click(object sender, EventArgs e)
        {

            //Adding new student to DataBase
            SqlCommand komut = new SqlCommand("insert into Tbl_Student (StudentName,StudentSurname,StudentEmail," +
                "StudentGender,StudentPhone,StudentTC,StudentDepartment,StudentPassword,StudentPicture) values " +
                "(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtName.Text);
            komut.Parameters.AddWithValue("@p2", txtSurname.Text);
            komut.Parameters.AddWithValue("@p3", txtMail.Text);
            komut.Parameters.AddWithValue("@p4", cmbGender.Text);
            komut.Parameters.AddWithValue("@p5", mskPhone.Text);
            komut.Parameters.AddWithValue("@p6", mskTC.Text);
            komut.Parameters.AddWithValue("@p7", cmbDepartment.Text);
            komut.Parameters.AddWithValue("@p8", mskTC.Text);
            komut.Parameters.AddWithValue("@p9", lblDosyaName.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            txtName.Clear();
            txtSurname.Clear();
            txtMail.Clear();
            cmbGender.Text = "";
            mskPhone.Clear();
            cmbDepartment.Text = "";
            mskTC.Clear();
            pictureBoxPic.ImageLocation = "";




            MessageBox.Show("Successful");
        }

        
    }
}

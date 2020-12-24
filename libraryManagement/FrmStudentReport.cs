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
    public partial class FrmStudentReport : Form
    {
        public FrmStudentReport()
        {
            InitializeComponent();
        }

        


        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmStudentReport_Load(object sender, EventArgs e)
        {
            //Gets Departments from DataBase
            SqlCommand getDep = new SqlCommand("Select DepartmentName From Tbl_Department", bgl.baglanti());
            SqlDataReader drGetDep = getDep.ExecuteReader();
            while (drGetDep.Read())
            {
                cmbDep.Items.Add(drGetDep[0]);
            }
            bgl.baglanti().Close();

            //Gets Departments from DataBase
            SqlCommand getDep2 = new SqlCommand("Select DepartmentName From Tbl_Department", bgl.baglanti());
            SqlDataReader drGetDep2 = getDep2.ExecuteReader();
            while (drGetDep2.Read())
            {
                cmbDepartment.Items.Add(drGetDep2[0]);
            }
            bgl.baglanti().Close();
        }

        

        private void ıconButton1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            dataGridView1.Visible = true;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select StudentName, StudentSurname, StudentEmail,StudentGender,StudentPhone,StudentTC,StudentDepartment From Tbl_Student where StudentDepartment ='" + cmbDep.Text + "'" + "and StudentName LIKE '" + txtName1.Text + "%'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Visible = false;
            groupBox1.Visible = true;
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string TC = dataGridView1.Rows[secilen].Cells[5].Value.ToString();

            //Get student informations from database
            SqlCommand getStudentInfo = new SqlCommand("Select * From Tbl_Student where StudentTC=@p1", bgl.baglanti());
            getStudentInfo.Parameters.AddWithValue("@p1", TC);
            SqlDataReader drGetStudentInfo = getStudentInfo.ExecuteReader();
            while (drGetStudentInfo.Read())
            {
                lblID.Text = drGetStudentInfo[0].ToString();
                txtName.Text = drGetStudentInfo[1].ToString();
                txtSurname.Text = drGetStudentInfo[2].ToString();
                txtMail.Text = drGetStudentInfo[3].ToString();
                cmbGender.Text = drGetStudentInfo[4].ToString();
                mskPhone.Text = drGetStudentInfo[5].ToString();
                lblTC2.Text = drGetStudentInfo[6].ToString();
                cmbDepartment.Text = drGetStudentInfo[7].ToString();
                pictureBoxPic.ImageLocation = drGetStudentInfo[9].ToString();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            dataGridView1.Visible = true;
        }

        private void btnPicture_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            lblDosyaName.Text = openFileDialog1.FileName;
            pictureBoxPic.ImageLocation = openFileDialog1.FileName;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //update new profile informations
            SqlCommand updateStudent = new SqlCommand("update Tbl_Student set StudentName=@p1,StudentSurname=@p2,StudentEmail=@p3" +
                ",StudentGender=@p4,StudentPhone=@p5,StudentDepartment=@p6,StudentPicture=@p7 where StudentID=@p8", bgl.baglanti());
            updateStudent.Parameters.AddWithValue("@p1", txtName.Text);
            updateStudent.Parameters.AddWithValue("@p2", txtSurname.Text);
            updateStudent.Parameters.AddWithValue("@p3", txtMail.Text);
            updateStudent.Parameters.AddWithValue("@p4", cmbGender.Text);
            updateStudent.Parameters.AddWithValue("@p5", mskPhone.Text);
            updateStudent.Parameters.AddWithValue("@p6", cmbDepartment.Text);
            updateStudent.Parameters.AddWithValue("@p7", lblDosyaName.Text);
            updateStudent.Parameters.AddWithValue("@p8", lblID.Text);
            updateStudent.ExecuteNonQuery();
            bgl.baglanti().Close();
            cmbDep.Text = "";
            txtName.Clear();
            groupBox1.Visible = false;
            MessageBox.Show("Succesfull");
        }
    }
}

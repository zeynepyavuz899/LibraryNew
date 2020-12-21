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
    public partial class FrmStudentAccount : Form
    {
        public FrmStudentAccount()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        private void FrmStudentAccount_Load(object sender, EventArgs e)
        {


            lblTC2.Text = "22345234522";
            //Gets information to the panel
            SqlCommand GetLibrarian = new SqlCommand("Select StudentName,StudentSurname,StudentEmail,StudentGender,StudentPhone,StudentDepartment,StudentPicture From Tbl_Student where StudentTC=@p1", bgl.baglanti());
            GetLibrarian.Parameters.AddWithValue("@p1", lblTC2.Text);
            SqlDataReader GetLibrarianDr = GetLibrarian.ExecuteReader();
            while (GetLibrarianDr.Read())
            {
                lblLibrarian2.Text = GetLibrarianDr[0] + " " + GetLibrarianDr[1];
                lblMail2.Text = GetLibrarianDr[2].ToString();
                lblGender2.Text = GetLibrarianDr[3].ToString();
                lblPhone2.Text = GetLibrarianDr[4].ToString();
                lblDepartment2.Text = GetLibrarianDr[5].ToString();
                pictureBoxPic.ImageLocation = GetLibrarianDr[6].ToString();

                

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FrmStudentEditAccount fsea = new FrmStudentEditAccount();
            fsea.TCno = lblTC2.Text;
            fsea.ShowDialog();
        }
    }
}

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
    public partial class FrmLibrarian : Form
    {
        public FrmLibrarian()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        
        private void FrmLibrarian_Load(object sender, EventArgs e)
        {


            lblTC2.Text = "99482657261";
            //Gets information to the panel
            SqlCommand GetLibrarian = new SqlCommand("Select LibrarianName,LibrarianSurname,LibrarianEmail,LibrarianGender,LibrarianPhone,LibrarianPicture From Tbl_Librarian where LibrarianTC=@p1", bgl.baglanti());
            GetLibrarian.Parameters.AddWithValue("@p1", lblTC2.Text);
            SqlDataReader GetLibrarianDr = GetLibrarian.ExecuteReader();
            while (GetLibrarianDr.Read())
            {
                lblLibrarian2.Text = GetLibrarianDr[0] + " " + GetLibrarianDr[1];
                lblMail2.Text = GetLibrarianDr[2].ToString();
                lblGender2.Text = GetLibrarianDr[3].ToString();
                lblPhone2.Text = GetLibrarianDr[4].ToString();
                pictureBoxPic.ImageLocation = GetLibrarianDr[5].ToString();

            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FrmLibrarianEdit frle = new FrmLibrarianEdit();
            frle.TCno = lblTC2.Text;
            frle.Show();
        }

       
    }
}

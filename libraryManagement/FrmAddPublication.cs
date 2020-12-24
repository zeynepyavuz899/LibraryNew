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

        private void FrmAddPublication_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select PublicationName From Tbl_Publication",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        

        private void btnClose_Click(object sender, EventArgs e)
        {
            gbEditDelete.Visible = false;
            gbAdd.Visible = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gbAdd.Visible = false;
            gbEditDelete.Visible = true;
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string depName = dataGridView1.Rows[secilen].Cells[0].Value.ToString();

            //Get student informations from database
            SqlCommand getDepartment = new SqlCommand("Select * From Tbl_Publication where PublicationName=@p1", bgl.baglanti());
            getDepartment.Parameters.AddWithValue("@p1", depName);
            SqlDataReader drgetDepartment = getDepartment.ExecuteReader();
            while (drgetDepartment.Read())
            {
                lblID2.Text = drgetDepartment[0].ToString();
                txtNameDesign.Text = drgetDepartment[1].ToString();
            }
        }

        private void ıconButton1_Click(object sender, EventArgs e)
        {
            //Update Publication Name
            SqlCommand updatePublication = new SqlCommand("update Tbl_Publication set PublicationName=@p1 where PublicationID=@p2",bgl.baglanti());
            updatePublication.Parameters.AddWithValue("@p1", txtNameDesign.Text);
            updatePublication.Parameters.AddWithValue("@p2", lblID2.Text);
            updatePublication.ExecuteNonQuery();
            gbAdd.Visible = true;
            gbEditDelete.Visible = false;
            MessageBox.Show("Successful");
        }

        private void ıconButton2_Click(object sender, EventArgs e)
        {
            //deleting
            SqlCommand deleteCat = new SqlCommand("delete From Tbl_Publication where PublicationID=@p1", bgl.baglanti());
            deleteCat.Parameters.AddWithValue("@p1", lblID2.Text);
            deleteCat.ExecuteNonQuery();
            gbEditDelete.Visible = false;
            gbAdd.Visible = true;
            MessageBox.Show("Publication Deleted Successfuly");
            bgl.baglanti().Close();
        }
    }
}

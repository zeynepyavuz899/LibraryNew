using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libraryManagement
{
    public partial class Frmlogin : Form
    {
        public Frmlogin()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {

        }

        private void AdmPic_Click(object sender, EventArgs e)
        {

            login_admin frm = new login_admin();
            frm.Show();
            this.Hide();
           
        }

        private void StdPic_Click(object sender, EventArgs e)
        {
            loginstudent frm1 = new loginstudent();
            frm1.Show();
            this.Hide();
        }
    }
}

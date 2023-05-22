using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_project
{
    public partial class frmRooms : Form
    {
        public frmRooms()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHome home = new frmHome();
            home.Show();
        }

        private void btnGallery_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGallery gallery = new frmGallery();
            gallery.Show();
        }

        private void btnEmp_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCustomer customer = new frmCustomer();
            customer.Show();
        }

        private void btnTeam_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEmp emp = new frmEmp();
            emp.Show();
        }

        private void btnLab_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLab lab = new frmLab();
            lab.Show();
        }

        private void btnMedicine_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMedicine medicine = new frmMedicine();
            medicine.Show();
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTeam team = new frmTeam();
            team.Show();
        }
    }
}

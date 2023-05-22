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
    public partial class frmTeam : Form
    {
        public frmTeam()
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

        private void btnCashiere_Click(object sender, EventArgs e)
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
            frmRooms rooms = new frmRooms();
            rooms.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogout logout = new frmLogout();
            logout.Show();
        }

        private void frmTeam_Load(object sender, EventArgs e)
        {

        }
    }
}

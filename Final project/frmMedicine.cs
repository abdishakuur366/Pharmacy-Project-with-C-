using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Final_project
{
    public partial class frmMedicine : Form
    {
        public frmMedicine()
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
            frmCustomer customer = new frmCustomer();
            customer.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogout logout = new frmLogout();
            logout.Show();
        }

        private void btnCashiere_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTeam team = new frmTeam();
            team.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            StreamWriter o;
            o = File.AppendText("Medicine File.txt");
            o.WriteLine("Medicine Name:"+txtMedicineName.Text);
            o.WriteLine("Medicine Quantity:" + txtMedicineQuantity.Text);
            o.WriteLine("Medicine PreDAte:" + txtMeddicinePredate.Text);
            o.WriteLine("Medicine ExpiryDate:" + txtMedicineExpdate.Text);
            o.Close();

            txtMedicineName.Clear();
            txtMedicineQuantity.Clear();
            txtMeddicinePredate.Clear();
            txtMedicineExpdate.Clear();
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRooms rooms = new frmRooms();
            rooms.Show();
        }
    }
}

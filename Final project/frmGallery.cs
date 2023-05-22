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
    public partial class frmGallery : Form
    {
        public frmGallery()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHome frmHome = new frmHome();
            frmHome.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCustomer customer = new frmCustomer();
            customer.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogout logout = new frmLogout();
            logout.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEmp emp = new frmEmp();
            emp.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLab lab = new frmLab();
            lab.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMedicine medicine = new frmMedicine();
            medicine.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRooms rooms = new frmRooms();
            rooms.Show();
        }
    }
}

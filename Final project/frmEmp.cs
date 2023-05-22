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
using System.Data.SqlClient;

namespace Final_project
{
    public partial class frmEmp : Form
    {
        SqlConnection conn = new SqlConnection("server=.; database=Employees; integrated security=true");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlDataReader dr;
        DataSet ds=new DataSet();
        public frmEmp()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHome frmHome = new frmHome();
            frmHome.Show();
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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogout logout = new frmLogout();
            logout.Show();
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRooms rooms = new frmRooms();
            rooms.Show();
        }

        private void btnMedicine_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMedicine medicine = new frmMedicine();
            medicine.Show();
        }

        private void btnLab_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLab lab = new frmLab();
            lab.Show();
        }

        private void btnCashiere_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTeam team = new frmTeam();
            team.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using(SqlConnection conn = ConnClass.Connect())
            {
                //SqlCommand cmd = new SqlCommand("insert into emp(empfName,empsName,emplName,empPhone,empGender,empSalary,empShift)values('" + txtEfname.Text+"'+'"+txtEsname.Text+"'+'"+txtElname.Text+"'+'"+txtEphone.Text+"'+'"+txtEgender.Text+"'+'"+txtEsalary.Text +"'+'"+txtEshift.Text +"') ",conn);
                //SqlCommand cmd = new SqlCommand("insert into emp(empfName,empsName,emplName,empPhone,empGender,empSalary,empShift)values(@fname,@sname,@lname,@phone,@gender,@salary,@shift) ", conn);
                //cmd.Parameters.AddWithValue("@fname",txtEfname.Text);
                //cmd.Parameters.AddWithValue("@sname", txtEsname.Text);
                //cmd.Parameters.AddWithValue("@lname", txtElname.Text);
                //cmd.Parameters.AddWithValue("@phone", txtEphone.Text);
                //cmd.Parameters.AddWithValue("@salary", txtEsalary.Text);
                //cmd.Parameters.AddWithValue("@shift", txtEshift.Text);

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType=CommandType.StoredProcedure;
                cmd.CommandText = "spAddNewEmp";
                cmd.Parameters.AddWithValue("@fname", txtEfname.Text);
                cmd.Parameters.AddWithValue("@sname", txtEsname.Text);
                cmd.Parameters.AddWithValue("@lname", txtElname.Text);
                cmd.Parameters.AddWithValue("@phone", txtEphone.Text);
                cmd.Parameters.AddWithValue("@gender", txtEgender.Text);
                cmd.Parameters.AddWithValue("@salary", txtEsalary.Text);
                cmd.Parameters.AddWithValue("@shift", txtEshift.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("New Employee has been registered");
                

            }








            //StreamWriter o;
            //o = File.AppendText("employees_File.txt");
            //o.WriteLine("Emp F.name:"+txtEfname.Text);
            //o.WriteLine("Emp S.name:" + txtEsname.Text);
            //o.WriteLine("Emp L.name:" + txtElname.Text);
            //o.WriteLine("Emp Phone:" + txtEphone.Text);
            //o.WriteLine("Emp Gender:" + txtEgender.Text);
            //o.WriteLine("Emp Salary:" + txtEsalary.Text);
            //o.WriteLine("Emp Shift:" + txtEshift.Text);
            //o.Close();

            

            txtEfname.Clear();
            txtEsname.Clear();
            txtElname.Clear();
            txtEgender.Clear();
            txtEsalary.Clear();
            txtEphone.Clear();
            txtEshift.Clear();

        }

        private void frmEmp_Load(object sender, EventArgs e)
        {

        }
    }
}

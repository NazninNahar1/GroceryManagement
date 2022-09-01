using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlClient;

namespace SuperShopManagement
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public static string EmployeeName = "";
        private void label2_Click(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(@"Data Source=SAIKAT-PC\SQLEXPRESS;Initial Catalog=SuperShopDB;Integrated Security=True");
        private void Loginbtn_Click(object sender, EventArgs e)
        {

            con.Open();
            string qurey = "select count(*) from EmployeeTable Where EmpName='" + userName.Text + "'and EmpPassword='" + Password.Text + "'";
            SqlDataAdapter sdat = new SqlDataAdapter(qurey, con);
            DataTable dtt = new DataTable();
            sdat.Fill(dtt);
            if (dtt.Rows[0][0].ToString() == "1")
            {
                EmployeeName = userName.Text;
                Bill b = new Bill();
                b.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username or password");
            }
            con.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Naznin");
            Employee em = new Employee();
            em.Show();
            this.Hide();
        }
       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

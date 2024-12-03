using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DataEmployee
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text;
            string password = txtPassword.Text;
            string c = "Data source = KRISHNA\\sqlexpress; Initial catalog = SagarDB; Integrated security = true";
            SqlConnection scon = new SqlConnection(c);
            scon.Open();
            SqlCommand cmd = new SqlCommand("select emp_id from tbl_login where user_name = '"+ userName + "' and password = '"+ password + "'", scon);
            SqlDataAdapter adp = new SqlDataAdapter(cmd.CommandText, scon);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            int id = (int)dt.Rows[0][0];
            //GetEmployeeDetails gt = new GetEmployeeDetails();
            //int id = (int)cmd.ExecuteScalar();
            if(id == 0)
            {
                MessageBox.Show("Check Your credentials");
                LoginForm lf = new LoginForm();
                lf.Close();
            }
            //MainForm mainForm1 = new MainForm();
            //mainForm1.getId(id);
            //GetEmployeeDetails getEmployeeDetails = new GetEmployeeDetails();
            //getEmployeeDetails.getId(id);
            //MessageBox.Show(id.ToString());
            if (Convert.ToBoolean(id))
            {
                MainForm mainForm = new MainForm(id);
                mainForm.Show();
            }
            LoginForm loginForm = new LoginForm();
            loginForm.Close();
        }
    }
}

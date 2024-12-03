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

namespace WindowsFormsWithDatabase
{
    public partial class AddEmployee : Form
    {
        
        public AddEmployee()
        {
            InitializeComponent();

            string c = "Data source = KRISHNA\\sqlexpress; Initial catalog = SagarDB; Integrated security = true";
            SqlConnection scon = new SqlConnection(c);
            scon.Open();
            SqlCommand cmd = new SqlCommand("select DEPT_ID,DEPT_NAME from tbl_dept", scon);
            SqlDataAdapter adp = new SqlDataAdapter(cmd.CommandText, scon);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            comboBox1.DataSource = dt;
            comboBox1.ValueMember = "DEPT_ID";
            comboBox1.DisplayMember = "DEPT_NAME";

            
            SqlCommand cmd1 = new SqlCommand("select desg_id, desg_name from tbl_desg;", scon);
            SqlDataAdapter adp1 = new SqlDataAdapter(cmd1.CommandText, scon);
            DataTable dt1 = new DataTable();
            adp1.Fill(dt1);
            comboBox2.DataSource = dt1;
            comboBox2.ValueMember = "DESG_ID";
            comboBox2.DisplayMember = "DESG_NAME";
            
            scon.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            String name = txtName.Text;
            int salary = Convert.ToInt32(txtSalary.Text);
            int dept_id = Convert.ToInt32(comboBox1.SelectedValue);
            int desg_id = Convert.ToInt32(comboBox2.SelectedValue);

            string c = "Data source = KRISHNA\\sqlexpress; Initial catalog = SagarDB; Integrated security = true";
            SqlConnection scon = new SqlConnection(c);
            scon.Open();
            SqlCommand cmd = new SqlCommand(" insert into tbl_empl(empl_id, empl_name, dept_id, desg_id, salary) values("+id+", '"+name+"', "+dept_id+", "+desg_id+", "+salary+")", scon);
            cmd.ExecuteNonQuery();
            scon.Close();
            

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}

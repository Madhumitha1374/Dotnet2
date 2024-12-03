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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DataEmployee
{
    public partial class GetEmployeeDetails : Form
    {
        //int empl_id;
        int emp_id;

        public GetEmployeeDetails()
        {
            InitializeComponent();
        }
        public GetEmployeeDetails(int id)
        {
            InitializeComponent();
            emp_id = id;
        }

        //public void getId(int id)
        //{
        //    empl_id = (int)id;
        //}
        private void GetEmployeeDetails_Load(object sender, EventArgs e)
        {
            
            int id;
            string name;
            int Dept_id;
            int Desg_id;
            int salary;

            string c = @"Data source = KRISHNA\sqlexpress; Initial catalog = SagarDB; Integrated security = true";
            SqlConnection scon = new SqlConnection(c);
            scon.Open();
            SqlCommand cmd = new SqlCommand("select * from tbl_empl where empl_id = " +emp_id, scon);
            SqlDataAdapter adp = new SqlDataAdapter(cmd.CommandText, scon);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            

            id = Convert.ToInt16(dt.Rows[0][0]);
            name = Convert.ToString(dt.Rows[0][1]);
            Desg_id = Convert.ToInt16(dt.Rows[0][2]);

            Dept_id = Convert.ToInt16(dt.Rows[0][3]);
            salary = Convert.ToInt32(dt.Rows[0][4]);

            SqlCommand cmd1 = new SqlCommand("select DEPT_NAME from tbl_dept where DEPT_ID = " + Dept_id + "", scon);
            SqlDataAdapter adp1 = new SqlDataAdapter(cmd.CommandText, scon);
            

            string dept_name = (string)cmd1.ExecuteScalar();

            SqlCommand cmd2 = new SqlCommand("select desg_name from tbl_desg where desg_id = " + Desg_id + "", scon);
            SqlDataAdapter adp2 = new SqlDataAdapter(cmd.CommandText, scon);
            

            string desg_name = (string)cmd2.ExecuteScalar();

            lblId.Text = id.ToString();
            lblName.Text = name.ToString();
            lblSalary.Text = salary.ToString();
            lblDept.Text = dept_name.ToString();
            lbldesg.Text = desg_name.ToString();



        }
    }
}

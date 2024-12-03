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
using System.Xml.Linq;

namespace DataEmployee
{
    public partial class AddDept : Form
    {
        public AddDept()
        {
            InitializeComponent();
        }

        private void AddDept_Load(object sender, EventArgs e)
        {

        }

        private void btnAddDept_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtDeptId.Text);
            String name = txtDeptName.Text;

            string c = "Data source = KRISHNA\\sqlexpress; Initial catalog = SagarDB; Integrated security = true";
            SqlConnection scon = new SqlConnection(c);
            scon.Open();
            SqlCommand cmd = new SqlCommand(" insert into tbl_dept(DEPT_ID, DEPT_NAME) values(" + id + ", '" + name + "')", scon);
            cmd.ExecuteNonQuery();
            scon.Close();
        }
    }
}

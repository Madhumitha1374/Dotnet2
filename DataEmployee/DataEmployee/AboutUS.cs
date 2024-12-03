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

namespace DataEmployee
{
    public partial class AboutUS : Form
    {
        public AboutUS()
        {
            InitializeComponent();
        }

        private void AboutUS_Load(object sender, EventArgs e)
        {
            string c = @"Data source = KRISHNA\sqlexpress; Initial catalog = SagarDB; Integrated security = true";
            SqlConnection scon = new SqlConnection(c);
            scon.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from tbl_empl", scon);
            int count = (int)cmd.ExecuteScalar();

            SqlCommand cmd1 = new SqlCommand("select * from tbl_empl", scon);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd1.CommandText, scon);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

            label2.Text = (count).ToString();
            label2.Visible = true;

            SqlCommand cmd2 = new SqlCommand("select count(*) from tbl_dept", scon);
            int count2 = (int)cmd2.ExecuteScalar();
            label6.Text = (count2).ToString();
        }
    }
}

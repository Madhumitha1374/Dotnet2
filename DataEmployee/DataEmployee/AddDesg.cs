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
    public partial class AddDesg : Form
    {
        public AddDesg()
        {
            InitializeComponent();
        }

        private void btnAddDesg_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtDesgId.Text);
            String name = txtDesgName.Text;

            string c = "Data source = KRISHNA\\sqlexpress; Initial catalog = SagarDB; Integrated security = true";
            SqlConnection scon = new SqlConnection(c);
            scon.Open();
            SqlCommand cmd = new SqlCommand(" insert into tbl_desg(desg_id, desg_name) values(" + id + ", '" + name + "')", scon);
            cmd.ExecuteNonQuery();
            scon.Close();
        }
    }
}

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
using System.Xml.Linq;
using WindowsFormsWithDatabase;

namespace DataEmployee
{
    public partial class MainForm : Form
    {
        int empl_id;
        public MainForm(int id)
        {
            empl_id = id;
            InitializeComponent();
        }

        //public void getId(int id)
        //{
        //    empl_id = id;   
        //}
        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddEmpl_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee();
            addEmployee.Show();
        }

        private void btnAddDept_Click(object sender, EventArgs e)
        {
            AddDept addDept = new AddDept();
            addDept.Show();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            GetEmployeeDetails getEmployeeDetails = new GetEmployeeDetails(empl_id);
            //getEmployeeDetails.getId(empl_id);
            getEmployeeDetails.Show();
        }

        private void BtnAddDesg_Click(object sender, EventArgs e)
        {
            AddDesg addDesg = new AddDesg();
            addDesg.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            AboutUS aboutUS = new AboutUS();
            aboutUS.Show();
        }
    }
}

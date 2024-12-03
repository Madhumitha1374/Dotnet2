using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;


namespace DataPurge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckDatabaseMemory();
        }

        private void CheckDatabaseMemory()
        {
            string serverName = "YourServerName"; // e.g., "(local)"
            string databaseName = "YourDatabaseName";

            ServerConnection connection = new ServerConnection(serverName);
            Server server = new Server(connection);

            Database db = server.Databases[databaseName];

            // Get database size in MB
            double dbSize = db.Size;
            double maxDbSize = 100; // Set your database size limit in MB

            if (dbSize >= maxDbSize)
            {
                ShowMemoryFullWarning();
            }
        }

        private void ShowMemoryFullWarning()
        {
            MessageBox.Show("Your database memory is full. Please consider purging old data.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

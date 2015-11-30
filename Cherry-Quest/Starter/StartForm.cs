using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Starter
{
    using System.Data.SqlClient;
    using CherryQuest.Data;

    public partial class StarterForm : Form
    {
        public StarterForm()
        {
            this.InitializeComponent();
            this.InitializeDatabaseConnection();
        }

        private void InitializeDatabaseConnection()
        {
            this.InitializeTextBox.AppendText("Initializing database connection..\n");

            using(var db = new CherryContext())
            {
                try
                {
                    if ( db.Database.Exists())
                    {
                        this.InitializeTextBox.AppendText("Connection established\n");
                    }
                    else
                    {
                        this.InitializeTextBox.AppendText("Database connection not available...");
                    }

                }
                catch(Exception ex)
                {
                    MessageBox.Show("Database connection not available...");
                }
            }
           
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
}

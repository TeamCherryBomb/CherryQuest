using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CherryQuestProject
{
    public partial class frmGameField : Form
    {
        public frmGameField()
        {
            InitializeComponent();
        }

        private void exiButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
}

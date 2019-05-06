using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemontV2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGoToService_Click(object sender, EventArgs e)
        {

        }

        private void btnGoToMasters_Click(object sender, EventArgs e)
        {
            MastersForm mf = new MastersForm();
            this.Hide();
            mf.ShowDialog();
            this.Show();
        }
    }
}

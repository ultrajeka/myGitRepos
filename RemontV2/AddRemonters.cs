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
    public partial class AddRemonters : Form
    {
        public AddRemonters()
        {
            InitializeComponent();
        }

        private void btnCloseAddNewMasterForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNewMasters_Click(object sender, EventArgs e)
        {
            RemontDBAdapter adapter = new RemontDBAdapter();

            adapter.InsertToMasters(tbAddFio.Text, tbAddPhone.Text, tbAddEmail.Text);

            this.Close();
        }
    }
}

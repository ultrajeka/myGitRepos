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
    public partial class UpdateMastersForm : Form
    {
        public UpdateMastersForm()
        {
            InitializeComponent();
        }

        private void btnCloseUpdateMasterForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdateNewMasters_Click(object sender, EventArgs e)
        {
            
            RemontDBAdapter adapter = new RemontDBAdapter();
            //adapter.UpdateMasters(mf.GetId(), tbUpdateFio.Text, tbUpdatePhone.Text, tbUpdateEmail.Text);
            
        }

        private void UpdateMastersForm_Load(object sender, EventArgs e)
        {
            MastersForm mf = new MastersForm();
            tbUpdateFio.Text = mf.GetId().ToString;
        }
    }
}

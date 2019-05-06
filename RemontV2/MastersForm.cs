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
    public partial class MastersForm : Form
    {
        RemontDBAdapter adapter;
        public MastersForm()
        {
            InitializeComponent();
            
            adapter = new RemontDBAdapter();
        }
        public void ShowDataOnForm()
        {
            dgMasters.DataSource = adapter.ReadTableMasters();
        }
        private void btnCloseMastersForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string GetId(string id)
        {
            id = dgMasters.CurrentRow.Cells["Phone"].Value.ToString();
            return id;
        }
        private void MastersForm_Load(object sender, EventArgs e)
        {
            ShowDataOnForm();
        }

        private void btnClearMastersDB_Click(object sender, EventArgs e)
        {
            adapter.ClearMastersDB();
            ShowDataOnForm();
        }

        private void btnAddMasters_Click(object sender, EventArgs e)
        {
            AddRemonters addrem = new AddRemonters();
            this.Hide();
            addrem.ShowDialog();
            ShowDataOnForm();
            this.Show();
        }

        private void btnUpdateMasters_Click(object sender, EventArgs e)
        {            
            this.Hide();
            UpdateMastersForm update = new UpdateMastersForm();
            update.ShowDialog();            
            this.Show();
        }
    }
}

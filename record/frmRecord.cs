using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace record
{
    public partial class frmRecord : Form
    {
        public frmRecord()
        {
            InitializeComponent();
        }


        private void intitalizeComboItems()
        {
            cboDepartment.Items.Add("SACE");
            cboDepartment.Items.Add("SABH");
            cboDepartment.Items.Add("SECAP");
            cboDepartment.Items.Add("SHAS");
        }


        private void initiliazeGridViewColumns()
        {
            grdRecords.Columns.Add("colFName", "First Name");
            grdRecords.Columns.Add("colLName", "Last Name");
            grdRecords.Columns.Add("colProgram", "Program");
            grdRecords.Columns.Add("colDept", "Department");
        }

        private void frmRecord_Load(object sender, EventArgs e)
        {
            intitalizeComboItems();
            initiliazeGridViewColumns();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            grdRecords.Rows.Add(txtFName.Text, txtLName.Text, txtProgram.Text, cboDepartment.Text);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtFName.Clear();
            txtLName.Clear();
            txtProgram.Clear();
            cboDepartment.SelectedIndex = -1;
        }
    }
}

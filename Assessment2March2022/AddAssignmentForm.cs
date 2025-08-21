using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentAS;

namespace Assessment2March2022
{
    public partial class AddAssignmentForm : Form
    {
        public AddAssignmentForm()
        {
            InitializeComponent();
        }

        private void chkCompleted_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AddAssignmentForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Create a new Assignment object
            NewAssignment = new Assignment
            {
                Name = txtName.Text,
                Subject = txtSubject.Text,
                DueDate = dtpDueDate.Value,
                Description = txtDescription.Text,
                PercentageComplete = (int)numPercent.Value,
                Completed = chkCompleted.Checked
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

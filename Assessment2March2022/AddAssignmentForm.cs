using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using StudentAS;

namespace Assessment2March2022
{
    public partial class AddAssignmentForm : Form
    {
        public Assignment NewAssignment { get; private set; }

        public AddAssignmentForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            NewAssignment = new Assignment
            {
                Name = txtName.Text,
                Subject = txtSubject.Text,
                Due = dtpDueDate.Value,
                Description = txtDescription.Text,
                PercentCompleted = (int)numPercent.Value,
                Completed = chkCompleted.Checked
            };

            this.DialogResult = DialogResult.OK;
            this.Close();


        }
    }
}

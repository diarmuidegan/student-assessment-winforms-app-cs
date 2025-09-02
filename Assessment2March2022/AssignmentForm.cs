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
    public partial class AssignmentForm : Form
    {
        /// <summary>
        /// Assignment created in the form
        /// </summary>
        public Assignment Assignment { get; private set; }

        public AssignmentForm()
        {
            InitializeComponent();
        }
        #region Methods
        #endregion
        private void SaveAssignmentAndClose()
        {
            CreateNewAssigmentFromFields();

            DialogResult = DialogResult.OK;
            Close();
        }

        private void CreateNewAssigmentFromFields()
        {
            Assignment = new Assignment
            {
                Name = txtName.Text,
                Subject = txtSubject.Text,
                Due = dtpDueDate.Value,
                Description = txtDescription.Text,
                PercentCompleted = (int)numPercent.Value,
                Completed = chkCompleted.Checked
            };
        }
        #region Event Handlers
        #endregion
        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveAssignmentAndClose();
        }
    }
}

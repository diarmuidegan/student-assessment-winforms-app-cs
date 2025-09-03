using System;
using System.Windows.Forms;
using StudentAS;

namespace Assessment2March2022
{
    public partial class AssignmentForm : Form
    {
        /// <summary>
        /// Assignment created in the form
        /// </summary>
        public Assignment Assignment { get; set; }
        /// <summary>
        /// Initializes the AssignmentForm.
        /// Depends on a Control on the Form called AssignmentForm.
        /// </summary>
        public AssignmentForm()
        {
            InitializeComponent();
        }
        #region Methods
        #endregion
        /// <summary>
        /// Creates a new Assignment from form fields.
        /// Depends on Property <see cref="Assignment"/>.
        /// Depends on Class <cee cref="StudentAS.Assignment"/>.
        /// Depends on Controls on the Form called txtName, txtSubject, dtpDueDate, txtDescription, numPercent, chkCompleted.
        /// </summary>
        private void CreateNewAssigmentFromFields()
        {
            Assignment = new Assignment
            {
                Name = nameTextBox.Text,
                Subject = txtSubject.Text,
                Due = dtpDueDate.Value,
                Description = txtDescription.Text,
                PercentCompleted = (int)numPercent.Value,
                Completed = chkCompleted.Checked
            };
        }
        /// <summary>
        /// Saves the assignment and closes the form.
        /// Depends on methods <see cref="CreateNewAssigmentFromFields"/>.
        /// Depends on a Control on the Form called AssignmentForm.
        /// </summary>
        private void SaveAssignmentAndClose()
        {
            CreateNewAssigmentFromFields();

            DialogResult = DialogResult.OK;
            Close();
        }
        #region Event Handlers
        #endregion
        /// <summary>
        /// Handles the Save button click event.
        /// Depends on methods <see cref="SaveAssignmentAndClose"/>.
        /// </summary>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveAssignmentAndClose();
        }
    }
}

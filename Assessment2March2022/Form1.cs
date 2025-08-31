using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assessment2March2022;

namespace StudentAS
{
    /// <summary>
    /// Form for managing assignments
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// This is the master list for all assignments
        /// </summary>
        private readonly BindingList<Assignment> assignments = new BindingList<Assignment>();

        /// <summary>
        /// Constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            btnShow.Click += showButton_Click;
        }
        #region Private Methods
        #endregion
        private void BindAssignmentsDataGridView()
        {
            assignmentsDataGridView.Columns.Clear();
            assignmentsDataGridView.DataSource = assignments;

            var copyButtonColumn = new DataGridViewButtonColumn()
            {
                Name = "Copy",
                UseColumnTextForButtonValue = true,
                HeaderText = "",
                Text = "Copy"
            };
            _ = assignmentsDataGridView.Columns.Add(copyButtonColumn);
            var deleteButtonColumn = new DataGridViewButtonColumn()
            {
                Name = "Delete",
                UseColumnTextForButtonValue = true,
                HeaderText = "",
                Text = "Delete"
            };
            _ = assignmentsDataGridView.Columns.Add(deleteButtonColumn);
        }

        private static Color ChooseColor(object dataBoundItem)
        {
            if (dataBoundItem is Assignment assignment && assignment.PercentCompleted > 0)
                return Color.LightGreen;

            return Color.White;
        }
        private Assignment GetSelectedAssignmentFromDataGridView(DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = e.RowIndex;
            BindingList<Assignment> list = (BindingList<Assignment>)assignmentsDataGridView.DataSource;
            var item = list[selectedRowIndex];
            return item;
        }
        // This method will filter the assignments based on the Completed property
        void FilterCompleted(BindingList<Assignment> assignmentBindingList, bool showCompleted = true)
        {
            assignmentsDataGridView.DataSource = new BindingList<Assignment>(
                assignmentBindingList.Where(a => a.Completed == showCompleted).ToList()
            );
        }
        // This method will set the DataSource of the DataGridView based on the checkbox state
        private void SetAssignmentsDataGridViewDataSource()
        {
            if (showOnlyCompletedAssignmentsCheckBox.Checked)
                FilterCompleted(assignments);
            else
                assignmentsDataGridView.DataSource = assignments;
        }
        private void InitializeAssignments()
        {
            assignments.Add(new Assignment("lab 1", "Applications Development", DateTime.Now.AddDays(-30), "mostly done in class - go to class", 100, true));
            assignments.Add(new Assignment("Group Project", "Applications Development", DateTime.Now.AddDays(30), "book club", 40, false));
            assignments.Add(new Assignment("lab 1", "Software Development", DateTime.Now.AddDays(8), "mostly done in class - go to class", 60, false));
            assignments.Add(new Assignment("Assignment 1", "Database Module", DateTime.Now.AddDays(10), "create a database etc", 10, false));
        }
        #region Event Handlers
        #endregion
        private void AddAssignmentButton_Click(object sender, EventArgs e)
        {
            using (var addForm = new AddAssignmentForm())
            {
                if (addForm.ShowDialog() != DialogResult.OK)
                    return;
                assignments.Add(addForm.NewAssignment);
                CompletedCheckBox_CheckedChanged(null, null);
            }
        }
        private void AssignmentsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (assignmentsDataGridView.Columns[e.ColumnIndex].Name == "Delete")
            {
                Assignment item = GetSelectedAssignmentFromDataGridView(e);
                assignments.Remove(item);
                SetAssignmentsDataGridViewDataSource();
            }
            if (assignmentsDataGridView.Columns[e.ColumnIndex].Name == "Copy")
            {
                Assignment item = GetSelectedAssignmentFromDataGridView(e);
                assignments.Add((Assignment)item.Clone());
                SetAssignmentsDataGridViewDataSource();
            }
        }
        /// <summary>
        /// This event will color the rows based on PercentCompleted
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AssignmentsDataGridView_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            var row = assignmentsDataGridView.Rows[e.RowIndex];
            row.DefaultCellStyle.BackColor = ChooseColor(row.DataBoundItem);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeAssignments();
            BindAssignmentsDataGridView();
            assignmentsDataGridView.RowPrePaint += AssignmentsDataGridView_RowPrePaint;
        }


        // This event will trigger when the checkbox is checked or unchecked
        private void CompletedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SetAssignmentsDataGridViewDataSource();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            int days;
            if (!int.TryParse(txtNextDays.Text, out days) || days < 0)
            {
                MessageBox.Show("Please enter a valid number of days.", "Invalid Input");
                return;
            }

            DateTime now = DateTime.Now;
            DateTime targetDate = now.AddDays(days);

            var filtered = assignments.Where(a => a.Due >= now && a.Due <= targetDate).ToList();
            assignmentsDataGridView.DataSource = new BindingList<Assignment>(filtered);
        }


    }
}

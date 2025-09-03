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
        private readonly BindingList<Assignment> _assignmentsBindingList = new BindingList<Assignment>();

        /// <summary>
        /// Constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }
        #region Private Methods
        /// <summary>
        /// Binds assignments to the DataGridView.
        /// Depends on field <see cref="_assignmentsBindingList"/>.
        /// Depends on a Control on the Form called assignmentsDataGridView.
        /// </summary>
        private void BindAssignmentsDataGridView()
        {
            assignmentsDataGridView.Columns.Clear();
            assignmentsDataGridView.DataSource = _assignmentsBindingList;

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

        /// <summary>
        /// Chooses row color based on assignment completion.
        /// </summary>
        private static Color ChooseColor(object dataBoundItem)
        {
            if (dataBoundItem is Assignment assignment && assignment.PercentCompleted > 0)
                return Color.LightGreen;

            return Color.White;
        }

        /// <summary>
        /// Gets the selected Assignment from the DataGridView.
        /// Depends on field <see cref="_assignmentsBindingList"/>.
        /// Depends on a Control on the Form called assignmentsDataGridView.
        /// </summary>
        private Assignment GetSelectedAssignmentFromDataGridView(DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = e.RowIndex;
            BindingList<Assignment> list = (BindingList<Assignment>)assignmentsDataGridView.DataSource;
            var item = list[selectedRowIndex];
            return item;
        }

        /// <summary>
        /// Filters assignments by Completed property.
        /// Depends on a Control on the Form called assignmentsDataGridView.
        /// </summary>
        void FilterCompleted(BindingList<Assignment> assignmentBindingList, bool showCompleted = true)
        {
            assignmentsDataGridView.DataSource = new BindingList<Assignment>(
                assignmentBindingList.Where(a => a.Completed == showCompleted).ToList()
            );
        }

        /// <summary>
        /// Sets DataGridView source based on checkbox.
        /// Depends on methods <see cref="FilterCompleted"/>.
        /// Depends on field <see cref="_assignmentsBindingList"/>.
        /// Depends on a Control on the Form called assignmentsDataGridView.
        /// </summary>
        private void SetAssignmentsDataGridViewDataSource()
        {
            if (showOnlyCompletedAssignmentsCheckBox.Checked)
                FilterCompleted(_assignmentsBindingList);
            else
                assignmentsDataGridView.DataSource = _assignmentsBindingList;
        }

        /// <summary>
        /// Initializes the assignments list.
        /// Depends on field <see cref="_assignmentsBindingList"/>.
        /// </summary>
        private void InitializeAssignments()
        {
            _assignmentsBindingList.Add(new Assignment("lab 1", "Applications Development", DateTime.Now.AddDays(-30), "mostly done in class - go to class", 100, true));
            _assignmentsBindingList.Add(new Assignment("Group Project", "Applications Development", DateTime.Now.AddDays(30), "book club", 40, false));
            _assignmentsBindingList.Add(new Assignment("lab 1", "Software Development", DateTime.Now.AddDays(8), "mostly done in class - go to class", 60, false));
            _assignmentsBindingList.Add(new Assignment("Assignment 1", "Database Module", DateTime.Now.AddDays(10), "create a database etc", 10, false));
        }
        #endregion
        #region Event Handlers
        /// <summary>
        /// Event handler for cell content click in the DataGridView.
        /// Depends on methods <see cref="GetSelectedAssignmentFromDataGridView"/> and <see cref="SetAssignmentsDataGridViewDataSource"/>.
        /// </summary>
        private void AssignmentsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (assignmentsDataGridView.Columns[e.ColumnIndex].Name == "Delete")
            {
                Assignment item = GetSelectedAssignmentFromDataGridView(e);
                _assignmentsBindingList.Remove(item);
                SetAssignmentsDataGridViewDataSource();
            }
            if (assignmentsDataGridView.Columns[e.ColumnIndex].Name == "Copy")
            {
                Assignment item = GetSelectedAssignmentFromDataGridView(e);
                _assignmentsBindingList.Add((Assignment)item.Clone());
                SetAssignmentsDataGridViewDataSource();
            }
        }

        /// <summary>
        /// Adds a new assignment using AssignmentForm.
        /// Depends on field <see cref="_assignmentsBindingList"/>.
        /// Depends on method <see cref="CompletedCheckBox_CheckedChanged"/>.
        /// </summary>
        private void AddAssignmentButton_Click(object sender, EventArgs e)
        {
            using (var addForm = new AssignmentForm())
            {
                if (addForm.ShowDialog() != DialogResult.OK)
                    return;
                _assignmentsBindingList.Add(addForm.Assignment);
                CompletedCheckBox_CheckedChanged(null, null);
            }
        }

        /// <summary>
        /// Resets the completed assignments filter.
        /// Depends on a Control on the Form called showOnlyCompletedAssignmentsCheckBox.
        /// </summary>
        private void ResetFilters()
        {
            showOnlyCompletedAssignmentsCheckBox.Checked = false;
        }

        /// <summary>
        /// Colors rows based on PercentCompleted.
        /// Depends on method <see cref="ChooseColor"/>.
        /// Depends on a Control on the Form called assignmentsDataGridView.
        /// </summary>
        private void AssignmentsDataGridView_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            var row = assignmentsDataGridView.Rows[e.RowIndex];
            row.DefaultCellStyle.BackColor = ChooseColor(row.DataBoundItem);
        }

        /// <summary>
        /// Loads assignments and binds DataGridView.
        /// Depends on methods <see cref="InitializeAssignments"/> and <see cref="BindAssignmentsDataGridView"/>.
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeAssignments();
            BindAssignmentsDataGridView();
        }

        /// <summary>
        /// Updates DataGridView when completed checkbox changes.
        /// Depends on method <see cref="SetAssignmentsDataGridViewDataSource"/>.
        /// </summary>
        private void CompletedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SetAssignmentsDataGridViewDataSource();
        }

        /// <summary>
        /// Filters assignments by due date.
        /// Depends on field <see cref="_assignmentsBindingList"/>.
        /// Depends on a Control on the Form called assignmentsDataGridView.
        /// </summary>
        private void ShowButton_Click(object sender, EventArgs e)
        {
            int days = (int)daysNumericUpDown.Value;

            DateTime now = DateTime.Now;
            DateTime targetDate = now.AddDays(days);

            var filtered = _assignmentsBindingList.Where(a => a.Due >= now && a.Due <= targetDate).ToList();
            assignmentsDataGridView.DataSource = new BindingList<Assignment>(filtered);
        }

        /// <summary>
        /// Resets filters when button clicked.
        /// Depends on method <see cref="ResetFilters"/>.
        /// </summary>
        private void ResetFiltersButton_Click(object sender, EventArgs e)
        {
            ResetFilters();
        }

        /// <summary>
        /// Sorts assignments by due date.
        /// Depends on a Control on the Form called assignmentsDataGridView.
        /// </summary>
        private void sortButton_Click(object sender, EventArgs e)
        {
            // Get the currently displayed assignments
            var displayedAssignments = (BindingList<Assignment>)assignmentsDataGridView.DataSource;
            // Set the DataSource to a new sorted BindingList
            assignmentsDataGridView.DataSource = new BindingList<Assignment>(
                displayedAssignments.OrderBy( // Sort by 
                    (assignment) => assignment.Due // The Sort delegate, sorting by Due
                    )
                .ToList() // Convert to List
                );
        }

        /// <summary>
        /// Sorts assignments by name, ascending or descending.
        /// Depends on a Control on the Form called assignmentsDataGridView.
        /// </summary>
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            var displayedAssignments = (BindingList<Assignment>)assignmentsDataGridView.DataSource;
            List<Assignment> sortedList;

            if (OrderByDescending.Checked)
            {
                sortedList = displayedAssignments.OrderByDescending(x => x.Name).ToList();
            }
            else
            {
                sortedList = displayedAssignments.OrderBy(x => x.Name).ToList();
            }

            assignmentsDataGridView.DataSource = new BindingList<Assignment>(sortedList);
        }

        /// <summary>
        /// Sorts assignments by name.
        /// Depends on a Control on the Form called assignmentsDataGridView.
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            // Get the currently displayed assignments
            var displayedAssignments = (BindingList<Assignment>)assignmentsDataGridView.DataSource;
            // Set the DataSource to a new sorted BindingList
            assignmentsDataGridView.DataSource = new BindingList<Assignment>(
                displayedAssignments.OrderBy( // Sort by 
                    (assignment) => assignment.Name // The Sort delegate, sorting by Due
                    )
                .ToList() // Convert to List
                );
        }
        #endregion
    }
}

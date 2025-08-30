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

    public partial class Form1 : Form
    {
        // This is the master list for all assignments
        private readonly BindingList<Assignment> assignments = new BindingList<Assignment>();
        private int deleteButtonColumnIndex;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeAssignments();
            BindAssignmentsDataGridView();
        }

        private void InitializeAssignments()
        {
            assignments.Add(new Assignment("lab 1", "Applications Development", DateTime.Now.AddDays(-30), "mostly done in class - go to class", 100, true));
            assignments.Add(new Assignment("Group Project", "Applications Development", DateTime.Now.AddDays(30), "book club", 40, false));
            assignments.Add(new Assignment("lab 1", "Software Development", DateTime.Now.AddDays(8), "mostly done in class - go to class", 60, false));
            assignments.Add(new Assignment("Assignment 1", "Database Module", DateTime.Now.AddDays(10), "create a database etc", 10, false));
        }
        private void BindAssignmentsDataGridView()
        {
            assignmentsDataGridView.Columns.Clear();
            assignmentsDataGridView.DataSource = assignments;

            var deleteButtonColumn = new DataGridViewButtonColumn()
            {
                Name = "Delete",
                UseColumnTextForButtonValue = true,
                HeaderText = "",
                Text = "Delete"
            };
            deleteButtonColumnIndex = assignmentsDataGridView.Columns.Add(deleteButtonColumn);

        }
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

        private Assignment GetSelectedAssignmentFromDataGridView(DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = e.RowIndex;
            BindingList<Assignment> list = (BindingList<Assignment>)assignmentsDataGridView.DataSource;
            var item = list[selectedRowIndex];
            return item;
        }

        void FilterCompleted(BindingList<Assignment> assignmentBindingList, bool showCompleted = true)
        {
            assignmentsDataGridView.DataSource = new BindingList<Assignment>(
                assignmentBindingList.Where(a => a.Completed == showCompleted).ToList()
            );
        }

        private void CompletedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SetAssignmentsDataGridViewDataSource();
        }

        private void SetAssignmentsDataGridViewDataSource()
        {
            if (showOnlyCompletedAssignmentsCheckBox.Checked)
                FilterCompleted(assignments);
            else
                assignmentsDataGridView.DataSource = assignments;
        }
    }
}

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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Assignment> assList = new List<Assignment>();
            LoadData(assList);
            dgvAssignments.DataSource = assList;
           

        }

        private void LoadData(List<Assignment> assList)
        {
            Assignment a = new Assignment("lab 1", "Applications Development", DateTime.Now.AddDays(-30), "mostly done in class - go to class", 100, true);
            Assignment a1 = new Assignment("Group Project", "Applications Development", DateTime.Now.AddDays(30), "book club", 40, false);
            Assignment a2 = new Assignment("lab 1", "Software Development", DateTime.Now.AddDays(8), "mostly done in class - go to class", 60, false);
            Assignment a3 = new Assignment("Assignment 1", "Database Module", DateTime.Now.AddDays(10), "create a database etc", 10, false);
            assList.Add(a);
            assList.Add(a1);
            assList.Add(a2);
            assList.Add(a3);
        }

        private void DGVAssignments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var addForm = new AddAssignmentForm())
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    // Get new assignment
                    Assignment newAssign = addForm.NewAssignment;

                    // Add to list
                    assignments.Add(newAssign);

                    // Refresh DataGridView
                    dgvAssignments.DataSource = null;
                    dgvAssignments.DataSource = assignments;
                }
            }
        }




        private void chkCompleted_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

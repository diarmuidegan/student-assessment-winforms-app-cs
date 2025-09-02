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
    /// Form for managing reciepts
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// This is the master list for all reciepts
        /// </summary>
        private readonly BindingList<Reciept> _reciepts = new BindingList<Reciept>();

        /// <summary>
        /// Constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }
        #region Private Methods
        #endregion
        private void BindRecieptsDataGridView()
        {
            recieptsDataGridView.Columns.Clear();
            recieptsDataGridView.DataSource = _reciepts;

            var copyButtonColumn = new DataGridViewButtonColumn()
            {
                Name = "Copy",
                UseColumnTextForButtonValue = true,
                HeaderText = "",
                Text = "Copy"
            };
            _ = recieptsDataGridView.Columns.Add(copyButtonColumn);
            var deleteButtonColumn = new DataGridViewButtonColumn()
            {
                Name = "Delete",
                UseColumnTextForButtonValue = true,
                HeaderText = "",
                Text = "Delete"
            };
            _ = recieptsDataGridView.Columns.Add(deleteButtonColumn);
        }

        private static Color ChooseColor(object dataBoundItem)
        {
            if (dataBoundItem is Reciept reciept && reciept.PercentCompleted > 0)
                return Color.LightGreen;

            return Color.White;
        }
        private Reciept GetSelectedRecieptFromDataGridView(DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = e.RowIndex;
            BindingList<Reciept> list = (BindingList<Reciept>)recieptsDataGridView.DataSource;
            var item = list[selectedRowIndex];
            return item;
        }
        // This method will filter the reciepts based on the Completed property
        void FilterCompleted(BindingList<Reciept> recieptBindingList, bool showCompleted = true)
        {
            recieptsDataGridView.DataSource = new BindingList<Reciept>(
                recieptBindingList.Where(a => a.Completed == showCompleted).ToList()
            );
        }
        // This method will set the DataSource of the DataGridView based on the checkbox state
        private void SetRecieptsDataGridViewDataSource()
        {
            if (showOnlyCompletedRecieptsCheckBox.Checked)
                FilterCompleted(_reciepts);
            else
                recieptsDataGridView.DataSource = _reciepts;
        }
        private void InitializeReciepts()
        {
            _reciepts.Add(new Reciept("lab 1", "Applications Development", DateTime.Now.AddDays(-30), "mostly done in class - go to class", 100, true));
            _reciepts.Add(new Reciept("Group Project", "Applications Development", DateTime.Now.AddDays(30), "book club", 40, false));
            _reciepts.Add(new Reciept("lab 1", "Software Development", DateTime.Now.AddDays(8), "mostly done in class - go to class", 60, false));
            _reciepts.Add(new Reciept("Reciept 1", "Database Module", DateTime.Now.AddDays(10), "create a database etc", 10, false));
        }
        #region Event Handlers
        #endregion
        // This event will open the RecieptForm to add a new reciept
        private void AddRecieptButton_Click(object sender, EventArgs e)
        {
            using (var addForm = new RecieptForm())
            {
                if (addForm.ShowDialog() != DialogResult.OK)
                    return;
                _reciepts.Add(addForm.Reciept);
                CompletedCheckBox_CheckedChanged(null, null);
            }
        }
        private void RecieptsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (recieptsDataGridView.Columns[e.ColumnIndex].Name == "Delete")
            {
                Reciept item = GetSelectedRecieptFromDataGridView(e);
                _reciepts.Remove(item);
                SetRecieptsDataGridViewDataSource();
            }
            if (recieptsDataGridView.Columns[e.ColumnIndex].Name == "Copy")
            {
                Reciept item = GetSelectedRecieptFromDataGridView(e);
                _reciepts.Add((Reciept)item.Clone());
                SetRecieptsDataGridViewDataSource();
            }
        }
        private void ResetFilters()
        {
            showOnlyCompletedRecieptsCheckBox.Checked = false;

        }
        /// <summary>
        /// This event will color the rows based on PercentCompleted
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RecieptsDataGridView_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            var row = recieptsDataGridView.Rows[e.RowIndex];
            row.DefaultCellStyle.BackColor = ChooseColor(row.DataBoundItem);
        }

        // This event will initialize the reciepts and bind the DataGridView when the form loads
        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeReciepts();
            BindRecieptsDataGridView();
        }

        // This event will trigger when the checkbox is checked or unchecked
        private void CompletedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SetRecieptsDataGridViewDataSource();
        }

        // This event will filter the reciepts when the Show button is clicked
        private void ShowButton_Click(object sender, EventArgs e)
        {
            int days = (int)daysNumericUpDown.Value;

            DateTime now = DateTime.Now;
            DateTime targetDate = now.AddDays(days);

            var filtered = _reciepts.Where(a => a.Due >= now && a.Due <= targetDate).ToList();
            recieptsDataGridView.DataSource = new BindingList<Reciept>(filtered);
        }

        // This event will reset the filters when the Reset Filters button is clicked
        private void ResetFiltersButton_Click(object sender, EventArgs e)
        {
            ResetFilters();
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            // Get the currently displayed reciepts
            var displayedReciepts = (BindingList<Reciept>)recieptsDataGridView.DataSource;
            // Set the DataSource to a new sorted BindingList
            recieptsDataGridView.DataSource = new BindingList<Reciept>(
                displayedReciepts.OrderBy( // Sort by 
                    (reciept) => reciept.Due // The Sort delegate, sorting by Due
                    )
                .ToList() // Convert to List
                );
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            var displayedReciepts = (BindingList<Reciept>)recieptsDataGridView.DataSource;

            // Replace 'OrderByDescending' with the correct control name, e.g. 'orderByDescendingCheckBox'
            // Make sure you have a CheckBox control named 'orderByDescendingCheckBox' in your designer

            List<Reciept> sortedList;

            if (OrderByDescending.Checked)
            {
                sortedList = displayedReciepts.OrderByDescending(x => x.Name).ToList();
            }
            else
            {
                sortedList = displayedReciepts.OrderBy(x => x.Name).ToList();
            }

            recieptsDataGridView.DataSource = new BindingList<Reciept>(sortedList);
        }


        // Sort by Name button click event handler
        private void button1_Click(object sender, EventArgs e)
        {
            // Get the currently displayed reciepts
            var displayedReciepts = (BindingList<Reciept>)recieptsDataGridView.DataSource;
            // Set the DataSource to a new sorted BindingList
            recieptsDataGridView.DataSource = new BindingList<Reciept>(
                displayedReciepts.OrderBy( // Sort by 
                    (reciept) => reciept.Name // The Sort delegate, sorting by Due
                    )
                .ToList() // Convert to List
                );
        }
    }
}

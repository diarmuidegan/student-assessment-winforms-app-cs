namespace StudentAS
{
    partial class ApplicationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.assignmentsDataGridView = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.showOnlyCompletedAssignmentsCheckBox = new System.Windows.Forms.CheckBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.daysNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.resetFiltersButton = new System.Windows.Forms.Button();
            this.dueFilterGroupBox = new System.Windows.Forms.GroupBox();
            this.sortButton = new System.Windows.Forms.Button();
            this.OrderByDescending = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.assignmentsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysNumericUpDown)).BeginInit();
            this.dueFilterGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // assignmentsDataGridView
            // 
            this.assignmentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.assignmentsDataGridView.Location = new System.Drawing.Point(34, 105);
            this.assignmentsDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.assignmentsDataGridView.Name = "assignmentsDataGridView";
            this.assignmentsDataGridView.RowHeadersWidth = 51;
            this.assignmentsDataGridView.Size = new System.Drawing.Size(1309, 364);
            this.assignmentsDataGridView.TabIndex = 0;
            this.assignmentsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AssignmentsDataGridView_CellContentClick);
            this.assignmentsDataGridView.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.AssignmentsDataGridView_RowPrePaint);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(29, 24);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(116, 43);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add Assignment";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.AddAssignmentButton_Click);
            // 
            // showOnlyCompletedAssignmentsCheckBox
            // 
            this.showOnlyCompletedAssignmentsCheckBox.AutoSize = true;
            this.showOnlyCompletedAssignmentsCheckBox.Location = new System.Drawing.Point(153, 36);
            this.showOnlyCompletedAssignmentsCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.showOnlyCompletedAssignmentsCheckBox.Name = "showOnlyCompletedAssignmentsCheckBox";
            this.showOnlyCompletedAssignmentsCheckBox.Size = new System.Drawing.Size(161, 20);
            this.showOnlyCompletedAssignmentsCheckBox.TabIndex = 3;
            this.showOnlyCompletedAssignmentsCheckBox.Text = "Show Only Completed";
            this.showOnlyCompletedAssignmentsCheckBox.UseVisualStyleBackColor = true;
            this.showOnlyCompletedAssignmentsCheckBox.CheckedChanged += new System.EventHandler(this.CompletedCheckBox_CheckedChanged);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(670, 29);
            this.btnShow.Margin = new System.Windows.Forms.Padding(4);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(116, 38);
            this.btnShow.TabIndex = 5;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Show Assignment due in the next";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "days";
            // 
            // daysNumericUpDown
            // 
            this.daysNumericUpDown.Location = new System.Drawing.Point(236, 26);
            this.daysNumericUpDown.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.daysNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.daysNumericUpDown.Name = "daysNumericUpDown";
            this.daysNumericUpDown.Size = new System.Drawing.Size(42, 22);
            this.daysNumericUpDown.TabIndex = 8;
            this.daysNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // resetFiltersButton
            // 
            this.resetFiltersButton.Location = new System.Drawing.Point(808, 29);
            this.resetFiltersButton.Name = "resetFiltersButton";
            this.resetFiltersButton.Size = new System.Drawing.Size(114, 38);
            this.resetFiltersButton.TabIndex = 9;
            this.resetFiltersButton.Text = "Reset Filters";
            this.resetFiltersButton.UseVisualStyleBackColor = true;
            this.resetFiltersButton.Click += new System.EventHandler(this.ResetFiltersButton_Click);
            // 
            // dueFilterGroupBox
            // 
            this.dueFilterGroupBox.Controls.Add(this.label2);
            this.dueFilterGroupBox.Controls.Add(this.label1);
            this.dueFilterGroupBox.Controls.Add(this.daysNumericUpDown);
            this.dueFilterGroupBox.Location = new System.Drawing.Point(321, 12);
            this.dueFilterGroupBox.Name = "dueFilterGroupBox";
            this.dueFilterGroupBox.Size = new System.Drawing.Size(329, 61);
            this.dueFilterGroupBox.TabIndex = 10;
            this.dueFilterGroupBox.TabStop = false;
            this.dueFilterGroupBox.Text = "Asssignment Due Filter";
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(1088, 38);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(143, 23);
            this.sortButton.TabIndex = 11;
            this.sortButton.Text = "Sort By Due Date";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // OrderByDescending
            // 
            this.OrderByDescending.AutoSize = true;
            this.OrderByDescending.Location = new System.Drawing.Point(943, 36);
            this.OrderByDescending.Margin = new System.Windows.Forms.Padding(4);
            this.OrderByDescending.Name = "OrderByDescending";
            this.OrderByDescending.Size = new System.Drawing.Size(152, 20);
            this.OrderByDescending.TabIndex = 12;
            this.OrderByDescending.Text = "OrderByDescending";
            this.OrderByDescending.UseVisualStyleBackColor = true;
            this.OrderByDescending.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1088, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Sort By Name";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 527);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OrderByDescending);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.dueFilterGroupBox);
            this.Controls.Add(this.resetFiltersButton);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.showOnlyCompletedAssignmentsCheckBox);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.assignmentsDataGridView);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Assignment System";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.assignmentsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysNumericUpDown)).EndInit();
            this.dueFilterGroupBox.ResumeLayout(false);
            this.dueFilterGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView assignmentsDataGridView;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.CheckBox showOnlyCompletedAssignmentsCheckBox;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown daysNumericUpDown;
        private System.Windows.Forms.Button resetFiltersButton;
        private System.Windows.Forms.GroupBox dueFilterGroupBox;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.CheckBox OrderByDescending;
        private System.Windows.Forms.Button button1;
    }
}


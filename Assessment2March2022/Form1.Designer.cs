namespace StudentAS
{
    partial class Form1
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
            this.txtNextDays = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.assignmentsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // assignmentsDataGridView
            // 
            this.assignmentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.assignmentsDataGridView.Location = new System.Drawing.Point(45, 32);
            this.assignmentsDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.assignmentsDataGridView.Name = "assignmentsDataGridView";
            this.assignmentsDataGridView.RowHeadersWidth = 51;
            this.assignmentsDataGridView.Size = new System.Drawing.Size(848, 364);
            this.assignmentsDataGridView.TabIndex = 0;
            this.assignmentsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVAssignments_CellContentClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(901, 32);
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
            this.showOnlyCompletedAssignmentsCheckBox.Location = new System.Drawing.Point(907, 144);
            this.showOnlyCompletedAssignmentsCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.showOnlyCompletedAssignmentsCheckBox.Name = "showOnlyCompletedAssignmentsCheckBox";
            this.showOnlyCompletedAssignmentsCheckBox.Size = new System.Drawing.Size(161, 20);
            this.showOnlyCompletedAssignmentsCheckBox.TabIndex = 3;
            this.showOnlyCompletedAssignmentsCheckBox.Text = "Show Only Completed";
            this.showOnlyCompletedAssignmentsCheckBox.UseVisualStyleBackColor = true;
            this.showOnlyCompletedAssignmentsCheckBox.CheckedChanged += new System.EventHandler(this.chkCompleted_CheckedChanged);
            // 
            // txtNextDays
            // 
            this.txtNextDays.Location = new System.Drawing.Point(1123, 180);
            this.txtNextDays.Margin = new System.Windows.Forms.Padding(4);
            this.txtNextDays.Name = "txtNextDays";
            this.txtNextDays.Size = new System.Drawing.Size(49, 22);
            this.txtNextDays.TabIndex = 4;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(1228, 172);
            this.btnShow.Margin = new System.Windows.Forms.Padding(4);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(116, 38);
            this.btnShow.TabIndex = 5;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(903, 183);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Show Assignment due in the next";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1181, 183);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "days";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 433);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.txtNextDays);
            this.Controls.Add(this.showOnlyCompletedAssignmentsCheckBox);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.assignmentsDataGridView);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Assignment System";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.assignmentsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView assignmentsDataGridView;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.CheckBox showOnlyCompletedAssignmentsCheckBox;
        private System.Windows.Forms.TextBox txtNextDays;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


namespace Assessment2March2022
{
    partial class AddAssignmentForm
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.AssignmentName = new System.Windows.Forms.Label();
            this.Subject = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.numPercent = new System.Windows.Forms.NumericUpDown();
            this.chkCompleted = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numPercent)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(333, 73);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 0;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(333, 148);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(100, 22);
            this.txtSubject.TabIndex = 1;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(333, 223);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(100, 22);
            this.txtDescription.TabIndex = 2;
            // 
            // AssignmentName
            // 
            this.AssignmentName.AutoSize = true;
            this.AssignmentName.Location = new System.Drawing.Point(147, 82);
            this.AssignmentName.Name = "AssignmentName";
            this.AssignmentName.Size = new System.Drawing.Size(120, 16);
            this.AssignmentName.TabIndex = 3;
            this.AssignmentName.Text = "Assignment Name ";
            // 
            // Subject
            // 
            this.Subject.AutoSize = true;
            this.Subject.Location = new System.Drawing.Point(147, 154);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(52, 16);
            this.Subject.TabIndex = 4;
            this.Subject.Text = "Subject";
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(147, 223);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(75, 16);
            this.Description.TabIndex = 5;
            this.Description.Text = "Description";
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Location = new System.Drawing.Point(298, 285);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(200, 22);
            this.dtpDueDate.TabIndex = 6;
            // 
            // numPercent
            // 
            this.numPercent.Location = new System.Drawing.Point(333, 334);
            this.numPercent.Name = "numPercent";
            this.numPercent.Size = new System.Drawing.Size(120, 22);
            this.numPercent.TabIndex = 7;
            // 
            // chkCompleted
            // 
            this.chkCompleted.AutoSize = true;
            this.chkCompleted.Location = new System.Drawing.Point(338, 387);
            this.chkCompleted.Name = "chkCompleted";
            this.chkCompleted.Size = new System.Drawing.Size(95, 20);
            this.chkCompleted.TabIndex = 8;
            this.chkCompleted.Text = "Completed";
            this.chkCompleted.UseVisualStyleBackColor = true;

            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(595, 415);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // 
            // AddAssignmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chkCompleted);
            this.Controls.Add(this.numPercent);
            this.Controls.Add(this.dtpDueDate);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.Subject);
            this.Controls.Add(this.AssignmentName);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.txtName);
            this.Name = "AddAssignmentForm";
            this.Text = "AddAssignmentForm";
            ((System.ComponentModel.ISupportInitialize)(this.numPercent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label AssignmentName;
        private System.Windows.Forms.Label Subject;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.NumericUpDown numPercent;
        private System.Windows.Forms.CheckBox chkCompleted;
        private System.Windows.Forms.Button btnSave;
    }
}
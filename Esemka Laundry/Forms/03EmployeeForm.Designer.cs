namespace Esemka_Laundry.Forms
{
    partial class EmployeeForm
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            tbEmployeeSearch = new TextBox();
            vWEmployeeAndJobBindingSource = new BindingSource(components);
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            tbEmployeeID = new TextBox();
            tbEmployeeName = new TextBox();
            tbEmployeeEmail = new TextBox();
            tbEmployeePhoneNumber = new TextBox();
            rtbEmployeeAddress = new RichTextBox();
            dtpEmployeeDateOfBirth = new DateTimePicker();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            btnEmployeeInsert = new Button();
            btnEmployeeUpdate = new Button();
            btnEmployeeDelete = new Button();
            btnEmployeeSave = new Button();
            btnEmployeeCancel = new Button();
            tbEmployeePassword = new TextBox();
            tbEmployeeConfirmPw = new TextBox();
            cbEmployeeJobTittle = new ComboBox();
            numEmployeeSalary = new NumericUpDown();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            employeeNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateOfBirthDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            jobTitleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            salaryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)vWEmployeeAndJobBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numEmployeeSalary).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(296, 9);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 0;
            label1.Text = "Manage Employee";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(471, 29);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 1;
            label2.Text = "Search  :";
            // 
            // tbEmployeeSearch
            // 
            tbEmployeeSearch.Location = new Point(528, 26);
            tbEmployeeSearch.Name = "tbEmployeeSearch";
            tbEmployeeSearch.Size = new Size(178, 27);
            tbEmployeeSearch.TabIndex = 2;
            // 
            // vWEmployeeAndJobBindingSource
            // 
            vWEmployeeAndJobBindingSource.DataSource = typeof(Models.VWEmployeeAndJob);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 236);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 4;
            label3.Text = "Employee ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 269);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 5;
            label4.Text = "Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 301);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 6;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(46, 335);
            label6.Name = "label6";
            label6.Size = new Size(108, 20);
            label6.TabIndex = 7;
            label6.Text = "Phone Number";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(46, 368);
            label7.Name = "label7";
            label7.Size = new Size(62, 20);
            label7.TabIndex = 8;
            label7.Text = "Address";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(46, 416);
            label8.Name = "label8";
            label8.Size = new Size(96, 20);
            label8.TabIndex = 9;
            label8.Text = "Date Of Birth";
            // 
            // tbEmployeeID
            // 
            tbEmployeeID.Enabled = false;
            tbEmployeeID.Location = new Point(177, 233);
            tbEmployeeID.Margin = new Padding(3, 4, 3, 4);
            tbEmployeeID.Name = "tbEmployeeID";
            tbEmployeeID.Size = new Size(163, 27);
            tbEmployeeID.TabIndex = 10;
            // 
            // tbEmployeeName
            // 
            tbEmployeeName.Location = new Point(177, 267);
            tbEmployeeName.Name = "tbEmployeeName";
            tbEmployeeName.Size = new Size(163, 27);
            tbEmployeeName.TabIndex = 11;
            // 
            // tbEmployeeEmail
            // 
            tbEmployeeEmail.Location = new Point(177, 299);
            tbEmployeeEmail.Name = "tbEmployeeEmail";
            tbEmployeeEmail.Size = new Size(163, 27);
            tbEmployeeEmail.TabIndex = 12;
            // 
            // tbEmployeePhoneNumber
            // 
            tbEmployeePhoneNumber.Location = new Point(177, 332);
            tbEmployeePhoneNumber.Name = "tbEmployeePhoneNumber";
            tbEmployeePhoneNumber.Size = new Size(163, 27);
            tbEmployeePhoneNumber.TabIndex = 13;
            // 
            // rtbEmployeeAddress
            // 
            rtbEmployeeAddress.Location = new Point(177, 365);
            rtbEmployeeAddress.Name = "rtbEmployeeAddress";
            rtbEmployeeAddress.Size = new Size(163, 40);
            rtbEmployeeAddress.TabIndex = 15;
            rtbEmployeeAddress.Text = "";
            // 
            // dtpEmployeeDateOfBirth
            // 
            dtpEmployeeDateOfBirth.Location = new Point(177, 411);
            dtpEmployeeDateOfBirth.Name = "dtpEmployeeDateOfBirth";
            dtpEmployeeDateOfBirth.Size = new Size(163, 27);
            dtpEmployeeDateOfBirth.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(408, 240);
            label9.Name = "label9";
            label9.Size = new Size(70, 20);
            label9.TabIndex = 17;
            label9.Text = "Job Tittle";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(408, 269);
            label10.Name = "label10";
            label10.Size = new Size(49, 20);
            label10.TabIndex = 18;
            label10.Text = "Salary";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(408, 301);
            label11.Name = "label11";
            label11.Size = new Size(70, 20);
            label11.TabIndex = 19;
            label11.Text = "Password";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(408, 331);
            label12.Name = "label12";
            label12.Size = new Size(127, 20);
            label12.TabIndex = 20;
            label12.Text = "Confirm Password";
            // 
            // btnEmployeeInsert
            // 
            btnEmployeeInsert.Location = new Point(408, 359);
            btnEmployeeInsert.Name = "btnEmployeeInsert";
            btnEmployeeInsert.Size = new Size(94, 29);
            btnEmployeeInsert.TabIndex = 21;
            btnEmployeeInsert.Text = "Insert";
            btnEmployeeInsert.UseVisualStyleBackColor = true;
            btnEmployeeInsert.Click += btnEmployeeInsert_Click;
            // 
            // btnEmployeeUpdate
            // 
            btnEmployeeUpdate.Location = new Point(508, 359);
            btnEmployeeUpdate.Name = "btnEmployeeUpdate";
            btnEmployeeUpdate.Size = new Size(94, 29);
            btnEmployeeUpdate.TabIndex = 22;
            btnEmployeeUpdate.Text = "Update";
            btnEmployeeUpdate.UseVisualStyleBackColor = true;
            btnEmployeeUpdate.Click += btnEmployeeUpdate_Click;
            // 
            // btnEmployeeDelete
            // 
            btnEmployeeDelete.Location = new Point(608, 359);
            btnEmployeeDelete.Name = "btnEmployeeDelete";
            btnEmployeeDelete.Size = new Size(94, 29);
            btnEmployeeDelete.TabIndex = 23;
            btnEmployeeDelete.Text = "Delete";
            btnEmployeeDelete.UseVisualStyleBackColor = true;
            btnEmployeeDelete.Click += btnEmployeeDelete_Click;
            // 
            // btnEmployeeSave
            // 
            btnEmployeeSave.ForeColor = Color.Green;
            btnEmployeeSave.Location = new Point(471, 394);
            btnEmployeeSave.Name = "btnEmployeeSave";
            btnEmployeeSave.Size = new Size(94, 29);
            btnEmployeeSave.TabIndex = 24;
            btnEmployeeSave.Text = "Save";
            btnEmployeeSave.UseVisualStyleBackColor = true;
            btnEmployeeSave.Click += btnEmployeeSave_Click;
            // 
            // btnEmployeeCancel
            // 
            btnEmployeeCancel.ForeColor = Color.Green;
            btnEmployeeCancel.Location = new Point(571, 394);
            btnEmployeeCancel.Name = "btnEmployeeCancel";
            btnEmployeeCancel.Size = new Size(94, 29);
            btnEmployeeCancel.TabIndex = 25;
            btnEmployeeCancel.Text = "Cancel";
            btnEmployeeCancel.UseVisualStyleBackColor = true;
            btnEmployeeCancel.Click += btnEmployeeCancel_Click;
            // 
            // tbEmployeePassword
            // 
            tbEmployeePassword.Location = new Point(543, 298);
            tbEmployeePassword.Name = "tbEmployeePassword";
            tbEmployeePassword.Size = new Size(163, 27);
            tbEmployeePassword.TabIndex = 28;
            // 
            // tbEmployeeConfirmPw
            // 
            tbEmployeeConfirmPw.Location = new Point(543, 328);
            tbEmployeeConfirmPw.Name = "tbEmployeeConfirmPw";
            tbEmployeeConfirmPw.Size = new Size(163, 27);
            tbEmployeeConfirmPw.TabIndex = 29;
            // 
            // cbEmployeeJobTittle
            // 
            cbEmployeeJobTittle.FormattingEnabled = true;
            cbEmployeeJobTittle.Location = new Point(543, 233);
            cbEmployeeJobTittle.Name = "cbEmployeeJobTittle";
            cbEmployeeJobTittle.Size = new Size(163, 28);
            cbEmployeeJobTittle.TabIndex = 30;
            // 
            // numEmployeeSalary
            // 
            numEmployeeSalary.Location = new Point(543, 267);
            numEmployeeSalary.Margin = new Padding(3, 4, 3, 4);
            numEmployeeSalary.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numEmployeeSalary.Name = "numEmployeeSalary";
            numEmployeeSalary.Size = new Size(163, 27);
            numEmployeeSalary.TabIndex = 31;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, employeeNameDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, phoneNumberDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn, dateOfBirthDataGridViewTextBoxColumn, jobTitleDataGridViewTextBoxColumn, salaryDataGridViewTextBoxColumn });
            dataGridView1.DataSource = vWEmployeeAndJobBindingSource;
            dataGridView1.Location = new Point(14, 56);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(692, 169);
            dataGridView1.TabIndex = 32;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // employeeNameDataGridViewTextBoxColumn
            // 
            employeeNameDataGridViewTextBoxColumn.DataPropertyName = "EmployeeName";
            employeeNameDataGridViewTextBoxColumn.HeaderText = "EmployeeName";
            employeeNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            employeeNameDataGridViewTextBoxColumn.Name = "employeeNameDataGridViewTextBoxColumn";
            employeeNameDataGridViewTextBoxColumn.ReadOnly = true;
            employeeNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.ReadOnly = true;
            emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            phoneNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            addressDataGridViewTextBoxColumn.HeaderText = "Address";
            addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            addressDataGridViewTextBoxColumn.ReadOnly = true;
            addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            dateOfBirthDataGridViewTextBoxColumn.HeaderText = "DateOfBirth";
            dateOfBirthDataGridViewTextBoxColumn.MinimumWidth = 6;
            dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            dateOfBirthDataGridViewTextBoxColumn.ReadOnly = true;
            dateOfBirthDataGridViewTextBoxColumn.Width = 125;
            // 
            // jobTitleDataGridViewTextBoxColumn
            // 
            jobTitleDataGridViewTextBoxColumn.DataPropertyName = "JobTitle";
            jobTitleDataGridViewTextBoxColumn.HeaderText = "JobTitle";
            jobTitleDataGridViewTextBoxColumn.MinimumWidth = 6;
            jobTitleDataGridViewTextBoxColumn.Name = "jobTitleDataGridViewTextBoxColumn";
            jobTitleDataGridViewTextBoxColumn.ReadOnly = true;
            jobTitleDataGridViewTextBoxColumn.Width = 125;
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            salaryDataGridViewTextBoxColumn.DataPropertyName = "salary";
            salaryDataGridViewTextBoxColumn.HeaderText = "salary";
            salaryDataGridViewTextBoxColumn.MinimumWidth = 6;
            salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            salaryDataGridViewTextBoxColumn.ReadOnly = true;
            salaryDataGridViewTextBoxColumn.Width = 125;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(721, 463);
            Controls.Add(dataGridView1);
            Controls.Add(numEmployeeSalary);
            Controls.Add(cbEmployeeJobTittle);
            Controls.Add(tbEmployeeConfirmPw);
            Controls.Add(tbEmployeePassword);
            Controls.Add(btnEmployeeCancel);
            Controls.Add(btnEmployeeSave);
            Controls.Add(btnEmployeeDelete);
            Controls.Add(btnEmployeeUpdate);
            Controls.Add(btnEmployeeInsert);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(dtpEmployeeDateOfBirth);
            Controls.Add(rtbEmployeeAddress);
            Controls.Add(tbEmployeePhoneNumber);
            Controls.Add(tbEmployeeEmail);
            Controls.Add(tbEmployeeName);
            Controls.Add(tbEmployeeID);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(tbEmployeeSearch);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmployeeForm";
            Text = "EmployeeForm";
            ((System.ComponentModel.ISupportInitialize)vWEmployeeAndJobBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)numEmployeeSalary).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbEmployeeSearch;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox tbEmployeeID;
        private TextBox tbEmployeeName;
        private TextBox tbEmployeeEmail;
        private TextBox tbEmployeePhoneNumber;
        private RichTextBox rtbEmployeeAddress;
        private DateTimePicker dtpEmployeeDateOfBirth;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Button btnEmployeeInsert;
        private Button btnEmployeeUpdate;
        private Button btnEmployeeDelete;
        private Button btnEmployeeSave;
        private Button btnEmployeeCancel;
        private TextBox tbEmployeePassword;
        private TextBox tbEmployeeConfirmPw;
        private ComboBox cbEmployeeJobTittle;
        private NumericUpDown numEmployeeSalary;
        private DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn jobTittleDataGridViewTextBoxColumn;
        private BindingSource vWEmployeeAndJobBindingSource;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn employeeNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn jobTitleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
    }
}
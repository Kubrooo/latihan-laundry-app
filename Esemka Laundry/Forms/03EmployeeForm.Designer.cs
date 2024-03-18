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
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
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
            label1.Location = new Point(252, 7);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 0;
            label1.Text = "Manage Employee";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(412, 22);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Search  :";
            // 
            // tbEmployeeSearch
            // 
            tbEmployeeSearch.Location = new Point(473, 20);
            tbEmployeeSearch.Margin = new Padding(3, 2, 3, 2);
            tbEmployeeSearch.Name = "tbEmployeeSearch";
            tbEmployeeSearch.Size = new Size(156, 23);
            tbEmployeeSearch.TabIndex = 2;
            // 
            // vWEmployeeAndJobBindingSource
            // 
            vWEmployeeAndJobBindingSource.DataSource = typeof(Models.VWEmployeeAndJob);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 177);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 4;
            label3.Text = "Employee ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 202);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 5;
            label4.Text = "Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 226);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 6;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(40, 251);
            label6.Name = "label6";
            label6.Size = new Size(88, 15);
            label6.TabIndex = 7;
            label6.Text = "Phone Number";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(40, 276);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 8;
            label7.Text = "Address";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(40, 312);
            label8.Name = "label8";
            label8.Size = new Size(75, 15);
            label8.TabIndex = 9;
            label8.Text = "Date Of Birth";
            // 
            // tbEmployeeID
            // 
            tbEmployeeID.Location = new Point(155, 175);
            tbEmployeeID.Margin = new Padding(3, 2, 3, 2);
            tbEmployeeID.Name = "tbEmployeeID";
            tbEmployeeID.Size = new Size(143, 23);
            tbEmployeeID.TabIndex = 10;
            // 
            // tbEmployeeName
            // 
            tbEmployeeName.Location = new Point(155, 200);
            tbEmployeeName.Margin = new Padding(3, 2, 3, 2);
            tbEmployeeName.Name = "tbEmployeeName";
            tbEmployeeName.Size = new Size(143, 23);
            tbEmployeeName.TabIndex = 11;
            // 
            // tbEmployeeEmail
            // 
            tbEmployeeEmail.Location = new Point(155, 224);
            tbEmployeeEmail.Margin = new Padding(3, 2, 3, 2);
            tbEmployeeEmail.Name = "tbEmployeeEmail";
            tbEmployeeEmail.Size = new Size(143, 23);
            tbEmployeeEmail.TabIndex = 12;
            // 
            // tbEmployeePhoneNumber
            // 
            tbEmployeePhoneNumber.Location = new Point(155, 249);
            tbEmployeePhoneNumber.Margin = new Padding(3, 2, 3, 2);
            tbEmployeePhoneNumber.Name = "tbEmployeePhoneNumber";
            tbEmployeePhoneNumber.Size = new Size(143, 23);
            tbEmployeePhoneNumber.TabIndex = 13;
            // 
            // rtbEmployeeAddress
            // 
            rtbEmployeeAddress.Location = new Point(155, 274);
            rtbEmployeeAddress.Margin = new Padding(3, 2, 3, 2);
            rtbEmployeeAddress.Name = "rtbEmployeeAddress";
            rtbEmployeeAddress.Size = new Size(143, 31);
            rtbEmployeeAddress.TabIndex = 15;
            rtbEmployeeAddress.Text = "";
            // 
            // dtpEmployeeDateOfBirth
            // 
            dtpEmployeeDateOfBirth.Location = new Point(155, 308);
            dtpEmployeeDateOfBirth.Margin = new Padding(3, 2, 3, 2);
            dtpEmployeeDateOfBirth.Name = "dtpEmployeeDateOfBirth";
            dtpEmployeeDateOfBirth.Size = new Size(143, 23);
            dtpEmployeeDateOfBirth.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(368, 178);
            label9.Name = "label9";
            label9.Size = new Size(54, 15);
            label9.TabIndex = 17;
            label9.Text = "Job Tittle";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(368, 202);
            label10.Name = "label10";
            label10.Size = new Size(38, 15);
            label10.TabIndex = 18;
            label10.Text = "Salary";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(368, 226);
            label11.Name = "label11";
            label11.Size = new Size(57, 15);
            label11.TabIndex = 19;
            label11.Text = "Password";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(368, 251);
            label12.Name = "label12";
            label12.Size = new Size(104, 15);
            label12.TabIndex = 20;
            label12.Text = "Confirm Password";
            // 
            // btnEmployeeInsert
            // 
            btnEmployeeInsert.Location = new Point(368, 274);
            btnEmployeeInsert.Margin = new Padding(3, 2, 3, 2);
            btnEmployeeInsert.Name = "btnEmployeeInsert";
            btnEmployeeInsert.Size = new Size(82, 22);
            btnEmployeeInsert.TabIndex = 21;
            btnEmployeeInsert.Text = "Insert";
            btnEmployeeInsert.UseVisualStyleBackColor = true;
            // 
            // btnEmployeeUpdate
            // 
            btnEmployeeUpdate.Location = new Point(455, 274);
            btnEmployeeUpdate.Margin = new Padding(3, 2, 3, 2);
            btnEmployeeUpdate.Name = "btnEmployeeUpdate";
            btnEmployeeUpdate.Size = new Size(82, 22);
            btnEmployeeUpdate.TabIndex = 22;
            btnEmployeeUpdate.Text = "Update";
            btnEmployeeUpdate.UseVisualStyleBackColor = true;
            // 
            // btnEmployeeDelete
            // 
            btnEmployeeDelete.Location = new Point(542, 274);
            btnEmployeeDelete.Margin = new Padding(3, 2, 3, 2);
            btnEmployeeDelete.Name = "btnEmployeeDelete";
            btnEmployeeDelete.Size = new Size(82, 22);
            btnEmployeeDelete.TabIndex = 23;
            btnEmployeeDelete.Text = "Delete";
            btnEmployeeDelete.UseVisualStyleBackColor = true;
            // 
            // btnEmployeeSave
            // 
            btnEmployeeSave.Enabled = false;
            btnEmployeeSave.ForeColor = Color.Green;
            btnEmployeeSave.Location = new Point(412, 300);
            btnEmployeeSave.Margin = new Padding(3, 2, 3, 2);
            btnEmployeeSave.Name = "btnEmployeeSave";
            btnEmployeeSave.Size = new Size(82, 22);
            btnEmployeeSave.TabIndex = 24;
            btnEmployeeSave.Text = "Save";
            btnEmployeeSave.UseVisualStyleBackColor = true;
            // 
            // btnEmployeeCancel
            // 
            btnEmployeeCancel.Enabled = false;
            btnEmployeeCancel.ForeColor = Color.Green;
            btnEmployeeCancel.Location = new Point(500, 300);
            btnEmployeeCancel.Margin = new Padding(3, 2, 3, 2);
            btnEmployeeCancel.Name = "btnEmployeeCancel";
            btnEmployeeCancel.Size = new Size(82, 22);
            btnEmployeeCancel.TabIndex = 25;
            btnEmployeeCancel.Text = "Cancel";
            btnEmployeeCancel.UseVisualStyleBackColor = true;
            // 
            // tbEmployeePassword
            // 
            tbEmployeePassword.Location = new Point(482, 224);
            tbEmployeePassword.Margin = new Padding(3, 2, 3, 2);
            tbEmployeePassword.Name = "tbEmployeePassword";
            tbEmployeePassword.Size = new Size(143, 23);
            tbEmployeePassword.TabIndex = 28;
            // 
            // tbEmployeeConfirmPw
            // 
            tbEmployeeConfirmPw.Location = new Point(482, 249);
            tbEmployeeConfirmPw.Margin = new Padding(3, 2, 3, 2);
            tbEmployeeConfirmPw.Name = "tbEmployeeConfirmPw";
            tbEmployeeConfirmPw.Size = new Size(143, 23);
            tbEmployeeConfirmPw.TabIndex = 29;
            // 
            // cbEmployeeJobTittle
            // 
            cbEmployeeJobTittle.FormattingEnabled = true;
            cbEmployeeJobTittle.Location = new Point(482, 176);
            cbEmployeeJobTittle.Margin = new Padding(3, 2, 3, 2);
            cbEmployeeJobTittle.Name = "cbEmployeeJobTittle";
            cbEmployeeJobTittle.Size = new Size(143, 23);
            cbEmployeeJobTittle.TabIndex = 30;
            // 
            // numEmployeeSalary
            // 
            numEmployeeSalary.Location = new Point(482, 203);
            numEmployeeSalary.Margin = new Padding(3, 2, 3, 2);
            numEmployeeSalary.Name = "numEmployeeSalary";
            numEmployeeSalary.Size = new Size(143, 23);
            numEmployeeSalary.TabIndex = 31;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, emailDataGridViewTextBoxColumn, phoneNumberDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn, dateOfBirthDataGridViewTextBoxColumn, jobTitleDataGridViewTextBoxColumn, salaryDataGridViewTextBoxColumn });
            dataGridView1.DataSource = vWEmployeeAndJobBindingSource;
            dataGridView1.Location = new Point(12, 42);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(617, 128);
            dataGridView1.TabIndex = 32;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "EmployeeId";
            dataGridViewTextBoxColumn1.HeaderText = "EmployeeId";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            dataGridViewTextBoxColumn2.HeaderText = "Name";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            addressDataGridViewTextBoxColumn.HeaderText = "Address";
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            dateOfBirthDataGridViewTextBoxColumn.HeaderText = "DateOfBirth";
            dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            dateOfBirthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jobTitleDataGridViewTextBoxColumn
            // 
            jobTitleDataGridViewTextBoxColumn.DataPropertyName = "JobTitle";
            jobTitleDataGridViewTextBoxColumn.HeaderText = "JobTitle";
            jobTitleDataGridViewTextBoxColumn.Name = "jobTitleDataGridViewTextBoxColumn";
            jobTitleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            salaryDataGridViewTextBoxColumn.DataPropertyName = "salary";
            salaryDataGridViewTextBoxColumn.HeaderText = "salary";
            salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            salaryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 347);
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
            Margin = new Padding(3, 2, 3, 2);
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
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn jobTitleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}
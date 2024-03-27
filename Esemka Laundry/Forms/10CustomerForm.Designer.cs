namespace Esemka_Laundry.Forms
{
    partial class CustomerForm
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
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            customerBindingSource = new BindingSource(components);
            comboBox1 = new ComboBox();
            tbCustomerSearch = new TextBox();
            lblSearch = new Label();
            label2 = new Label();
            tbCustomerName = new TextBox();
            tbCustomerPhoneNum = new TextBox();
            rtbCustomerAddress = new RichTextBox();
            label3 = new Label();
            label4 = new Label();
            btnCustomerInsert = new Button();
            btnCustomerUpdate = new Button();
            btnCustomerDelete = new Button();
            btnCustomerSave = new Button();
            btnCustomerCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(318, 9);
            label1.Name = "label1";
            label1.Size = new Size(130, 20);
            label1.TabIndex = 0;
            label1.Text = "Manage Customer";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, phoneNumberDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn });
            dataGridView1.DataSource = customerBindingSource;
            dataGridView1.Location = new Point(12, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(776, 188);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            addressDataGridViewTextBoxColumn.HeaderText = "Address";
            addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerBindingSource
            // 
            customerBindingSource.DataSource = typeof(Models.Customer);
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Name", "PhoneNumber", "Address" });
            comboBox1.Location = new Point(517, 43);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(111, 28);
            comboBox1.TabIndex = 2;
            comboBox1.Leave += comboBox1_Leave;
            // 
            // tbCustomerSearch
            // 
            tbCustomerSearch.Location = new Point(634, 44);
            tbCustomerSearch.Name = "tbCustomerSearch";
            tbCustomerSearch.Size = new Size(154, 27);
            tbCustomerSearch.TabIndex = 3;
            tbCustomerSearch.Leave += tbCustomerSearch_Leave;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(461, 47);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(53, 20);
            lblSearch.TabIndex = 4;
            lblSearch.Text = "Search";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 281);
            label2.Name = "label2";
            label2.Size = new Size(123, 20);
            label2.TabIndex = 5;
            label2.Text = "Customer Name :";
            // 
            // tbCustomerName
            // 
            tbCustomerName.Location = new Point(146, 278);
            tbCustomerName.Name = "tbCustomerName";
            tbCustomerName.Size = new Size(171, 27);
            tbCustomerName.TabIndex = 6;
            // 
            // tbCustomerPhoneNum
            // 
            tbCustomerPhoneNum.Location = new Point(146, 311);
            tbCustomerPhoneNum.Name = "tbCustomerPhoneNum";
            tbCustomerPhoneNum.Size = new Size(171, 27);
            tbCustomerPhoneNum.TabIndex = 7;
            // 
            // rtbCustomerAddress
            // 
            rtbCustomerAddress.Location = new Point(146, 344);
            rtbCustomerAddress.Name = "rtbCustomerAddress";
            rtbCustomerAddress.Size = new Size(171, 94);
            rtbCustomerAddress.TabIndex = 8;
            rtbCustomerAddress.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 314);
            label3.Name = "label3";
            label3.Size = new Size(115, 20);
            label3.TabIndex = 9;
            label3.Text = "Phone Number :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 347);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 10;
            label4.Text = "Address :";
            // 
            // btnCustomerInsert
            // 
            btnCustomerInsert.Location = new Point(420, 310);
            btnCustomerInsert.Name = "btnCustomerInsert";
            btnCustomerInsert.Size = new Size(94, 29);
            btnCustomerInsert.TabIndex = 11;
            btnCustomerInsert.Text = "Insert";
            btnCustomerInsert.UseVisualStyleBackColor = true;
            btnCustomerInsert.Click += btnCustomerInsert_Click;
            // 
            // btnCustomerUpdate
            // 
            btnCustomerUpdate.Location = new Point(520, 310);
            btnCustomerUpdate.Name = "btnCustomerUpdate";
            btnCustomerUpdate.Size = new Size(94, 29);
            btnCustomerUpdate.TabIndex = 12;
            btnCustomerUpdate.Text = "Update";
            btnCustomerUpdate.UseVisualStyleBackColor = true;
            btnCustomerUpdate.Click += btnCustomerUpdate_Click;
            // 
            // btnCustomerDelete
            // 
            btnCustomerDelete.Location = new Point(620, 310);
            btnCustomerDelete.Name = "btnCustomerDelete";
            btnCustomerDelete.Size = new Size(94, 29);
            btnCustomerDelete.TabIndex = 13;
            btnCustomerDelete.Text = "Delete";
            btnCustomerDelete.UseVisualStyleBackColor = true;
            btnCustomerDelete.Click += btnCustomerDelete_Click;
            // 
            // btnCustomerSave
            // 
            btnCustomerSave.ForeColor = Color.Green;
            btnCustomerSave.Location = new Point(472, 343);
            btnCustomerSave.Name = "btnCustomerSave";
            btnCustomerSave.Size = new Size(94, 29);
            btnCustomerSave.TabIndex = 14;
            btnCustomerSave.Text = "Save";
            btnCustomerSave.UseVisualStyleBackColor = true;
            btnCustomerSave.Click += btnCustomerSave_Click;
            // 
            // btnCustomerCancel
            // 
            btnCustomerCancel.ForeColor = Color.Green;
            btnCustomerCancel.Location = new Point(572, 343);
            btnCustomerCancel.Name = "btnCustomerCancel";
            btnCustomerCancel.Size = new Size(94, 29);
            btnCustomerCancel.TabIndex = 15;
            btnCustomerCancel.Text = "Cancel";
            btnCustomerCancel.UseVisualStyleBackColor = true;
            btnCustomerCancel.Click += btnCustomerCancel_Click;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCustomerCancel);
            Controls.Add(btnCustomerSave);
            Controls.Add(btnCustomerDelete);
            Controls.Add(btnCustomerUpdate);
            Controls.Add(btnCustomerInsert);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(rtbCustomerAddress);
            Controls.Add(tbCustomerPhoneNum);
            Controls.Add(tbCustomerName);
            Controls.Add(label2);
            Controls.Add(lblSearch);
            Controls.Add(tbCustomerSearch);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomerForm";
            Text = "CustomerForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private TextBox tbCustomerSearch;
        private Label lblSearch;
        private Label label2;
        private TextBox tbCustomerName;
        private TextBox tbCustomerPhoneNum;
        private RichTextBox rtbCustomerAddress;
        private Label label3;
        private Label label4;
        private Button btnCustomerInsert;
        private Button btnCustomerUpdate;
        private Button btnCustomerDelete;
        private Button btnCustomerSave;
        private Button btnCustomerCancel;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private BindingSource customerBindingSource;
    }
}
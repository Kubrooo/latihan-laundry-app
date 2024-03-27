namespace Esemka_Laundry.Forms
{
    partial class ViewTransactionForm
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
            tbSearch = new TextBox();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            customerIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            customerNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            employeNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            transactionTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            completeEstimationTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vWHeaderDepositCustomerBindingSource = new BindingSource(components);
            label3 = new Label();
            detailDepositBindingSource = new BindingSource(components);
            label4 = new Label();
            vWDetailDepositsAndServiceBindingSource = new BindingSource(components);
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vWHeaderDepositCustomerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)detailDepositBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vWDetailDepositsAndServiceBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(305, 9);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 0;
            label1.Text = "View Transaction";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(542, 49);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 1;
            label2.Text = "Search";
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(601, 46);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(165, 27);
            tbSearch.TabIndex = 2;
            tbSearch.Leave += tbSearch_Leave;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, customerIDDataGridViewTextBoxColumn, customerNameDataGridViewTextBoxColumn, employeNameDataGridViewTextBoxColumn, transactionTimeDataGridViewTextBoxColumn, completeEstimationTimeDataGridViewTextBoxColumn });
            dataGridView1.DataSource = vWHeaderDepositCustomerBindingSource;
            dataGridView1.Location = new Point(13, 79);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(752, 155);
            dataGridView1.TabIndex = 3;
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
            // customerIDDataGridViewTextBoxColumn
            // 
            customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            customerIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            customerIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            customerNameDataGridViewTextBoxColumn.HeaderText = "CustomerName";
            customerNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            customerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeNameDataGridViewTextBoxColumn
            // 
            employeNameDataGridViewTextBoxColumn.DataPropertyName = "EmployeName";
            employeNameDataGridViewTextBoxColumn.HeaderText = "EmployeName";
            employeNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            employeNameDataGridViewTextBoxColumn.Name = "employeNameDataGridViewTextBoxColumn";
            employeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // transactionTimeDataGridViewTextBoxColumn
            // 
            transactionTimeDataGridViewTextBoxColumn.DataPropertyName = "TransactionTime";
            transactionTimeDataGridViewTextBoxColumn.HeaderText = "TransactionTime";
            transactionTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            transactionTimeDataGridViewTextBoxColumn.Name = "transactionTimeDataGridViewTextBoxColumn";
            transactionTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // completeEstimationTimeDataGridViewTextBoxColumn
            // 
            completeEstimationTimeDataGridViewTextBoxColumn.DataPropertyName = "CompleteEstimationTime";
            completeEstimationTimeDataGridViewTextBoxColumn.HeaderText = "CompleteEstimationTime";
            completeEstimationTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            completeEstimationTimeDataGridViewTextBoxColumn.Name = "completeEstimationTimeDataGridViewTextBoxColumn";
            completeEstimationTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vWHeaderDepositCustomerBindingSource
            // 
            vWHeaderDepositCustomerBindingSource.DataSource = typeof(Models.VWHeaderDepositCustomer);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 56);
            label3.Name = "label3";
            label3.Size = new Size(114, 20);
            label3.TabIndex = 4;
            label3.Text = "Header Deposit";
            // 
            // detailDepositBindingSource
            // 
            detailDepositBindingSource.DataSource = typeof(Models.DetailDeposit);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 249);
            label4.Name = "label4";
            label4.Size = new Size(105, 20);
            label4.TabIndex = 6;
            label4.Text = "Detail Deposit";
            // 
            // vWDetailDepositsAndServiceBindingSource
            // 
            vWDetailDepositsAndServiceBindingSource.DataSource = typeof(Models.VWDetailDepositsAndService);
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(13, 272);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(752, 166);
            dataGridView2.TabIndex = 7;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // ViewTransactionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 450);
            Controls.Add(dataGridView2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(tbSearch);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewTransactionForm";
            Text = "ViewTransactionForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)vWHeaderDepositCustomerBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)detailDepositBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)vWDetailDepositsAndServiceBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbSearch;
        private DataGridView dataGridView1;
        private Label label3;
        private Label label4;
        private DataGridViewTextBoxColumn employeeNameDataGridViewTextBoxColumn;
        private BindingSource vWHeaderDepositCustomerBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn employeNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn transactionTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn completeEstimationTimeDataGridViewTextBoxColumn;
        private BindingSource detailDepositBindingSource;
        private BindingSource vWDetailDepositsAndServiceBindingSource;
        private DataGridView dataGridView2;
    }
}
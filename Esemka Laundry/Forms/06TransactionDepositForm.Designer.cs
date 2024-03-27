namespace Esemka_Laundry.Forms
{
    partial class TransactionDepositForm
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
            packageNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            packagePriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            estimationDurationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            subTotalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vWDetailDepositAndTranscationBindingSource = new BindingSource(components);
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            linkLabel1 = new LinkLabel();
            rtbAddress = new RichTextBox();
            tbName = new TextBox();
            tbPhoneNum = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            cbPackageName = new ComboBox();
            numTotalUnit = new NumericUpDown();
            btnAdd = new Button();
            btnRemove = new Button();
            btnSubmit = new Button();
            label7 = new Label();
            lblTotalPay = new Label();
            lblEstTime = new Label();
            lblTime = new Label();
            label9 = new Label();
            lblCurrentTime = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vWDetailDepositAndTranscationBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numTotalUnit).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(314, 9);
            label1.Name = "label1";
            label1.Size = new Size(146, 20);
            label1.TabIndex = 0;
            label1.Text = "Transaction Deposits";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, packageNameDataGridViewTextBoxColumn, packagePriceDataGridViewTextBoxColumn, quantityDataGridViewTextBoxColumn, estimationDurationDataGridViewTextBoxColumn, subTotalDataGridViewTextBoxColumn });
            dataGridView1.DataSource = vWDetailDepositAndTranscationBindingSource;
            dataGridView1.Location = new Point(12, 53);
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
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // packageNameDataGridViewTextBoxColumn
            // 
            packageNameDataGridViewTextBoxColumn.DataPropertyName = "PackageName";
            packageNameDataGridViewTextBoxColumn.HeaderText = "PackageName";
            packageNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            packageNameDataGridViewTextBoxColumn.Name = "packageNameDataGridViewTextBoxColumn";
            packageNameDataGridViewTextBoxColumn.ReadOnly = true;
            packageNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // packagePriceDataGridViewTextBoxColumn
            // 
            packagePriceDataGridViewTextBoxColumn.DataPropertyName = "PackagePrice";
            packagePriceDataGridViewTextBoxColumn.HeaderText = "PackagePrice";
            packagePriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            packagePriceDataGridViewTextBoxColumn.Name = "packagePriceDataGridViewTextBoxColumn";
            packagePriceDataGridViewTextBoxColumn.ReadOnly = true;
            packagePriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            quantityDataGridViewTextBoxColumn.ReadOnly = true;
            quantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // estimationDurationDataGridViewTextBoxColumn
            // 
            estimationDurationDataGridViewTextBoxColumn.DataPropertyName = "EstimationDuration";
            estimationDurationDataGridViewTextBoxColumn.HeaderText = "EstimationDuration";
            estimationDurationDataGridViewTextBoxColumn.MinimumWidth = 6;
            estimationDurationDataGridViewTextBoxColumn.Name = "estimationDurationDataGridViewTextBoxColumn";
            estimationDurationDataGridViewTextBoxColumn.ReadOnly = true;
            estimationDurationDataGridViewTextBoxColumn.Width = 125;
            // 
            // subTotalDataGridViewTextBoxColumn
            // 
            subTotalDataGridViewTextBoxColumn.DataPropertyName = "SubTotal";
            subTotalDataGridViewTextBoxColumn.HeaderText = "SubTotal";
            subTotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            subTotalDataGridViewTextBoxColumn.Name = "subTotalDataGridViewTextBoxColumn";
            subTotalDataGridViewTextBoxColumn.ReadOnly = true;
            subTotalDataGridViewTextBoxColumn.Width = 125;
            // 
            // vWDetailDepositAndTranscationBindingSource
            // 
            vWDetailDepositAndTranscationBindingSource.DataSource = typeof(Models.VWDetailDepositAndTranscation);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 279);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 2;
            label2.Text = "Package Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 319);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 3;
            label3.Text = "Total Unit :";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(linkLabel1);
            groupBox1.Controls.Add(rtbAddress);
            groupBox1.Controls.Add(tbName);
            groupBox1.Controls.Add(tbPhoneNum);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(286, 257);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(315, 194);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Customer";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(127, 49);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(160, 20);
            linkLabel1.TabIndex = 17;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Not found?, Add new+";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // rtbAddress
            // 
            rtbAddress.Enabled = false;
            rtbAddress.Location = new Point(127, 114);
            rtbAddress.Name = "rtbAddress";
            rtbAddress.Size = new Size(182, 70);
            rtbAddress.TabIndex = 12;
            rtbAddress.Text = "";
            // 
            // tbName
            // 
            tbName.Enabled = false;
            tbName.Location = new Point(127, 81);
            tbName.Name = "tbName";
            tbName.Size = new Size(182, 27);
            tbName.TabIndex = 11;
            // 
            // tbPhoneNum
            // 
            tbPhoneNum.Location = new Point(127, 19);
            tbPhoneNum.Name = "tbPhoneNum";
            tbPhoneNum.Size = new Size(182, 27);
            tbPhoneNum.TabIndex = 10;
            tbPhoneNum.Leave += tbPhoneNum_Leave;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 114);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 9;
            label6.Text = "Address :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 84);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 8;
            label5.Text = "Name :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 22);
            label4.Name = "label4";
            label4.Size = new Size(115, 20);
            label4.TabIndex = 7;
            label4.Text = "Phone Number :";
            // 
            // cbPackageName
            // 
            cbPackageName.FormattingEnabled = true;
            cbPackageName.Location = new Point(132, 276);
            cbPackageName.Name = "cbPackageName";
            cbPackageName.Size = new Size(148, 28);
            cbPackageName.TabIndex = 5;
            // 
            // numTotalUnit
            // 
            numTotalUnit.Location = new Point(132, 317);
            numTotalUnit.Name = "numTotalUnit";
            numTotalUnit.Size = new Size(148, 27);
            numTotalUnit.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(186, 349);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(694, 247);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(94, 29);
            btnRemove.TabIndex = 8;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(607, 409);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(181, 29);
            btnSubmit.TabIndex = 9;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(607, 284);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 13;
            label7.Text = "Total Pay :";
            // 
            // lblTotalPay
            // 
            lblTotalPay.AutoSize = true;
            lblTotalPay.Font = new Font("Segoe UI", 12F);
            lblTotalPay.Location = new Point(688, 279);
            lblTotalPay.Name = "lblTotalPay";
            lblTotalPay.Size = new Size(89, 28);
            lblTotalPay.TabIndex = 14;
            lblTotalPay.Text = "0000000";
            // 
            // lblEstTime
            // 
            lblEstTime.AutoSize = true;
            lblEstTime.Location = new Point(607, 349);
            lblEstTime.Name = "lblEstTime";
            lblEstTime.Size = new Size(123, 20);
            lblEstTime.TabIndex = 15;
            lblEstTime.Text = "Estimation Time :";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Location = new Point(728, 349);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(60, 20);
            lblTime.TabIndex = 16;
            lblTime.Text = "0 Hours";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 421);
            label9.Name = "label9";
            label9.Size = new Size(98, 20);
            label9.TabIndex = 17;
            label9.Text = "Current time :";
            // 
            // lblCurrentTime
            // 
            lblCurrentTime.AutoSize = true;
            lblCurrentTime.Location = new Point(116, 421);
            lblCurrentTime.Name = "lblCurrentTime";
            lblCurrentTime.Size = new Size(42, 20);
            lblCurrentTime.TabIndex = 18;
            lblCurrentTime.Text = "Time";
            // 
            // TransactionDepositForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblCurrentTime);
            Controls.Add(label9);
            Controls.Add(lblTime);
            Controls.Add(lblEstTime);
            Controls.Add(lblTotalPay);
            Controls.Add(label7);
            Controls.Add(btnSubmit);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(numTotalUnit);
            Controls.Add(cbPackageName);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TransactionDepositForm";
            Text = "_06TransactionDepositForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)vWDetailDepositAndTranscationBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numTotalUnit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn packageNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn packagePriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estimationDurationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn subTotalDataGridViewTextBoxColumn;
        private BindingSource vWDetailDepositAndTranscationBindingSource;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private ComboBox cbPackageName;
        private RichTextBox rtbAddress;
        private TextBox tbName;
        private TextBox tbPhoneNum;
        private Label label6;
        private Label label5;
        private Label label4;
        private NumericUpDown numTotalUnit;
        private Button btnAdd;
        private Button btnRemove;
        private Button btnSubmit;
        private Label label7;
        private Label lblTotalPay;
        private Label lblEstTime;
        private LinkLabel linkLabel1;
        private Label lblTime;
        private Label label9;
        private Label lblCurrentTime;
    }
}
namespace Esemka_Laundry.Forms
{
    partial class PrepaidPackageForm
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
            tbPrepaidSearch = new TextBox();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            packageNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vWPrepaidPackageCustomerAndServiceBindingSource = new BindingSource(components);
            label3 = new Label();
            tbPrepaidPackID = new TextBox();
            label4 = new Label();
            cbPrepaidPackage = new ComboBox();
            numPrepaidPrice = new NumericUpDown();
            label5 = new Label();
            button1 = new Button();
            comboBox1 = new ComboBox();
            groupBox1 = new GroupBox();
            lblAddress = new Label();
            lblName = new Label();
            label9 = new Label();
            label8 = new Label();
            linkLabel1 = new LinkLabel();
            tbPrepaidPhoneNum = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vWPrepaidPackageCustomerAndServiceBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrepaidPrice).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(292, 9);
            label1.Name = "label1";
            label1.Size = new Size(197, 20);
            label1.TabIndex = 0;
            label1.Text = "Transaction Prepaid Package";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(416, 36);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 1;
            label2.Text = "Search";
            // 
            // tbPrepaidSearch
            // 
            tbPrepaidSearch.Location = new Point(598, 33);
            tbPrepaidSearch.Name = "tbPrepaidSearch";
            tbPrepaidSearch.Size = new Size(190, 27);
            tbPrepaidSearch.TabIndex = 2;
            tbPrepaidSearch.Leave += tbPrepaidSearch_Leave;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, packageNameDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn });
            dataGridView1.DataSource = vWPrepaidPackageCustomerAndServiceBindingSource;
            dataGridView1.Location = new Point(12, 66);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(776, 195);
            dataGridView1.TabIndex = 3;
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
            // packageNameDataGridViewTextBoxColumn
            // 
            packageNameDataGridViewTextBoxColumn.DataPropertyName = "PackageName";
            packageNameDataGridViewTextBoxColumn.HeaderText = "PackageName";
            packageNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            packageNameDataGridViewTextBoxColumn.Name = "packageNameDataGridViewTextBoxColumn";
            packageNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vWPrepaidPackageCustomerAndServiceBindingSource
            // 
            vWPrepaidPackageCustomerAndServiceBindingSource.DataSource = typeof(Models.VWPrepaidPackageCustomerAndService);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 267);
            label3.Name = "label3";
            label3.Size = new Size(137, 20);
            label3.TabIndex = 4;
            label3.Text = "Prepaid Package ID";
            // 
            // tbPrepaidPackID
            // 
            tbPrepaidPackID.Enabled = false;
            tbPrepaidPackID.Location = new Point(155, 264);
            tbPrepaidPackID.Name = "tbPrepaidPackID";
            tbPrepaidPackID.Size = new Size(179, 27);
            tbPrepaidPackID.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 300);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 6;
            label4.Text = "Package";
            // 
            // cbPrepaidPackage
            // 
            cbPrepaidPackage.FormattingEnabled = true;
            cbPrepaidPackage.Location = new Point(155, 297);
            cbPrepaidPackage.Name = "cbPrepaidPackage";
            cbPrepaidPackage.Size = new Size(179, 28);
            cbPrepaidPackage.TabIndex = 7;
            // 
            // numPrepaidPrice
            // 
            numPrepaidPrice.Location = new Point(155, 331);
            numPrepaidPrice.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numPrepaidPrice.Minimum = new decimal(new int[] { 1000, 0, 0, 0 });
            numPrepaidPrice.Name = "numPrepaidPrice";
            numPrepaidPrice.Size = new Size(179, 27);
            numPrepaidPrice.TabIndex = 8;
            numPrepaidPrice.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 333);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 10;
            label5.Text = "Price";
            // 
            // button1
            // 
            button1.Location = new Point(240, 364);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 12;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Customer", "Service" });
            comboBox1.Location = new Point(475, 33);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(117, 28);
            comboBox1.TabIndex = 21;
            comboBox1.Leave += comboBox1_Leave;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblAddress);
            groupBox1.Controls.Add(lblName);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(linkLabel1);
            groupBox1.Controls.Add(tbPrepaidPhoneNum);
            groupBox1.Controls.Add(label7);
            groupBox1.Location = new Point(475, 264);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(313, 174);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Customer";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(132, 104);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(80, 20);
            lblAddress.TabIndex = 27;
            lblAddress.Text = "[ Address ]";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(132, 77);
            lblName.Name = "lblName";
            lblName.Size = new Size(67, 20);
            lblName.TabIndex = 26;
            lblName.Text = "[ Name ]";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 109);
            label9.Name = "label9";
            label9.Size = new Size(62, 20);
            label9.TabIndex = 25;
            label9.Text = "Address";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 76);
            label8.Name = "label8";
            label8.Size = new Size(49, 20);
            label8.TabIndex = 24;
            label8.Text = "Name";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(118, 50);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(166, 20);
            linkLabel1.TabIndex = 23;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Not Found? Add New +";
            // 
            // tbPrepaidPhoneNum
            // 
            tbPrepaidPhoneNum.Location = new Point(123, 20);
            tbPrepaidPhoneNum.Name = "tbPrepaidPhoneNum";
            tbPrepaidPhoneNum.Size = new Size(174, 27);
            tbPrepaidPhoneNum.TabIndex = 22;
            tbPrepaidPhoneNum.Leave += tbPrepaidPhoneNum_Leave;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 23);
            label7.Name = "label7";
            label7.Size = new Size(112, 20);
            label7.TabIndex = 21;
            label7.Text = "Phone Number ";
            // 
            // PrepaidPackageForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(numPrepaidPrice);
            Controls.Add(cbPrepaidPackage);
            Controls.Add(label4);
            Controls.Add(tbPrepaidPackID);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(tbPrepaidSearch);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PrepaidPackageForm";
            Text = "_07PrepaidPackageForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)vWPrepaidPackageCustomerAndServiceBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrepaidPrice).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbPrepaidSearch;
        private DataGridView dataGridView1;
        private Label label3;
        private TextBox tbPrepaidPackID;
        private Label label4;
        private ComboBox cbPrepaidPackage;
        private NumericUpDown numPrepaidPrice;
        private Label label5;
        private Button button1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn packageNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private BindingSource vWPrepaidPackageCustomerAndServiceBindingSource;
        private ComboBox comboBox1;
        private GroupBox groupBox1;
        private Label label9;
        private Label label8;
        private LinkLabel linkLabel1;
        private TextBox tbPrepaidPhoneNum;
        private Label label7;
        private Label lblAddress;
        private Label lblName;
    }
}
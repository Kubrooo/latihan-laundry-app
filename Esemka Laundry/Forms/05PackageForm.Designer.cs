namespace Esemka_Laundry.Forms
{
    partial class PackageForm
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
            tbPackageSearch = new TextBox();
            dataGridView1 = new DataGridView();
            packageIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            serviceNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalUnitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vWServiceAndPackageBindingSource = new BindingSource(components);
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tbPackageId = new TextBox();
            cbPackageService = new ComboBox();
            numPackageTotalUnit = new NumericUpDown();
            numPackagePrice = new NumericUpDown();
            btnPackageInsert = new Button();
            btnPackageUpdate = new Button();
            btnPackageDelete = new Button();
            btnPackageSave = new Button();
            btnPackageCancel = new Button();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vWServiceAndPackageBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPackageTotalUnit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPackagePrice).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(326, 9);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 0;
            label1.Text = "Manage Package";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(432, 38);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 1;
            label2.Text = "Search";
            // 
            // tbPackageSearch
            // 
            tbPackageSearch.Location = new Point(602, 35);
            tbPackageSearch.Name = "tbPackageSearch";
            tbPackageSearch.Size = new Size(186, 27);
            tbPackageSearch.TabIndex = 2;
            tbPackageSearch.Leave += tbPackageSearch_Leave;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { packageIDDataGridViewTextBoxColumn, serviceNameDataGridViewTextBoxColumn, totalUnitDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn });
            dataGridView1.DataSource = vWServiceAndPackageBindingSource;
            dataGridView1.Location = new Point(12, 68);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(776, 189);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // packageIDDataGridViewTextBoxColumn
            // 
            packageIDDataGridViewTextBoxColumn.DataPropertyName = "PackageID";
            packageIDDataGridViewTextBoxColumn.HeaderText = "PackageID";
            packageIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            packageIDDataGridViewTextBoxColumn.Name = "packageIDDataGridViewTextBoxColumn";
            packageIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serviceNameDataGridViewTextBoxColumn
            // 
            serviceNameDataGridViewTextBoxColumn.DataPropertyName = "ServiceName";
            serviceNameDataGridViewTextBoxColumn.HeaderText = "ServiceName";
            serviceNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            serviceNameDataGridViewTextBoxColumn.Name = "serviceNameDataGridViewTextBoxColumn";
            serviceNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalUnitDataGridViewTextBoxColumn
            // 
            totalUnitDataGridViewTextBoxColumn.DataPropertyName = "TotalUnit";
            totalUnitDataGridViewTextBoxColumn.HeaderText = "TotalUnit";
            totalUnitDataGridViewTextBoxColumn.MinimumWidth = 6;
            totalUnitDataGridViewTextBoxColumn.Name = "totalUnitDataGridViewTextBoxColumn";
            totalUnitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vWServiceAndPackageBindingSource
            // 
            vWServiceAndPackageBindingSource.DataSource = typeof(Models.VWServiceAndPackage);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 271);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 4;
            label3.Text = "Package ID ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 312);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 5;
            label4.Text = "Service";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 356);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 6;
            label5.Text = "Total Unit";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 402);
            label6.Name = "label6";
            label6.Size = new Size(41, 20);
            label6.TabIndex = 7;
            label6.Text = "Price";
            // 
            // tbPackageId
            // 
            tbPackageId.Enabled = false;
            tbPackageId.Location = new Point(127, 268);
            tbPackageId.Name = "tbPackageId";
            tbPackageId.Size = new Size(182, 27);
            tbPackageId.TabIndex = 8;
            // 
            // cbPackageService
            // 
            cbPackageService.FormattingEnabled = true;
            cbPackageService.Location = new Point(127, 309);
            cbPackageService.Name = "cbPackageService";
            cbPackageService.Size = new Size(182, 28);
            cbPackageService.TabIndex = 9;
            // 
            // numPackageTotalUnit
            // 
            numPackageTotalUnit.Location = new Point(127, 354);
            numPackageTotalUnit.Name = "numPackageTotalUnit";
            numPackageTotalUnit.Size = new Size(182, 27);
            numPackageTotalUnit.TabIndex = 10;
            // 
            // numPackagePrice
            // 
            numPackagePrice.Location = new Point(127, 400);
            numPackagePrice.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numPackagePrice.Minimum = new decimal(new int[] { 10000, 0, 0, 0 });
            numPackagePrice.Name = "numPackagePrice";
            numPackagePrice.Size = new Size(182, 27);
            numPackagePrice.TabIndex = 11;
            numPackagePrice.Value = new decimal(new int[] { 10000, 0, 0, 0 });
            // 
            // btnPackageInsert
            // 
            btnPackageInsert.Location = new Point(383, 308);
            btnPackageInsert.Name = "btnPackageInsert";
            btnPackageInsert.Size = new Size(94, 29);
            btnPackageInsert.TabIndex = 12;
            btnPackageInsert.Text = "Insert";
            btnPackageInsert.UseVisualStyleBackColor = true;
            btnPackageInsert.Click += btnPackageInsert_Click;
            // 
            // btnPackageUpdate
            // 
            btnPackageUpdate.Location = new Point(483, 308);
            btnPackageUpdate.Name = "btnPackageUpdate";
            btnPackageUpdate.Size = new Size(94, 29);
            btnPackageUpdate.TabIndex = 13;
            btnPackageUpdate.Text = "Update";
            btnPackageUpdate.UseVisualStyleBackColor = true;
            btnPackageUpdate.Click += btnPackageUpdate_Click;
            // 
            // btnPackageDelete
            // 
            btnPackageDelete.Location = new Point(583, 308);
            btnPackageDelete.Name = "btnPackageDelete";
            btnPackageDelete.Size = new Size(94, 29);
            btnPackageDelete.TabIndex = 14;
            btnPackageDelete.Text = "Delete";
            btnPackageDelete.UseVisualStyleBackColor = true;
            btnPackageDelete.Click += btnPackageDelete_Click;
            // 
            // btnPackageSave
            // 
            btnPackageSave.ForeColor = Color.Green;
            btnPackageSave.Location = new Point(432, 343);
            btnPackageSave.Name = "btnPackageSave";
            btnPackageSave.Size = new Size(94, 29);
            btnPackageSave.TabIndex = 15;
            btnPackageSave.Text = "Save";
            btnPackageSave.UseVisualStyleBackColor = true;
            btnPackageSave.Click += btnPackageSave_Click;
            // 
            // btnPackageCancel
            // 
            btnPackageCancel.ForeColor = Color.Green;
            btnPackageCancel.Location = new Point(532, 343);
            btnPackageCancel.Name = "btnPackageCancel";
            btnPackageCancel.Size = new Size(94, 29);
            btnPackageCancel.TabIndex = 16;
            btnPackageCancel.Text = "Cancel";
            btnPackageCancel.UseVisualStyleBackColor = true;
            btnPackageCancel.Click += btnPackageCancel_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Name", "Unit", "Price" });
            comboBox1.Location = new Point(491, 35);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(105, 28);
            comboBox1.TabIndex = 17;
            comboBox1.Leave += comboBox1_Leave;
            // 
            // PackageForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(btnPackageCancel);
            Controls.Add(btnPackageSave);
            Controls.Add(btnPackageDelete);
            Controls.Add(btnPackageUpdate);
            Controls.Add(btnPackageInsert);
            Controls.Add(numPackagePrice);
            Controls.Add(numPackageTotalUnit);
            Controls.Add(cbPackageService);
            Controls.Add(tbPackageId);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(tbPackageSearch);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PackageForm";
            Text = "PackageForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)vWServiceAndPackageBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPackageTotalUnit).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPackagePrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbPackageSearch;
        private DataGridView dataGridView1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tbPackageId;
        private ComboBox cbPackageService;
        private NumericUpDown numPackageTotalUnit;
        private NumericUpDown numPackagePrice;
        private Button btnPackageInsert;
        private Button btnPackageUpdate;
        private Button btnPackageDelete;
        private Button btnPackageSave;
        private Button btnPackageCancel;
        private DataGridViewTextBoxColumn packageIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn serviceNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalUnitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private BindingSource vWServiceAndPackageBindingSource;
        private ComboBox comboBox1;
    }
}
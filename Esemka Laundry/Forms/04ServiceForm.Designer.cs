namespace Esemka_Laundry.Forms
{
    partial class ServiceForm
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
            tbSearchService = new TextBox();
            dataGridView1 = new DataGridView();
            serviceIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            serviceNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            unitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            estimationDurationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vWServiceUnitAndCategoryBindingSource = new BindingSource(components);
            label3 = new Label();
            tbServiceId = new TextBox();
            tbServiceName = new TextBox();
            cbServiceCategory = new ComboBox();
            cbServiceUnit = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            numServicePrice = new NumericUpDown();
            numServiceDuration = new NumericUpDown();
            btnServiceInsert = new Button();
            label7 = new Label();
            label8 = new Label();
            btnServiceUpdate = new Button();
            btnServiceDelete = new Button();
            label9 = new Label();
            label10 = new Label();
            btnServiceSave = new Button();
            btnServiceCancel = new Button();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vWServiceUnitAndCategoryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numServicePrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numServiceDuration).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(318, 9);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 0;
            label1.Text = "Manage Service";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(428, 38);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 1;
            label2.Text = "Search";
            // 
            // tbSearchService
            // 
            tbSearchService.Location = new Point(597, 35);
            tbSearchService.Name = "tbSearchService";
            tbSearchService.Size = new Size(191, 27);
            tbSearchService.TabIndex = 2;
            tbSearchService.Leave += tbSearchService_Leave;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { serviceIDDataGridViewTextBoxColumn, serviceNameDataGridViewTextBoxColumn, categoryDataGridViewTextBoxColumn, unitDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, estimationDurationDataGridViewTextBoxColumn });
            dataGridView1.DataSource = vWServiceUnitAndCategoryBindingSource;
            dataGridView1.Location = new Point(12, 68);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(776, 277);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // serviceIDDataGridViewTextBoxColumn
            // 
            serviceIDDataGridViewTextBoxColumn.DataPropertyName = "ServiceID";
            serviceIDDataGridViewTextBoxColumn.HeaderText = "ServiceID";
            serviceIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            serviceIDDataGridViewTextBoxColumn.Name = "serviceIDDataGridViewTextBoxColumn";
            serviceIDDataGridViewTextBoxColumn.ReadOnly = true;
            serviceIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // serviceNameDataGridViewTextBoxColumn
            // 
            serviceNameDataGridViewTextBoxColumn.DataPropertyName = "ServiceName";
            serviceNameDataGridViewTextBoxColumn.HeaderText = "ServiceName";
            serviceNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            serviceNameDataGridViewTextBoxColumn.Name = "serviceNameDataGridViewTextBoxColumn";
            serviceNameDataGridViewTextBoxColumn.ReadOnly = true;
            serviceNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            categoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            categoryDataGridViewTextBoxColumn.ReadOnly = true;
            categoryDataGridViewTextBoxColumn.Width = 125;
            // 
            // unitDataGridViewTextBoxColumn
            // 
            unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            unitDataGridViewTextBoxColumn.HeaderText = "Unit";
            unitDataGridViewTextBoxColumn.MinimumWidth = 6;
            unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            unitDataGridViewTextBoxColumn.ReadOnly = true;
            unitDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.ReadOnly = true;
            priceDataGridViewTextBoxColumn.Width = 125;
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
            // vWServiceUnitAndCategoryBindingSource
            // 
            vWServiceUnitAndCategoryBindingSource.DataSource = typeof(Models.VWServiceUnitAndCategory);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 354);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 4;
            label3.Text = "Service ID";
            // 
            // tbServiceId
            // 
            tbServiceId.Enabled = false;
            tbServiceId.Location = new Point(135, 351);
            tbServiceId.Name = "tbServiceId";
            tbServiceId.Size = new Size(212, 27);
            tbServiceId.TabIndex = 5;
            // 
            // tbServiceName
            // 
            tbServiceName.Location = new Point(135, 384);
            tbServiceName.Name = "tbServiceName";
            tbServiceName.Size = new Size(212, 27);
            tbServiceName.TabIndex = 6;
            // 
            // cbServiceCategory
            // 
            cbServiceCategory.FormattingEnabled = true;
            cbServiceCategory.Location = new Point(135, 417);
            cbServiceCategory.Name = "cbServiceCategory";
            cbServiceCategory.Size = new Size(212, 28);
            cbServiceCategory.TabIndex = 7;
            // 
            // cbServiceUnit
            // 
            cbServiceUnit.FormattingEnabled = true;
            cbServiceUnit.Location = new Point(135, 451);
            cbServiceUnit.Name = "cbServiceUnit";
            cbServiceUnit.Size = new Size(212, 28);
            cbServiceUnit.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 387);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 9;
            label4.Text = "Service Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 420);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 10;
            label5.Text = "Category";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 455);
            label6.Name = "label6";
            label6.Size = new Size(36, 20);
            label6.TabIndex = 11;
            label6.Text = "Unit";
            // 
            // numServicePrice
            // 
            numServicePrice.Location = new Point(538, 352);
            numServicePrice.Name = "numServicePrice";
            numServicePrice.Size = new Size(150, 27);
            numServicePrice.TabIndex = 12;
            // 
            // numServiceDuration
            // 
            numServiceDuration.Location = new Point(538, 385);
            numServiceDuration.Name = "numServiceDuration";
            numServiceDuration.Size = new Size(150, 27);
            numServiceDuration.TabIndex = 13;
            // 
            // btnServiceInsert
            // 
            btnServiceInsert.Location = new Point(440, 418);
            btnServiceInsert.Name = "btnServiceInsert";
            btnServiceInsert.Size = new Size(94, 29);
            btnServiceInsert.TabIndex = 14;
            btnServiceInsert.Text = "Insert";
            btnServiceInsert.UseVisualStyleBackColor = true;
            btnServiceInsert.Click += btnServiceInsert_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(440, 356);
            label7.Name = "label7";
            label7.Size = new Size(41, 20);
            label7.TabIndex = 15;
            label7.Text = "Price";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(440, 387);
            label8.Name = "label8";
            label8.Size = new Size(90, 20);
            label8.TabIndex = 16;
            label8.Text = "Est Duration";
            // 
            // btnServiceUpdate
            // 
            btnServiceUpdate.Location = new Point(540, 418);
            btnServiceUpdate.Name = "btnServiceUpdate";
            btnServiceUpdate.Size = new Size(94, 29);
            btnServiceUpdate.TabIndex = 17;
            btnServiceUpdate.Text = "Update";
            btnServiceUpdate.UseVisualStyleBackColor = true;
            btnServiceUpdate.Click += btnServiceUpdate_Click;
            // 
            // btnServiceDelete
            // 
            btnServiceDelete.Location = new Point(640, 418);
            btnServiceDelete.Name = "btnServiceDelete";
            btnServiceDelete.Size = new Size(94, 29);
            btnServiceDelete.TabIndex = 18;
            btnServiceDelete.Text = "Delete";
            btnServiceDelete.UseVisualStyleBackColor = true;
            btnServiceDelete.Click += btnServiceDelete_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(703, 354);
            label9.Name = "label9";
            label9.Size = new Size(68, 20);
            label9.TabIndex = 19;
            label9.Text = "/ Per unit";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(703, 387);
            label10.Name = "label10";
            label10.Size = new Size(58, 20);
            label10.TabIndex = 20;
            label10.Text = "Hour(s)";
            // 
            // btnServiceSave
            // 
            btnServiceSave.ForeColor = Color.Green;
            btnServiceSave.Location = new Point(497, 453);
            btnServiceSave.Name = "btnServiceSave";
            btnServiceSave.Size = new Size(94, 29);
            btnServiceSave.TabIndex = 21;
            btnServiceSave.Text = "Save";
            btnServiceSave.UseVisualStyleBackColor = true;
            btnServiceSave.Click += btnServiceSave_Click;
            // 
            // btnServiceCancel
            // 
            btnServiceCancel.ForeColor = Color.ForestGreen;
            btnServiceCancel.Location = new Point(597, 453);
            btnServiceCancel.Name = "btnServiceCancel";
            btnServiceCancel.Size = new Size(94, 29);
            btnServiceCancel.TabIndex = 22;
            btnServiceCancel.Text = "Cancel";
            btnServiceCancel.UseVisualStyleBackColor = true;
            btnServiceCancel.Click += btnServiceCancel_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Name", "Price" });
            comboBox1.Location = new Point(483, 34);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(108, 28);
            comboBox1.TabIndex = 23;
            comboBox1.Leave += comboBox1_Leave;
            // 
            // ServiceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 491);
            Controls.Add(comboBox1);
            Controls.Add(btnServiceCancel);
            Controls.Add(btnServiceSave);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(btnServiceDelete);
            Controls.Add(btnServiceUpdate);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(btnServiceInsert);
            Controls.Add(numServiceDuration);
            Controls.Add(numServicePrice);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(cbServiceUnit);
            Controls.Add(cbServiceCategory);
            Controls.Add(tbServiceName);
            Controls.Add(tbServiceId);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(tbSearchService);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ServiceForm";
            Text = "ServiceForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)vWServiceUnitAndCategoryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)numServicePrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numServiceDuration).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbSearchService;
        private DataGridView dataGridView1;
        private Label label3;
        private TextBox tbServiceId;
        private TextBox tbServiceName;
        private ComboBox cbServiceCategory;
        private ComboBox cbServiceUnit;
        private Label label4;
        private Label label5;
        private Label label6;
        private NumericUpDown numServicePrice;
        private NumericUpDown numServiceDuration;
        private Button btnServiceInsert;
        private Label label7;
        private Label label8;
        private Button btnServiceUpdate;
        private Button btnServiceDelete;
        private Label label9;
        private Label label10;
        private Button btnServiceSave;
        private Button btnServiceCancel;
        private DataGridViewTextBoxColumn serviceIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn serviceNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estimationDurationDataGridViewTextBoxColumn;
        private BindingSource vWServiceUnitAndCategoryBindingSource;
        private ComboBox comboBox1;
    }
}
namespace Esemka_Laundry.Forms
{
    partial class MainForm
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
            btnMainFormLogout = new Button();
            lblMainSayHello = new Label();
            lblMainTittle = new Label();
            labelTanggal = new Label();
            panel1 = new Panel();
            btnMainMenu = new Button();
            panel2 = new Panel();
            btnMainCustomer = new Button();
            btnMainViewTransaction = new Button();
            btnMainPrepaidPackage = new Button();
            btnMainTransactionDepo = new Button();
            btnMainPackage = new Button();
            btnMainService = new Button();
            btnMainEmployee = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnMainFormLogout
            // 
            btnMainFormLogout.Location = new Point(823, 17);
            btnMainFormLogout.Name = "btnMainFormLogout";
            btnMainFormLogout.Size = new Size(94, 29);
            btnMainFormLogout.TabIndex = 0;
            btnMainFormLogout.Text = "LogOut";
            btnMainFormLogout.UseVisualStyleBackColor = true;
            btnMainFormLogout.Click += btnMainFormLogout_Click;
            // 
            // lblMainSayHello
            // 
            lblMainSayHello.AutoSize = true;
            lblMainSayHello.Location = new Point(676, 22);
            lblMainSayHello.Name = "lblMainSayHello";
            lblMainSayHello.Size = new Size(116, 20);
            lblMainSayHello.TabIndex = 1;
            lblMainSayHello.Text = "Hello, username";
            // 
            // lblMainTittle
            // 
            lblMainTittle.AutoSize = true;
            lblMainTittle.Font = new Font("Segoe UI", 10F);
            lblMainTittle.Location = new Point(121, 19);
            lblMainTittle.Name = "lblMainTittle";
            lblMainTittle.Size = new Size(133, 23);
            lblMainTittle.TabIndex = 8;
            lblMainTittle.Text = "Esemka Laundry";
            // 
            // labelTanggal
            // 
            labelTanggal.AutoSize = true;
            labelTanggal.Location = new Point(444, 21);
            labelTanggal.Name = "labelTanggal";
            labelTanggal.Size = new Size(61, 20);
            labelTanggal.TabIndex = 9;
            labelTanggal.Text = "Tanggal";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnMainMenu);
            panel1.Controls.Add(lblMainTittle);
            panel1.Controls.Add(labelTanggal);
            panel1.Controls.Add(btnMainFormLogout);
            panel1.Controls.Add(lblMainSayHello);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(935, 58);
            panel1.TabIndex = 10;
            // 
            // btnMainMenu
            // 
            btnMainMenu.Location = new Point(21, 17);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Size = new Size(94, 29);
            btnMainMenu.TabIndex = 10;
            btnMainMenu.Text = "Menu";
            btnMainMenu.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnMainCustomer);
            panel2.Controls.Add(btnMainViewTransaction);
            panel2.Controls.Add(btnMainPrepaidPackage);
            panel2.Controls.Add(btnMainTransactionDepo);
            panel2.Controls.Add(btnMainPackage);
            panel2.Controls.Add(btnMainService);
            panel2.Controls.Add(btnMainEmployee);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 58);
            panel2.Name = "panel2";
            panel2.Size = new Size(191, 499);
            panel2.TabIndex = 12;
            // 
            // btnMainCustomer
            // 
            btnMainCustomer.Location = new Point(21, 216);
            btnMainCustomer.Name = "btnMainCustomer";
            btnMainCustomer.Size = new Size(154, 29);
            btnMainCustomer.TabIndex = 14;
            btnMainCustomer.Text = "Manage Customer";
            btnMainCustomer.UseVisualStyleBackColor = true;
            btnMainCustomer.Click += btnMainCustomer_Click;
            // 
            // btnMainViewTransaction
            // 
            btnMainViewTransaction.Location = new Point(21, 181);
            btnMainViewTransaction.Name = "btnMainViewTransaction";
            btnMainViewTransaction.Size = new Size(154, 29);
            btnMainViewTransaction.TabIndex = 13;
            btnMainViewTransaction.Text = "View Transaction";
            btnMainViewTransaction.UseVisualStyleBackColor = true;
            btnMainViewTransaction.Click += btnMainViewTransaction_Click;
            // 
            // btnMainPrepaidPackage
            // 
            btnMainPrepaidPackage.Location = new Point(21, 146);
            btnMainPrepaidPackage.Name = "btnMainPrepaidPackage";
            btnMainPrepaidPackage.Size = new Size(154, 29);
            btnMainPrepaidPackage.TabIndex = 12;
            btnMainPrepaidPackage.Text = "Prepaid Package";
            btnMainPrepaidPackage.UseVisualStyleBackColor = true;
            btnMainPrepaidPackage.Click += btnMainPrepaidPackage_Click;
            // 
            // btnMainTransactionDepo
            // 
            btnMainTransactionDepo.Location = new Point(21, 111);
            btnMainTransactionDepo.Name = "btnMainTransactionDepo";
            btnMainTransactionDepo.Size = new Size(154, 29);
            btnMainTransactionDepo.TabIndex = 11;
            btnMainTransactionDepo.Text = "Transaction Deposit";
            btnMainTransactionDepo.UseVisualStyleBackColor = true;
            btnMainTransactionDepo.Click += btnMainTransactionDepo_Click;
            // 
            // btnMainPackage
            // 
            btnMainPackage.Location = new Point(21, 76);
            btnMainPackage.Name = "btnMainPackage";
            btnMainPackage.Size = new Size(154, 29);
            btnMainPackage.TabIndex = 10;
            btnMainPackage.Text = "Manage Package";
            btnMainPackage.UseVisualStyleBackColor = true;
            btnMainPackage.Click += btnMainPackage_Click;
            // 
            // btnMainService
            // 
            btnMainService.Location = new Point(21, 41);
            btnMainService.Name = "btnMainService";
            btnMainService.Size = new Size(154, 29);
            btnMainService.TabIndex = 9;
            btnMainService.Text = "Manage Service";
            btnMainService.UseVisualStyleBackColor = true;
            btnMainService.Click += btnMainService_Click;
            // 
            // btnMainEmployee
            // 
            btnMainEmployee.Location = new Point(21, 6);
            btnMainEmployee.Name = "btnMainEmployee";
            btnMainEmployee.Size = new Size(154, 29);
            btnMainEmployee.TabIndex = 8;
            btnMainEmployee.Text = "Manage Employee";
            btnMainEmployee.UseVisualStyleBackColor = true;
            btnMainEmployee.Click += btnMainEmployee_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(935, 557);
            Controls.Add(panel2);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Name = "MainForm";
            Text = "Esemka Laundry - Main";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnMainFormLogout;
        private Label lblMainSayHello;
        private Label lblMainTittle;
        private Label labelTanggal;
        private Panel panel1;
        private Button btnMainMenu;
        private Panel panel2;
        private Button btnMainViewTransaction;
        private Button btnMainPrepaidPackage;
        private Button btnMainTransactionDepo;
        private Button btnMainPackage;
        private Button btnMainService;
        private Button btnMainEmployee;
        private Button btnMainCustomer;
    }
}
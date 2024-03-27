namespace Esemka_Laundry.Forms
{
    partial class AddCustomerForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbAddCustomer = new TextBox();
            tbPhoneNumber = new TextBox();
            rtbAddress = new RichTextBox();
            label4 = new Label();
            btnAddSubmit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(140, 9);
            label1.Name = "label1";
            label1.Size = new Size(159, 28);
            label1.TabIndex = 0;
            label1.Text = "ADD CUSTOMER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 79);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 1;
            label2.Text = "Customer Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 113);
            label3.Name = "label3";
            label3.Size = new Size(112, 20);
            label3.TabIndex = 2;
            label3.Text = "Phone Number ";
            // 
            // tbAddCustomer
            // 
            tbAddCustomer.Location = new Point(174, 76);
            tbAddCustomer.Name = "tbAddCustomer";
            tbAddCustomer.Size = new Size(193, 27);
            tbAddCustomer.TabIndex = 3;
            // 
            // tbPhoneNumber
            // 
            tbPhoneNumber.Location = new Point(174, 110);
            tbPhoneNumber.Name = "tbPhoneNumber";
            tbPhoneNumber.Size = new Size(193, 27);
            tbPhoneNumber.TabIndex = 4;
            // 
            // rtbAddress
            // 
            rtbAddress.Location = new Point(174, 143);
            rtbAddress.Name = "rtbAddress";
            rtbAddress.Size = new Size(193, 72);
            rtbAddress.TabIndex = 5;
            rtbAddress.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 146);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 6;
            label4.Text = "Address";
            // 
            // btnAddSubmit
            // 
            btnAddSubmit.Location = new Point(174, 221);
            btnAddSubmit.Name = "btnAddSubmit";
            btnAddSubmit.Size = new Size(94, 29);
            btnAddSubmit.TabIndex = 7;
            btnAddSubmit.Text = "Submit";
            btnAddSubmit.UseVisualStyleBackColor = true;
            btnAddSubmit.Click += btnAddSubmit_Click;
            // 
            // AddCustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 267);
            Controls.Add(btnAddSubmit);
            Controls.Add(label4);
            Controls.Add(rtbAddress);
            Controls.Add(tbPhoneNumber);
            Controls.Add(tbAddCustomer);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddCustomerForm";
            Text = "_09AddCustomerForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbAddCustomer;
        private TextBox tbPhoneNumber;
        private RichTextBox rtbAddress;
        private Label label4;
        private Button btnAddSubmit;
    }
}
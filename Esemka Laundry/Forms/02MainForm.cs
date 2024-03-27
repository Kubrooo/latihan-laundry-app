using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esemka_Laundry.Forms
{
    public partial class MainForm : Form
    {
        EmployeeForm employeeForm;
        ServiceForm serviceForm;
        PackageForm packageForm;
        TransactionDepositForm transactionDepositForm;
        PrepaidPackageForm prepaidPackageForm;
        ViewTransactionForm viewTransactionForm;
        CustomerForm customerForm;
        Form currentOpenForm;
        private string? nameEmployee;
        private int idEmployee;
        public MainForm(string name, int id)
        {
            InitializeComponent();
            nameEmployee = name;
            idEmployee = id;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            labelTanggal.Text = DateTime.Now.ToString();
            lblMainSayHello.Text = "Hello, " + nameEmployee;
        }

        private void btnMainFormLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            var loginForm = new LoginForm();
            loginForm.Show();
        }
        private void btnMainEmployee_Click(object sender, EventArgs e)
        {
            if (employeeForm == null)
            {
                closeCurrentForm();
                employeeForm = new EmployeeForm();
                employeeForm.MdiParent = this;
                employeeForm.Dock = DockStyle.Fill;
                employeeForm.Show();
                currentOpenForm = employeeForm;
            }
        }

        private void btnMainService_Click(object sender, EventArgs e)
        {
            if (serviceForm == null)
            {
                closeCurrentForm();
                serviceForm = new ServiceForm();
                serviceForm.MdiParent = this;
                serviceForm.Dock = DockStyle.Fill;
                serviceForm.Show();
                currentOpenForm = serviceForm;
            }
        }

        private void btnMainPackage_Click(object sender, EventArgs e)
        {
            if (packageForm == null)
            {
                closeCurrentForm();
                packageForm = new PackageForm();
                packageForm.MdiParent = this;
                packageForm.Dock = DockStyle.Fill;
                packageForm.Show();
                currentOpenForm = packageForm;
            }
        }

        private void btnMainTransactionDepo_Click(object sender, EventArgs e)
        {
            if (transactionDepositForm == null)
            {
                closeCurrentForm();
                transactionDepositForm = new TransactionDepositForm(idEmployee);
                transactionDepositForm.MdiParent = this;
                transactionDepositForm.Dock = DockStyle.Fill;
                transactionDepositForm.Show();
                currentOpenForm = transactionDepositForm;
            }
        }

        private void btnMainPrepaidPackage_Click(object sender, EventArgs e)
        {
            if (prepaidPackageForm == null)
            {

                closeCurrentForm();
                prepaidPackageForm = new PrepaidPackageForm();
                prepaidPackageForm.MdiParent = this;
                prepaidPackageForm.Dock = DockStyle.Fill;
                prepaidPackageForm.Show();
                currentOpenForm = prepaidPackageForm;
            }
        }

        private void btnMainViewTransaction_Click(object sender, EventArgs e)
        {
            if (viewTransactionForm == null)
            {
                closeCurrentForm();
                viewTransactionForm = new ViewTransactionForm();
                viewTransactionForm.MdiParent = this;
                viewTransactionForm.Dock = DockStyle.Fill;
                viewTransactionForm.Show();
                currentOpenForm = viewTransactionForm;
            }
        }

        private void closeCurrentForm()
        {
            employeeForm = null;
            serviceForm = null;
            packageForm = null;
            transactionDepositForm = null;
            prepaidPackageForm = null;
            viewTransactionForm = null;

            if (currentOpenForm != null)
            {
                currentOpenForm.Close();
            }
        }

        private void btnMainCustomer_Click(object sender, EventArgs e)
        {
            if(viewTransactionForm == null)
            {
                closeCurrentForm();
                customerForm = new CustomerForm();
                customerForm.MdiParent = this;
                customerForm.Dock= DockStyle.Fill;
                customerForm.Show();
                currentOpenForm = customerForm;
            }
        }
    }
}

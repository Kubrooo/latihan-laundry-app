using Esemka_Laundry.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
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
    public partial class TransactionDepositForm : Form
    {
        DataContext? _context;
        private int totalPay, totalDuration, CustomerId, HeaderDepositId, IdEmployee, packageId, packagePrice, quantity, estimationTime, subTotal;
        private string packageName;
        List<VWDetailDepositAndTranscation> packageList = new List<VWDetailDepositAndTranscation>();
        private VWDetailDepositAndTranscation getPackage;
        public TransactionDepositForm(int id)
        {
            InitializeComponent();
            _context = new DataContext();
            IdEmployee = id;

        }
        private void TransactionLoadAndAddTobinding()
        {
            _context.vWDetailDepositAndTranscations.Load();
            vWDetailDepositAndTranscationBindingSource.DataSource = _context.vWDetailDepositAndTranscations.ToList();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CBPackageName();
            lblCurrentTime.Text = DateTime.Now.ToString();
            autoCompleteByPhoneNum();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            _context.Dispose();
            _context = null;
        }

        private void CBPackageName()
        {
            _context.Services.Load();
            var data = _context.Services.Local.ToList();
            cbPackageName.DisplayMember = "Name";
            cbPackageName.ValueMember = "Id";
            cbPackageName.DataSource = data;
        }

        private void autoCompleteByPhoneNum()
        {
            var phoneNum = _context.Customers.Select(c => c.PhoneNumber).ToArray();
            AutoCompleteStringCollection autoCompleteNum = new AutoCompleteStringCollection();
            autoCompleteNum.AddRange(phoneNum);
            tbPhoneNum.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbPhoneNum.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbPhoneNum.AutoCompleteCustomSource = autoCompleteNum;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddCustomerForm addCustomerForm = new AddCustomerForm();
            addCustomerForm.ShowDialog();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbPackageName.Text == "" || numTotalUnit.Value < 0)
            {
                MessageBox.Show("Cant Add the data,Your data is not complete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string serviceName = cbPackageName.SelectedItem.ToString();
                int serviceId = int.Parse(cbPackageName.SelectedValue.ToString());
                Service? service = await _context.Services.Where(s => s.Id == serviceId).FirstOrDefaultAsync();

                string phoneNum = tbPhoneNum.Text.ToString();
                Customer? customer = await _context.Customers.Where(c => c.PhoneNumber == phoneNum).FirstOrDefaultAsync();

                packageId = service.Id;
                packageName = service.Name;
                packagePrice = (int)service.PriceUnit;
                quantity = (int)numTotalUnit.Value;
                estimationTime = (int)service.EstimationDuration * quantity;
                subTotal = quantity * packagePrice;

                packageList.Add(new VWDetailDepositAndTranscation { Id = packageId, PackageName = packageName, PackagePrice = packagePrice, Quantity = quantity, EstimationDuration = estimationTime, SubTotal = subTotal });
                vWDetailDepositAndTranscationBindingSource.DataSource = packageList.ToList();
                dataGridView1.Refresh();

                totalPay += subTotal;
                totalDuration += estimationTime;

                lblTotalPay.Text = "Rp." + totalPay.ToString();
                lblTime.Text = totalDuration.ToString() + "hours";

            }
        }

        private async void tbPhoneNum_Leave(object sender, EventArgs e)
        {
            string phoneNum = tbPhoneNum.Text;
            Customer? customer = await _context.Customers.Where(c => c.PhoneNumber == phoneNum).FirstOrDefaultAsync();
            CustomerId = customer.Id;

            if (customer != null)
            {
                tbName.Text = customer.Name;
                rtbAddress.Text = customer.Address;
            }
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            if (tbPhoneNum.Text == "")
            {
                MessageBox.Show("Please check your identity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (packageList.Count < 1)
            {
                MessageBox.Show("You have to add a service", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                saveDbHeader();
            }
        }

        private async Task saveDbHeader()
        {
            string phoneNum = tbPhoneNum.Text.ToString();
            Customer? customer = await _context.Customers.Where(c => c.PhoneNumber == phoneNum).FirstOrDefaultAsync();
            CustomerId = customer.Id;

            Employee? employee = await _context.Employees.Where(e => e.Id == IdEmployee).FirstOrDefaultAsync();
            IdEmployee = employee.Id;

            Service? service = await _context.Services.Where(s => s.Id == packageId).FirstOrDefaultAsync();

            HeaderDeposit headerDeposit = new HeaderDeposit();
            headerDeposit.Customer = customer;
            headerDeposit.Employee = employee;
            headerDeposit.TransactionDateT = DateTime.Now;

            DateTime dt = DateTime.Now;
            DateTime dateTime = dt.AddHours((double)estimationTime);
            headerDeposit.CompleteEstimatedDateTime = dateTime;

            _context.HeaderDeposits.Add(headerDeposit);
            await _context.SaveChangesAsync();

            HeaderDepositId = headerDeposit.Id;

            foreach (var package in packageList)
            {
                DetailDeposit detailDeposit = new DetailDeposit();
                detailDeposit.HeaderDeposit = headerDeposit;
                detailDeposit.Service = service;
                detailDeposit.TotalUnit = quantity;
                detailDeposit.PriceUnit = subTotal;

                _context.DetailDeposits.Add(detailDeposit);
                await _context.SaveChangesAsync();
            }

            MessageBox.Show("Transaction Added", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            lblTotalPay.Text = (totalPay - getPackage.PackagePrice).ToString();
            lblTime.Text = (totalDuration - getPackage.EstimationDuration).ToString();

            packageList.Remove(getPackage);

            vWDetailDepositAndTranscationBindingSource.DataSource = packageList.ToList();
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];

            getPackage = packageList.ElementAt(index);
        }
    }
}

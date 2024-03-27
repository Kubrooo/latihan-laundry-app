using Esemka_Laundry.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using System.Windows.Forms;

namespace Esemka_Laundry.Forms
{
    public partial class CustomerForm : Form
    {
        DataContext? _context;
        private string? click, operation, autoComplete;
        private int? selectedCustomerID;
        public CustomerForm()
        {
            InitializeComponent();
            _context = new DataContext();
        }

        private void customerLoadAndAddToBinding()
        {
            _context.Customers.Load();
            customerBindingSource.DataSource = _context.Customers.ToList();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            customerLoadAndAddToBinding();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            _context.Dispose();
            _context = null;
        }

        private void Enable()
        {
            tbCustomerName.Enabled = true;
            tbCustomerPhoneNum.Enabled = true;
            rtbCustomerAddress.Enabled = true;
            btnCustomerSave.Enabled = true;
            btnCustomerCancel.Enabled = true;

            btnCustomerInsert.Enabled = false;
            btnCustomerDelete.Enabled = false;
            btnCustomerUpdate.Enabled = false;
        }

        private void Disable()
        {
            tbCustomerName.Enabled = false;
            tbCustomerPhoneNum.Enabled = false;
            rtbCustomerAddress.Enabled = false;
            btnCustomerSave.Enabled = false;
            btnCustomerCancel.Enabled = false;

            btnCustomerInsert.Enabled = true;
            btnCustomerDelete.Enabled = true;
            btnCustomerUpdate.Enabled = true;
        }

        private void clearFied()
        {
            tbCustomerName.Text = string.Empty;
            tbCustomerPhoneNum.Text = string.Empty;
            rtbCustomerAddress.Text = string.Empty;
        }

        private void autoCompleteByName()
        {
            var name = _context.Customers.Select(c => c.Name).ToArray();
            AutoCompleteStringCollection autoCompleteName = new AutoCompleteStringCollection();
            autoCompleteName.AddRange(name);
            tbCustomerSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbCustomerSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbCustomerSearch.AutoCompleteCustomSource = autoCompleteName;
        }

        private void autoCompleteByPhoneNum()

        {
            var phoneNum = _context.Customers.Select(p => p.PhoneNumber).ToArray();
            AutoCompleteStringCollection autoCompletePhoneNumber = new AutoCompleteStringCollection();
            autoCompletePhoneNumber.AddRange(phoneNum);
            tbCustomerSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbCustomerSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbCustomerSearch.AutoCompleteCustomSource = autoCompletePhoneNumber;
        }

        private void autoCompleteByAddress()
        {
            var address = _context.Customers.Select(a => a.Address).ToArray();
            AutoCompleteStringCollection autoCompleteAddress = new AutoCompleteStringCollection();
            autoCompleteAddress.AddRange(address);
            tbCustomerSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbCustomerSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbCustomerSearch.AutoCompleteCustomSource = autoCompleteAddress;
        }

        private async void showByName(string name)
        {
            _context.Customers.Load();
            List<Customer> customers = await _context.Customers.Where(c => c.Name.Contains(name)).ToListAsync();
            customerBindingSource.DataSource = customers.ToList();
            dataGridView1.Refresh();
        }

        private async void showByPhoneNumber(string phoneNum)
        {
            _context.Customers.Load();
            List<Customer> customers = await _context.Customers.Where(c => c.PhoneNumber.Contains(phoneNum)).ToListAsync();
            customerBindingSource.DataSource = customers.ToList();
            dataGridView1.Refresh();
        }

        private async void showByAddress(string address)
        {
            _context.Customers.Load();
            List<Customer> customers = await _context.Customers.Where(c => c.Address.Contains(address)).ToListAsync();
            customerBindingSource.DataSource = customers.ToList();
            dataGridView1.Refresh();
        }

        private async void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            var selectedCustomer = (Customer)customerBindingSource.List[index];
            selectedCustomerID = selectedCustomer.Id;

            click = "clicked";
            tbCustomerName.Text = selectedCustomer.Name.ToString();
            tbCustomerPhoneNum.Text = selectedCustomer.PhoneNumber.ToString();
            rtbCustomerAddress.Text = selectedCustomer.Address.ToString();
            Disable();
        }

        private void btnCustomerInsert_Click(object sender, EventArgs e)
        {
            AddCustomerForm addCustomerForm = new AddCustomerForm();

            addCustomerForm.ShowDialog();
        }

        private void btnCustomerUpdate_Click(object sender, EventArgs e)
        {
            if (click == null)
            {
                MessageBox.Show("Please select one row", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Enable();
                operation = "update";
            }
        }

        private async void actionUpdate()
        {
            if (selectedCustomerID != null)
            {
                Customer customer = await _context.Customers.FindAsync(selectedCustomerID);
                if (customer != null)
                {
                    customer.Name = tbCustomerName.Text.ToString();
                    customer.PhoneNumber = tbCustomerPhoneNum.Text.ToString();
                    customer.Address = rtbCustomerAddress.Text.ToString();
                    _context.Customers.Update(customer);
                    await _context.SaveChangesAsync();
                    customerLoadAndAddToBinding();
                    dataGridView1.Refresh();
                }
            }
            else
            {
                MessageBox.Show("Cant Edit data,Customer not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCustomerDelete_Click(object sender, EventArgs e)
        {
            if (click == null)
            {
                MessageBox.Show("Please select one row", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Enable();
                tbCustomerName.Enabled = false;
                tbCustomerPhoneNum.Enabled = false;
                rtbCustomerAddress.Enabled = false;
                operation = "delete";
            }
        }

        private async void actionDelete()
        {
            if (selectedCustomerID != null)
            {
                Customer customer = await _context.Customers.Where(c => c.Id == selectedCustomerID).FirstOrDefaultAsync();
                if (MessageBox.Show("Are you sure want delete this customer" + customer.Name, "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                {
                    return;
                }
                else
                {
                    _context.Customers.Remove(customer);
                    await _context.SaveChangesAsync();
                    selectedCustomerID = null;
                    customerLoadAndAddToBinding();
                }
            }
            else
            {
                MessageBox.Show("Cant delete the data,Customer not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCustomerSave_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "update":
                    actionUpdate(); break;
                case "delete":
                    actionDelete(); break;
                default: break;
            }
        }

        private void btnCustomerCancel_Click(object sender, EventArgs e)
        {
            clearFied();
            Disable();
            selectedCustomerID = null;
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            autoComplete = comboBox1.Text.ToString();
            switch (autoComplete)
            {
                case "Name":
                    autoCompleteByName(); break;
                case "PhoneNumber":
                    autoCompleteByPhoneNum(); break;
                case "Address":
                    autoCompleteByAddress(); break;
                default: break;

            }
        }

        private void tbCustomerSearch_Leave(object sender, EventArgs e)
        {
            switch (autoComplete)
            {
                case "Name":
                    showByName(tbCustomerSearch.Text.ToString()); break;
                case "PhoneNumber":
                    showByPhoneNumber(tbCustomerSearch.Text.ToString()); break;
                case "Address":
                    showByAddress(tbCustomerSearch.Text.ToString()); break;
                    default : break;
            }
        }
    }
}

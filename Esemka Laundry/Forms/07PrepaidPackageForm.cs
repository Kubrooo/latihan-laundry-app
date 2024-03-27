using Esemka_Laundry.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esemka_Laundry.Forms
{
    public partial class PrepaidPackageForm : Form
    {
        DataContext? _context;
        private string? autoComplete;
        private int customerID;
        public PrepaidPackageForm()
        {
            InitializeComponent();
            _context = new DataContext();
        }

        private void prepaidLoadAndAddToBinding()
        {
            _context.vWPrepaidPackageCustomerAndServices.Load();
            vWPrepaidPackageCustomerAndServiceBindingSource.DataSource = _context.vWPrepaidPackageCustomerAndServices.ToList();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            prepaidLoadAndAddToBinding();
            CBPackage();
            //_context.Customers.Load();
            autoCompletePhoneNumber();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            _context.Dispose();
            _context = null;
        }

        private void Enable()
        {
            tbPrepaidPackID.Enabled = true;
            cbPrepaidPackage.Enabled = true;
            numPrepaidPrice.Enabled = true;
            tbPrepaidPhoneNum.Enabled = true;
        }

        private void Disable()
        {
            tbPrepaidPackID.Enabled = false;
            cbPrepaidPackage.Enabled = false;
            numPrepaidPrice.Enabled = false;
            tbPrepaidPhoneNum.Enabled = false;
        }

        private void CBPackage()
        {
            _context.Services.Load();
            _context.Packages.Load();
            List<Package> data =  _context.Packages.Where(p => p.Id == 2).Include(p => p.Service).ThenInclude(s => s.Unit).ToList();
            Dictionary<int, string> packagesLoad = new Dictionary<int, string>();
            for(int i = 0; i < data.Count; i++)
            {
                var packageId = data[i].Id;
                var serviceName = data[i].Service.Name;
                packagesLoad.Add(packageId, serviceName);
                cbPrepaidPackage.DisplayMember = "Value"; 
                cbPrepaidPackage.ValueMember = "Key"; 
                cbPrepaidPackage.DataSource = new BindingSource(packagesLoad, null);
            }
            return;
        }

        private void autoCompleteByCustomer()
        {
            var name = _context.Customers.Select(n => n.Name).ToArray();
            AutoCompleteStringCollection autoCompleteName = new AutoCompleteStringCollection();
            autoCompleteName.AddRange(name);
            tbPrepaidSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbPrepaidSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbPrepaidSearch.AutoCompleteCustomSource = autoCompleteName;
        }

        private void autoCompleteByService()
        {
            var service = _context.Services.Select(s => s.Name).ToArray();
            AutoCompleteStringCollection autoCompleteService = new AutoCompleteStringCollection();
            autoCompleteService.AddRange(service);
            tbPrepaidSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbPrepaidSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbPrepaidSearch.AutoCompleteCustomSource = autoCompleteService;
        }

        private void autoCompletePhoneNumber()
        {
            var phoneNum = _context.Customers.Select(p => p.PhoneNumber).ToArray();
            AutoCompleteStringCollection autoCompletePhoneNum = new AutoCompleteStringCollection();
            autoCompletePhoneNum.AddRange(phoneNum);
            tbPrepaidPhoneNum.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbPrepaidPhoneNum.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbPrepaidPhoneNum.AutoCompleteCustomSource = autoCompletePhoneNum;
        }

        private async void showByCustomer(string name)
        {
            _context.vWPrepaidPackageCustomerAndServices.Load();
            List<VWPrepaidPackageCustomerAndService> customer = await _context.vWPrepaidPackageCustomerAndServices.Where(c => c.Name.Contains(name)).ToListAsync();
            vWPrepaidPackageCustomerAndServiceBindingSource.DataSource = customer.ToList();
        }

        private async void showByService(string service)
        {
            _context.vWPrepaidPackageCustomerAndServices.Load();
            List<VWPrepaidPackageCustomerAndService> services = await _context.vWPrepaidPackageCustomerAndServices.Where(s => s.PackageName.Contains(service)).ToListAsync();
            vWPrepaidPackageCustomerAndServiceBindingSource.DataSource = services.ToList();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddCustomerForm customerForm = new AddCustomerForm();
            customerForm.ShowDialog();
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            autoComplete = comboBox1.Text.ToString();
            switch (autoComplete)
            {
                case "Customer":
                    autoCompleteByCustomer(); break;
                case "Service":
                    autoCompleteByService(); break;
                default: break;
            }
        }

        private void tbPrepaidSearch_Leave(object sender, EventArgs e)
        {
            switch (autoComplete)
            {
                case "Customer":
                    showByCustomer(tbPrepaidSearch.Text.ToString()); break;
                case "Service":
                    showByService(tbPrepaidSearch.Text.ToString()); break;
                default: break;
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (cbPrepaidPackage.Text == ""|| tbPrepaidPhoneNum.Text == "")
            {
                MessageBox.Show("Your data is not complete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string packageName = cbPrepaidPackage.SelectedItem.ToString();
                int idPackage = int.Parse(cbPrepaidPackage.SelectedValue.ToString());
                Package? package = await _context.Packages.Where(p => p.Id == idPackage).FirstOrDefaultAsync();

                string customerName = lblName.Text.ToString();
                Customer? customer = await _context.Customers.Where(c => c.Name == customerName).FirstOrDefaultAsync();

                PrePaidPackage? prePaidPackage = new PrePaidPackage();

                prePaidPackage.Customer = customer;
                prePaidPackage.Package = package;
                prePaidPackage.Price = Convert.ToInt32(Math.Round(numPrepaidPrice.Value));
   
                _context.PrePaidPackages.Add(prePaidPackage);
                await _context.SaveChangesAsync();
                prepaidLoadAndAddToBinding();
                dataGridView1.Refresh();
                
            }
        }

        private async void tbPrepaidPhoneNum_Leave(object sender, EventArgs e)
        {
            string phoneNum = tbPrepaidPhoneNum.Text;
            Customer customer = await _context.Customers.Where(c => c.PhoneNumber == phoneNum).FirstOrDefaultAsync();
            customerID = customer.Id;
            if (customer != null)
             {
                lblName.Text =   customer.Name;
                lblAddress.Text = customer.Address;
             }
        }
    }
}

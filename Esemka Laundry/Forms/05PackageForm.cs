using Esemka_Laundry.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esemka_Laundry.Forms
{
    public partial class PackageForm : Form
    {
        DataContext? _context;
        private string? operation, clicked, service, autoComplete;
        private int? selectedPackageID;
        public PackageForm()
        {
            InitializeComponent();
            _context = new DataContext();
        }

        private void packageLoadAndAddToBinding()
        {
            _context.vWServiceAndPackages.Load();
            vWServiceAndPackageBindingSource.DataSource = _context.vWServiceAndPackages.ToList();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            packageLoadAndAddToBinding();
            Disable();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            _context.Dispose();
            _context = null;
        }

        private void Disable()
        {
            cbPackageService.Enabled = false;
            numPackageTotalUnit.Enabled = false;
            numPackagePrice.Enabled = false;
            btnPackageSave.Enabled = false;
            btnPackageCancel.Enabled = false;
        }

        private void Enable()
        {
            cbPackageService.Enabled = true;
            numPackageTotalUnit.Enabled = true;
            numPackagePrice.Enabled = true;
            btnPackageSave.Enabled = true;
            btnPackageCancel.Enabled = true;
        }

        private void clearField()
        {
            cbPackageService.Text = string.Empty;
            numPackagePrice.Value = 10000;
            numPackageTotalUnit.Value = 0;
        }

        private void CBService()
        {
            _context.Services.Load();
            var data = _context.Services.Local.ToList();
            cbPackageService.DisplayMember = "name";
            cbPackageService.ValueMember = "id";
            cbPackageService.DataSource = data;
        }

        private void autoCompleteByName()
        {
            var name = _context.Packages.Select(n => n.Service.Name.ToString()).ToArray();
            AutoCompleteStringCollection autoCompleteName = new AutoCompleteStringCollection();
            autoCompleteName.AddRange(name);
            tbPackageSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbPackageSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbPackageSearch.AutoCompleteCustomSource = autoCompleteName;
        }

        private void autoCompleteByUnit()
        {
            var unit = _context.Packages.Select(u => u.TotalUnit.ToString()).ToArray();
            AutoCompleteStringCollection autoCompleteUnit = new AutoCompleteStringCollection();
            autoCompleteUnit.AddRange(unit);
            tbPackageSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbPackageSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbPackageSearch.AutoCompleteCustomSource = autoCompleteUnit;
        }

        private void autoCompleteByPrice()
        {
            var price = _context.Packages.Select(p => p.Price.ToString()).ToArray();
            AutoCompleteStringCollection autoCompletePrice = new AutoCompleteStringCollection();
            autoCompletePrice.AddRange(price);
            tbPackageSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbPackageSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbPackageSearch.AutoCompleteCustomSource = autoCompletePrice;
        }

        private async void showByName(string name)
        {
            _context.vWServiceAndPackages.Load();
            List<VWServiceAndPackage> services = await _context.vWServiceAndPackages.Where(s => s.ServiceName.Contains(name)).ToListAsync();
            vWServiceAndPackageBindingSource.DataSource = services;
            dataGridView1.Refresh();
        }

        private async void showByUnit(string unit)
        {
            _context.vWServiceAndPackages.Load();
            List<VWServiceAndPackage> services = await _context.vWServiceAndPackages.Where(s => s.TotalUnit.ToString().Contains(unit)).ToListAsync();
            vWServiceAndPackageBindingSource.DataSource = services;
            dataGridView1.Refresh();
        }

        private async void showByPrice(string price)
        {
            _context.vWServiceAndPackages.Load();
            List<VWServiceAndPackage> services = await _context.vWServiceAndPackages.Where(s => s.Price.ToString().Contains(price)).ToListAsync();
            vWServiceAndPackageBindingSource.DataSource = services;
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            var selectedPackage = (VWServiceAndPackage)vWServiceAndPackageBindingSource[index];
            selectedPackageID = selectedPackage.PackageID;
            clicked = "click";

            Disable();
            tbPackageId.Text = selectedPackage.PackageID.ToString();
            cbPackageService.Text = selectedPackage.ServiceName.ToString();
            numPackageTotalUnit.Text = selectedPackage.TotalUnit.ToString();
            numPackagePrice.Text = selectedPackage.Price.ToString();

            service = selectedPackage.ServiceName.ToString();
        }

        private void btnPackageSave_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "insert":
                    actionInsert();
                    break;
                case "update":
                    actionUpdate();
                    break;
                case "delete":
                    actionDelete();
                    break;
            }
        }

        private void btnPackageInsert_Click(object sender, EventArgs e)
        {
            clearField();
            Enable();
            btnPackageInsert.Enabled = false;
            btnPackageUpdate.Enabled = false;
            btnPackageDelete.Enabled = false;
            CBService();
            operation = "insert";
        }

        private async void actionInsert()
        {
            if (cbPackageService.Text == "" || numPackageTotalUnit.Value < 0 || numPackagePrice.Value < 0)
            {
                MessageBox.Show("Please input all field first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string serText = cbPackageService.SelectedItem.ToString();
                int serId = int.Parse(cbPackageService.SelectedValue.ToString());
                Service? service = await _context.Services.Where(s => s.Id == serId).FirstOrDefaultAsync();

                Package? package = new Package();

                package.Service = service;
                package.TotalUnit = Convert.ToInt32(Math.Round(numPackageTotalUnit.Value, 0));
                package.Price = Convert.ToInt32(Math.Round(numPackagePrice.Value, 0));
                _context.Packages.Add(package);
                await _context.SaveChangesAsync();
                packageLoadAndAddToBinding();
                MessageBox.Show("Successfully insert data with ID : " + package.Id, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPackageUpdate_Click(object sender, EventArgs e)
        {
            if (clicked == null)
            {
                MessageBox.Show("Please select one row", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Enable();
                btnPackageInsert.Enabled = false;
                btnPackageUpdate.Enabled = false;
                btnPackageDelete.Enabled = false;
                CBService();

                operation = "update";
            }
        }

        private async void actionUpdate()
        {
            if (selectedPackageID != null)
            {
                Package? package = await _context.Packages.Where(p => p.Id == selectedPackageID).FirstOrDefaultAsync();

                if (package != null)
                {
                    int idService = int.Parse(cbPackageService.SelectedValue.ToString());
                    Service Packservice = await _context.Services.FindAsync(idService);
                    package.Service = Packservice;
                    package.TotalUnit = Convert.ToInt32(Math.Round(numPackageTotalUnit.Value, 0));
                    package.Price = Convert.ToInt32(Math.Round(numPackagePrice.Value, 0));

                    _context.Packages.Update(package);
                    await _context.SaveChangesAsync();
                    packageLoadAndAddToBinding();
                    clearField();
                    Disable();
                }
            }
        }

        private void btnPackageDelete_Click(object sender, EventArgs e)
        {
            if (clicked == null)
            {
                MessageBox.Show("Please select one row", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Disable();
                btnPackageInsert.Enabled = false;
                btnPackageDelete.Enabled = false;
                btnPackageUpdate.Enabled = false;
                btnPackageSave.Enabled = true;
                btnPackageCancel.Enabled = true;

                operation = "delete";
            }
        }

        private async void actionDelete()
        {
            if (selectedPackageID != null)
            {
                var package = await _context.Packages.Where(p => p.Id == selectedPackageID).FirstOrDefaultAsync();
                if (MessageBox.Show("Are you sure want to delete this data" + package.Service, "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                {
                    return;
                }
                else
                {
                    _context.Packages.Remove(package);
                    await _context.SaveChangesAsync();
                    packageLoadAndAddToBinding();
                }
            }
            else
            {
                MessageBox.Show("Can't Delete, because the data unavaible", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPackageCancel_Click(object sender, EventArgs e)
        {
            clearField();
            btnPackageInsert.Enabled = true;
            btnPackageDelete.Enabled = true;
            btnPackageUpdate.Enabled = true;

            btnPackageSave.Enabled = false;
            btnPackageCancel.Enabled = false;
            Disable();
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            autoComplete = comboBox1.Text.ToString();
            switch (autoComplete)
            {
                case "Name":
                    autoCompleteByName();
                    break;
                case "Unit":
                    autoCompleteByUnit();
                    break;
                case "Price":
                    autoCompleteByPrice();
                    break;
                default: break;
            }
        }

        private void tbPackageSearch_Leave(object sender, EventArgs e)
        {
            switch(autoComplete)
            {
                case "Name":
                    showByName(tbPackageSearch.Text.ToString()); break;
                case "Unit":
                    showByUnit(tbPackageSearch.Text.ToString()); break;
                case "Price":
                    showByPrice(tbPackageSearch.Text.ToString()); break;
                        default: break;
            }
        }
    }
}

using Esemka_Laundry.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esemka_Laundry.Forms
{
    public partial class ServiceForm : Form
    {
        DataContext? _context;
        private string? operation, clicked, category, unit, autoComplete;
        private int? selectedServiceId;
        public ServiceForm()
        {
            InitializeComponent();
            _context = new DataContext();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _context = _context ?? new DataContext();
            _context.Categories.Load();
            _context.Services.Load();
            _context.Units.Load();
            ServiceLoadAndAddToBinding();
            btnServiceSave.Enabled = false;
            btnServiceCancel.Enabled = false;
            Disable();

        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            _context.Dispose();
            _context = null;
        }

        private void ServiceLoadAndAddToBinding()
        {
            _context.vWServiceUnitAndCategories.Load();
            vWServiceUnitAndCategoryBindingSource.DataSource = _context.vWServiceUnitAndCategories.ToList();
        }

        private void Disable()
        {
            tbServiceName.Enabled = false;
            cbServiceCategory.Enabled = false;
            cbServiceUnit.Enabled = false;
            numServicePrice.Enabled = false;
            numServiceDuration.Enabled = false;
        }
        private void Enable()
        {
            tbServiceName.Enabled = true;
            cbServiceCategory.Enabled = true;
            cbServiceUnit.Enabled = true;
            numServicePrice.Enabled = true;
            numServiceDuration.Enabled = true;
        }

        private void clearField()
        {
            tbServiceId.Text = string.Empty;
            tbServiceName.Text = string.Empty;
            cbServiceCategory.Text = string.Empty;
            cbServiceUnit.Text = string.Empty;
            numServicePrice.Text = string.Empty;
            numServiceDuration.Text = string.Empty;
        }
        private void CbCategory()
        {
            _context.Categories.Load();
            var data = _context.Categories.Local.ToList();
            cbServiceCategory.DisplayMember = "Name";
            cbServiceCategory.ValueMember = "Id";
            cbServiceCategory.DataSource = data;
        }
        private void CbUnit()
        {
            _context.Units.Load();
            var data = _context.Units.Local.ToList();
            cbServiceUnit.DisplayMember = "Name";
            cbServiceUnit.ValueMember = "Id";
            cbServiceUnit.DataSource = data;
        }

        private void autoCompleteByName()
        {
            var name = _context.Services.Select(s => s.Name).ToArray();
            AutoCompleteStringCollection autoCompleteName = new AutoCompleteStringCollection();
            autoCompleteName.AddRange(name);
            tbSearchService.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbSearchService.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbSearchService.AutoCompleteCustomSource = autoCompleteName;
        }

        private void autoCompleteByPrice()
        {
            var priceUnit = _context.Services.Select(p => p.PriceUnit.ToString()).ToArray();
            AutoCompleteStringCollection autoCompletePrice = new AutoCompleteStringCollection();
            autoCompletePrice.AddRange(priceUnit);
            tbSearchService.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbSearchService.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbSearchService.AutoCompleteCustomSource = autoCompletePrice;
        }

        private async void showByName(string name)
        {
            _context.vWServiceAndPackages.Load();
            List<VWServiceAndPackage> services = await _context.vWServiceAndPackages.Where(s => s.ServiceName.Contains(name)).ToListAsync();
            vWServiceUnitAndCategoryBindingSource.DataSource = services;
            dataGridView1.Refresh();
        }

        private async void showByPrice(string price)
        {
            _context.vWServiceAndPackages.Load();
            List<VWServiceAndPackage> services = await _context.vWServiceAndPackages.Where(s => s.Price.ToString().Contains(price)).ToListAsync();
            vWServiceUnitAndCategoryBindingSource.DataSource = services;
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            var selectedService = (VWServiceUnitAndCategory)vWServiceUnitAndCategoryBindingSource[index];
            selectedServiceId = selectedService.ServiceID;
            clicked = "click";

            Disable();
            tbServiceName.Text = selectedService.ServiceName.ToString();
            cbServiceCategory.Text = selectedService.Category.ToString();
            cbServiceUnit.Text = selectedService.Unit.ToString();
            numServicePrice.Text = selectedService.Price.ToString();
            numServiceDuration.Text = selectedService.EstimationDuration.ToString();

            category = row.Cells[2].Value.ToString();
            unit = row.Cells[3].Value.ToString();
        }

        private void btnServiceSave_Click(object sender, EventArgs e)
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

        private void btnServiceInsert_Click(object sender, EventArgs e)
        {
            Enable();
            clearField();
            btnServiceInsert.Enabled = false;
            btnServiceUpdate.Enabled = false;
            btnServiceDelete.Enabled = false;
            btnServiceSave.Enabled = true;
            btnServiceCancel.Enabled = true;
            CbCategory();
            CbUnit();

            operation = "insert";
        }

        private async void actionInsert()
        {
            if (tbServiceName.Text == "" || cbServiceCategory.Text == "" || cbServiceUnit.Text == "" || numServicePrice.Value < 0 || numServiceDuration.Value < 0)
            {
                MessageBox.Show("You must enter data completely", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string catText = cbServiceCategory.SelectedItem.ToString();
                int catId = int.Parse(cbServiceCategory.SelectedValue.ToString());
                Category? categories = await _context.Categories.Where(c => c.Id == catId).FirstOrDefaultAsync();

                string unText = cbServiceUnit.SelectedItem.ToString();
                int unId = int.Parse(cbServiceUnit.SelectedValue.ToString());
                Unit? units = await _context.Units.Where(u => u.Id == unId).FirstOrDefaultAsync();

                Service service = new Service();
                service.Name = tbServiceName.Text;
                service.PriceUnit = Convert.ToInt32(Math.Round(numServicePrice.Value, 0));
                service.EstimationDuration = Convert.ToInt32(Math.Round(numServiceDuration.Value, 0));
                service.Category = categories;
                service.Unit = units;
                _context.Services.Add(service);
                await _context.SaveChangesAsync();
                ServiceLoadAndAddToBinding();
                dataGridView1.Refresh();
                MessageBox.Show("Successfully insert data with ID : " + service.Id, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnServiceUpdate_Click(object sender, EventArgs e)
        {
            if (clicked == null)
            {
                MessageBox.Show("Please select one row", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Show();
                Enable();
                btnServiceInsert.Enabled = false;
                btnServiceUpdate.Enabled = false;
                btnServiceDelete.Enabled = false;
                btnServiceSave.Enabled = true;
                btnServiceCancel.Enabled = true;

                CbCategory();
                cbServiceCategory.Text = category;
                CbUnit();
                cbServiceUnit.Text = unit;

                operation = "update";
            }
        }

        private async void actionUpdate()
        {
            if (selectedServiceId != null)
            {
                Service? service = await _context.Services.Where(s => s.Id == selectedServiceId).FirstOrDefaultAsync();

                if (service != null)
                {
                    service.Name = tbServiceName.Text;
                    int idCategory = int.Parse(cbServiceCategory.SelectedValue.ToString());
                    Category catService = await _context.Categories.FindAsync(idCategory);
                    service.Category = catService;
                    int idUnit = int.Parse(cbServiceUnit.SelectedValue.ToString());
                    Unit catUnit = await _context.Units.FindAsync(idUnit);
                    service.Unit = catUnit;
                    service.PriceUnit = Convert.ToInt32(Math.Round(numServicePrice.Value, 0));
                    service.EstimationDuration = Convert.ToInt32(Math.Round(numServicePrice.Value, 0));

                    _context.Services.Update(service);
                    await _context.SaveChangesAsync();
                    ServiceLoadAndAddToBinding();
                    MessageBox.Show("Successfully updated service data with ID: " + service.Id, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearField();
                }
                else
                {
                    MessageBox.Show("service not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnServiceDelete_Click(object sender, EventArgs e)
        {
            if (clicked == null)
            {
                MessageBox.Show("Please select one row", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Disable();
                btnServiceInsert.Enabled = false;
                btnServiceDelete.Enabled = false;
                btnServiceUpdate.Enabled = false;

                btnServiceSave.Enabled = true;
                btnServiceCancel.Enabled = true;

                operation = "delete";
            }
        }

        private async void actionDelete()
        {
            if (selectedServiceId != null)
            {
                var service = await _context.Services.Where(w => w.Id == selectedServiceId).FirstOrDefaultAsync();
                if (MessageBox.Show("Are you sure want to delete this  data?" + service.Name, "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                else
                {
                    _context.Services.Remove(service);
                    await _context.SaveChangesAsync();
                    ServiceLoadAndAddToBinding();
                    dataGridView1.Refresh();
                    MessageBox.Show("Successfully Delete service data with Name : " + service.Name, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Can't Delete, because the data unavaible", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnServiceCancel_Click(object sender, EventArgs e)
        {
            clearField();
            operation = "null";
            btnServiceInsert.Enabled = true;
            btnServiceUpdate.Enabled = true;
            btnServiceDelete.Enabled = true;

            btnServiceSave.Enabled = false;
            btnServiceCancel.Enabled = false;
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
                case "Price":
                    autoCompleteByPrice();
                    break;
                default: break;
            }
        }

        private void tbSearchService_Leave(object sender, EventArgs e)
        {
            switch (autoComplete) 
            {
                case"Name":
                    showByName(tbSearchService.Text.ToString());
                    break;
                case "Price":
                    showByPrice(tbSearchService.Text.ToString());
                    break;
                    default : break;
            }
        }
    }
}

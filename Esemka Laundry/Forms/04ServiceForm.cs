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
using System.Windows.Forms;

namespace Esemka_Laundry.Forms
{
    public partial class ServiceForm : Form
    {
        DataContext? _context;
        private string? operation, clicked, category, unit;
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
            btnServiceSave.Hide();
            btnServiceCancel.Hide();

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
            vWServiceUnitAndCategoryBindingSource.DataSource = _context.vWServiceUnitAndCategories.Local.ToBindingList();
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

        private void Show()
        {
            label3.Show();
            label4.Show();
            label5.Show();
            label6.Show();
            label7.Show();
            label8.Show();
            label9.Show();
            label10.Show();

            tbServiceId.Show();
            tbServiceName.Show();
            cbServiceCategory.Show();
            cbServiceUnit.Show();
            numServicePrice.Show();
            numServiceDuration.Show();
        }
        private void Hide()
        {
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            label10.Hide();

            tbServiceId.Hide();
            tbServiceName.Hide();
            cbServiceCategory.Hide();
            cbServiceUnit.Hide();
            numServicePrice.Hide();
            numServiceDuration.Hide();
        }

        private void clearField()
        {
            tbServiceName.Text = string.Empty;
            cbServiceCategory.Text = string.Empty;
            cbServiceUnit.Text = string.Empty;
            numServicePrice.Text = string.Empty;
            numServicePrice.Text = string.Empty;
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            var selectedService = (VWServiceUnitAndCategory)vWServiceUnitAndCategoryBindingSource[index];
            selectedServiceId = selectedService.ServiceID;
            clicked = "click";

            Show();
            Disable();
            tbServiceName.Text = row.Cells[1].Value.ToString();
            cbServiceCategory.Text = row.Cells[2].Value.ToString();
            cbServiceUnit.Text = row.Cells[3].Value.ToString();
            numServicePrice.Text = row.Cells[4].Value.ToString();
            numServiceDuration.Text = row.Cells[5].Value.ToString();

            category = row.Cells[2].Value.ToString();
            unit = row.Cells[3].Value.ToString();
        }

        private void btnServiceSave_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                
            }
        }

        private void btnServiceInsert_Click(object sender, EventArgs e)
        {
            Show();
            Enable();
            clearField();
            btnServiceInsert.Hide();
            btnServiceUpdate.Hide();
            btnServiceDelete.Hide();
            btnServiceSave.Show();
            btnServiceCancel.Show();
            CbCategory();
            CbUnit();

            operation = "insert";
        }

        private async void actionInsert()
        {
            if (tbServiceName.Text == "" || cbServiceCategory.Text == "" || cbServiceUnit.Text == "" || numServicePrice.Value  < 0 || numServiceDuration.Value < 0)
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
                service.Id = catId;
                service.PriceUnit = Convert.ToInt32(units);
            }
        }
    }
}

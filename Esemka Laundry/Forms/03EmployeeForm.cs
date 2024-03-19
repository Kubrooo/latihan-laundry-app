using Azure;
using Esemka_Laundry.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
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
    public partial class EmployeeForm : Form
    {
        DataContext _context;
        private int? selectedEmployeeID;
        private string? dgClick, job;
        public string? operation;
        public EmployeeForm()
        {
            InitializeComponent();
            _context = new DataContext();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            loadViewAndAddToBindingList();
            dataGridView1.ReadOnly = true;
            btnEmployeeSave.Hide();
            btnEmployeeCancel.Hide();
            disableField();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            _context.Dispose();
            _context = null;
        }
        private void clearField()
        {
            tbEmployeeName.Text = string.Empty;
            tbEmployeeEmail.Text = string.Empty;
            tbEmployeePhoneNumber.Text = string.Empty;
            tbEmployeePassword.Text = string.Empty;
            tbEmployeeConfirmPw.Text = string.Empty;
            rtbEmployeeAddress.Text = string.Empty;
            cbEmployeeJobTittle.Text = string.Empty;
            dtpEmployeeDateOfBirth.Text = string.Empty;
            numEmployeeSalary.Text = string.Empty;
        }
        private void enableField()
        {
            tbEmployeeName.Enabled = true;
            tbEmployeeEmail.Enabled = true;
            tbEmployeePhoneNumber.Enabled = true;
            tbEmployeePassword.Enabled = true;
            tbEmployeeConfirmPw.Enabled = true;
            rtbEmployeeAddress.Enabled = true;
            cbEmployeeJobTittle.Enabled = true;
            dtpEmployeeDateOfBirth.Enabled = true;
            numEmployeeSalary.Enabled = true;
        }
        private void disableField()
        {
            tbEmployeeName.Enabled = false;
            tbEmployeeEmail.Enabled = false;
            tbEmployeePhoneNumber.Enabled = false;
            tbEmployeePassword.Enabled = false;
            tbEmployeeConfirmPw.Enabled = false;
            rtbEmployeeAddress.Enabled = false;
            cbEmployeeJobTittle.Enabled = false;
            dtpEmployeeDateOfBirth.Enabled = false;
            numEmployeeSalary.Enabled = false;
        }
        private void showItems()
        {
            label3.Show();
            label4.Show();
            label5.Show();
            label6.Show();
            label7.Show();
            label8.Show();
            label9.Show();
            label10.Show();
            label11.Show();
            label12.Show();

            tbEmployeeID.Show();
            tbEmployeeName.Show();
            tbEmployeeEmail.Show();
            tbEmployeePhoneNumber.Show();
            tbEmployeePassword.Show();
            tbEmployeeConfirmPw.Show();
            rtbEmployeeAddress.Show();
            cbEmployeeJobTittle.Show();
            dtpEmployeeDateOfBirth.Show();
            numEmployeeSalary.Show();

            dtpEmployeeDateOfBirth.Format = DateTimePickerFormat.Custom;
            dtpEmployeeDateOfBirth.CustomFormat = "dd : MM : yyyy";
        }
        private void hideItems()
        {
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            label10.Hide();
            label11.Hide();
            label12.Hide();

            tbEmployeeID.Hide();
            tbEmployeeName.Hide();
            tbEmployeeEmail.Hide();
            tbEmployeePhoneNumber.Hide();
            tbEmployeePassword.Hide();
            tbEmployeeConfirmPw.Hide();
            rtbEmployeeAddress.Hide();
            cbEmployeeJobTittle.Hide();
            dtpEmployeeDateOfBirth.Hide();
            numEmployeeSalary.Hide();
        }

        private void cbJob()
        {
            _context.Jobs.Load();
            var data = _context.Jobs.Local.ToBindingList();
            cbEmployeeJobTittle.DisplayMember = "Name";
            cbEmployeeJobTittle.ValueMember = "Id";
            cbEmployeeJobTittle.DataSource = data;

        }

        private void loadViewAndAddToBindingList()
        {
            _context.VwEmployeeAndJob.Load();
            vWEmployeeAndJobBindingSource.DataSource = _context.VwEmployeeAndJob.ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            var selectedEmployee = (VWEmployeeAndJob)vWEmployeeAndJobBindingSource.List[index];
            selectedEmployeeID = selectedEmployee.Id;
            dgClick = "Clicked";

            Show();
            tbEmployeeID.Text = selectedEmployee.Id.ToString();
            tbEmployeeName.Text = selectedEmployee.EmployeeName.ToString();
            tbEmployeeEmail.Text = selectedEmployee.Email.ToString();
            tbEmployeePhoneNumber.Text = selectedEmployee.PhoneNumber.ToString();
            tbEmployeePassword.Enabled = false;
            tbEmployeeConfirmPw.Enabled = false;
            rtbEmployeeAddress.Text = selectedEmployee.Address.ToString();
            dtpEmployeeDateOfBirth.Text = selectedEmployee.DateOfBirth.ToString();
            cbEmployeeJobTittle.Text = selectedEmployee.JobTitle.ToString();
            numEmployeeSalary.Text = selectedEmployee.salary.ToString();
            job = cbEmployeeJobTittle.Text;
            disableField();
        }

        private void btnEmployeeInsert_Click(object sender, EventArgs e)
        {
            Show();
            btnEmployeeInsert.Hide();
            btnEmployeeDelete.Hide();
            btnEmployeeUpdate.Hide();
            btnEmployeeSave.Show();
            btnEmployeeCancel.Show();
            cbJob();
            enableField();
            clearField();

            operation = "insert";
        }

        private async void ActionInsert()
        {
            bool cPhoneNum = int.TryParse(tbEmployeePhoneNumber.Text, out var phoneNum);
            if (!cPhoneNum || tbEmployeeName.Text == "" || tbEmployeeEmail.Text == "" || tbEmployeePassword.Text == "" || tbEmployeeConfirmPw.Text == "" || rtbEmployeeAddress.Text == "" || cbEmployeeJobTittle.Text == "" || dtpEmployeeDateOfBirth.Text == "" || numEmployeeSalary.Value < 0)
            {
                MessageBox.Show("You must enter data completely", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string job = cbEmployeeJobTittle.SelectedItem.ToString();
                int idJob = int.Parse(cbEmployeeJobTittle.SelectedValue.ToString());
                Job? jobEm = await _context.Jobs.Where(j => j.Id == idJob).FirstOrDefaultAsync();

                Employee? newEmployee = new Employee();
                newEmployee.Name = tbEmployeeName.Text;
                newEmployee.Email = tbEmployeeEmail.Text;
                newEmployee.PhoneNumber = tbEmployeePhoneNumber.Text;
                newEmployee.Address = rtbEmployeeAddress.Text;
                newEmployee.DateOfBirth = dtpEmployeeDateOfBirth.Value;
                newEmployee.Job = jobEm;
                newEmployee.salary = Convert.ToInt32(Math.Round(numEmployeeSalary.Value, 0));

                _context.Employees.Add(newEmployee);
                await _context.SaveChangesAsync();
                loadViewAndAddToBindingList();
                dataGridView1.Refresh();
                MessageBox.Show("Successfully inserted new employee data with ID : " + newEmployee.Id, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEmployeeSave_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "insert":
                    ActionInsert();
                    break;
                case "update":
                    ActionUpdate();
                    break;
                case "delete":
                    ActionDelete();
                    break;
                default: 
                    break;
            }
        }

        private void btnEmployeeUpdate_Click(object sender, EventArgs e)
        {
            if (dgClick == null)
            {
                MessageBox.Show("please select one row", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Show();
                Show();
                btnEmployeeInsert.Hide();
                btnEmployeeDelete.Hide();
                btnEmployeeUpdate.Hide();
                btnEmployeeSave.Show();
                btnEmployeeCancel.Show();
                cbJob();
                enableField();

                operation = "update";
            }
        }

        private async void ActionUpdate()
        {
            if (selectedEmployeeID != null)
            {
                Employee employee = await _context.Employees.FindAsync(selectedEmployeeID);

                if (employee != null)
                {
                    employee.Name = tbEmployeeName.Text;
                    employee.Email = tbEmployeeEmail.Text;
                    employee.PhoneNumber = tbEmployeePhoneNumber.Text;
                    employee.Address = rtbEmployeeAddress.Text;
                    employee.DateOfBirth = dtpEmployeeDateOfBirth.Value;
                    employee.Password = tbEmployeePassword.Text;
                    int idJob = int.Parse(cbEmployeeJobTittle.SelectedValue.ToString());
                    Job jobEm = await _context.Jobs.FindAsync(idJob);
                    employee.Job = jobEm;
                    employee.salary = Convert.ToInt32(Math.Round(numEmployeeSalary.Value, 0));

                    _context.Employees.Update(employee);
                    await _context.SaveChangesAsync();
                    loadViewAndAddToBindingList();
                    MessageBox.Show("Successfully updated employee data with ID: " + employee.Id, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearField();
                }
                else
                {
                    MessageBox.Show("Employee not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEmployeeDelete_Click(object sender, EventArgs e)
        {
            if (dgClick == null)
            {
                MessageBox.Show("Please select one row", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                disableField();
                btnEmployeeInsert.Hide();
                btnEmployeeDelete.Hide();
                btnEmployeeUpdate.Hide();
                btnEmployeeSave.Show();
                btnEmployeeCancel.Show();

                operation = "delete";
            }
        }

        private async void ActionDelete()
        {
            if (selectedEmployeeID != null)
            {
                var employee = await _context.Employees.Where(m => m.Id == selectedEmployeeID).FirstOrDefaultAsync();

                if (MessageBox.Show("Are you sure want to delete" + employee.Name + "from this data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                else
                {
                    _context.Employees.Remove(employee);
                    await _context.SaveChangesAsync();
                    selectedEmployeeID = null;
                    loadViewAndAddToBindingList();
                    dataGridView1.Refresh();
                    MessageBox.Show("Successfully updated employee data with Name : " + employee.Name, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Can't updated, because the data unavaible", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEmployeeCancel_Click(object sender, EventArgs e)
        {
            clearField();
            operation = "null";
            btnEmployeeInsert.Show();
            btnEmployeeDelete.Show();
            btnEmployeeUpdate.Show();

            btnEmployeeSave.Hide();
            btnEmployeeCancel.Hide();

            disableField();

        }
    }
}

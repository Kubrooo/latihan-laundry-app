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
using System.Linq.Expressions;
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
        public string? operation, pw, autoComplete;
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
            btnEmployeeSave.Enabled = false;
            btnEmployeeCancel.Enabled = false;
            disableField();
            _context.Employees.Load();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            _context.Dispose();
            _context = null;
        }
        private void clearField()
        {
            tbEmployeeID.Text = string.Empty;
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

        private bool validationPassword(string password)
        {
            /*if (password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsSymbol))
            {
                MessageBox.Show("true");
                return true;
            }
            else
            {
                MessageBox.Show("false");
                return false;
            }*/
            if(password.All(char.IsDigit) && password.All(char.IsLetter))
            {
                MessageBox.Show("true");
                return true;
            }
             
            return true;
        }

        private async void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            var selectedEmployee = (VWEmployeeAndJob)vWEmployeeAndJobBindingSource.List[index];
            selectedEmployeeID = selectedEmployee.Id;
            dgClick = "Clicked";
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
            Employee? ppw = await _context.Employees.Where(e => e.Name == selectedEmployee.EmployeeName.ToString()).FirstOrDefaultAsync();
            pw = ppw.Password.ToString();
            tbEmployeePassword.Text = pw.ToString();
            tbEmployeeConfirmPw.Text = pw.ToString();
            disableField();
        }

        private void btnEmployeeInsert_Click(object sender, EventArgs e)
        {
            btnEmployeeInsert.Enabled = false;
            btnEmployeeUpdate.Enabled = false;
            btnEmployeeDelete.Enabled = false;
            btnEmployeeSave.Enabled = true;
            btnEmployeeCancel.Enabled = true;

            cbJob();
            enableField();
            clearField();

            operation = "insert";
        }

        private async void ActionInsert()
        {
            string password = tbEmployeePassword.Text.ToString();
            if (tbEmployeePhoneNumber.Text == "" || tbEmployeeName.Text == "" || tbEmployeeEmail.Text == "" || tbEmployeePassword.Text == "" || tbEmployeeConfirmPw.Text == "" || rtbEmployeeAddress.Text == "" || cbEmployeeJobTittle.Text == "" || dtpEmployeeDateOfBirth.Text == "" || numEmployeeSalary.Value < 0)
            {
                MessageBox.Show("You must enter data completely", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (validationPassword(password))
            {

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
                newEmployee.Password = tbEmployeePassword.Text;
                newEmployee.Job = jobEm;
                newEmployee.salary = Convert.ToInt32(Math.Round(numEmployeeSalary.Value, 0));

                _context.Employees.Add(newEmployee);
                await _context.SaveChangesAsync();
                loadViewAndAddToBindingList();
                dataGridView1.Refresh();
                disableField();
                btnEmployeeInsert.Enabled = true;
                btnEmployeeUpdate.Enabled = true;
                btnEmployeeDelete.Enabled = true;

                btnEmployeeSave.Enabled = false;
                btnEmployeeCancel.Enabled = false;
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
                case "cek":
                    validationPassword(pw); break;
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
                btnEmployeeInsert.Enabled = false;
                btnEmployeeDelete.Enabled = false;
                btnEmployeeUpdate.Enabled = false;
                btnEmployeeSave.Enabled = true;
                btnEmployeeCancel.Enabled = true;
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
                btnEmployeeInsert.Enabled = false;
                btnEmployeeDelete.Enabled = false;
                btnEmployeeUpdate.Enabled = false; ;
                btnEmployeeSave.Enabled = true;
                btnEmployeeCancel.Enabled = true;

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
                    MessageBox.Show("Successfully Delete employee data with Name : " + employee.Name, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            btnEmployeeInsert.Enabled = true;
            btnEmployeeDelete.Enabled = true;
            btnEmployeeUpdate.Enabled = true;

            btnEmployeeSave.Enabled = false;
            btnEmployeeCancel.Enabled = false;

            disableField();

        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            autoComplete = comboBox1.Text.ToString();
            switch (autoComplete)
            {
                case "Name":
                    autoCompleteByName();
                    break;
                case "Email":
                    autoCompleteByEmail();
                    break;
                case "PhoneNumber":
                    autoCompleteByPhone();
                    break;
                default: break;

            }
        }

        private void autoCompleteByName()
        {
            var name = _context.Employees.Select(s => s.Name).ToArray();
            AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
            autoCompleteStringCollection.AddRange(name);
            tbEmployeeSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbEmployeeSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbEmployeeSearch.AutoCompleteCustomSource = autoCompleteStringCollection;
        }

        private void autoCompleteByEmail()
        {
            var email = _context.Employees.Select(s => s.Email).ToArray();
            AutoCompleteStringCollection autoCompleteEmailCollection = new AutoCompleteStringCollection();
            autoCompleteEmailCollection.AddRange(email);
            tbEmployeeSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbEmployeeSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbEmployeeSearch.AutoCompleteCustomSource = autoCompleteEmailCollection;
        }
        private void autoCompleteByPhone()
        {
            var phone = _context.Employees.Select(s => s.PhoneNumber).ToArray();
            AutoCompleteStringCollection autoCompletePhoneCollection = new AutoCompleteStringCollection();
            autoCompletePhoneCollection.AddRange(phone);
            tbEmployeeSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbEmployeeSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbEmployeeSearch.AutoCompleteCustomSource = autoCompletePhoneCollection;
        }

        private async void showByName(string name)
        {
            _context.VwEmployeeAndJob.Load();
            List<VWEmployeeAndJob>? employees = await _context.VwEmployeeAndJob.Where(e => e.EmployeeName.Contains(name)).ToListAsync();
            vWEmployeeAndJobBindingSource.DataSource = employees.ToList();
            dataGridView1.Refresh();
        }

        private async void showByEmail(string email)
        {
            _context.VwEmployeeAndJob.Load();
            List<VWEmployeeAndJob>? employees = await _context.VwEmployeeAndJob.Where(e => e.EmployeeName.Contains(email)).ToListAsync();
            vWEmployeeAndJobBindingSource.DataSource = employees.ToList();
            dataGridView1.Refresh();
        }

        private async void showByPhoneNum(string phoneNum)
        {
            _context.VwEmployeeAndJob.Load();
            List<VWEmployeeAndJob>? employees = await _context.VwEmployeeAndJob.Where(e =>e.EmployeeName.Contains(phoneNum)).ToListAsync();
            vWEmployeeAndJobBindingSource.DataSource = employees.ToList();
        }

        private void tbEmployeeSearch_Leave(object sender, EventArgs e)
        {
            switch (autoComplete)
            {
                case "Name":
                    showByName(tbEmployeeSearch.Text.ToString()); break;
                case "Email":
                    showByEmail(tbEmployeeSearch.Text.ToString()); break;
                case "PhoneNumber":
                    showByPhoneNum(tbEmployeeSearch.Text.ToString()); break;
                default: break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnEmployeeInsert.Enabled = false;
            btnEmployeeUpdate.Enabled = false;
            btnEmployeeDelete.Enabled = false;
            btnEmployeeSave.Enabled = true;
            btnEmployeeCancel.Enabled = true;
            tbEmployeePassword.Enabled = true;

            pw = tbEmployeePassword.Text.ToString();
            operation = "cek";
        }
    }
}

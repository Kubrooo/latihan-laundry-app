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
    public partial class ViewTransactionForm : Form
    {
        DataContext? _context;
        private string? autoComplete, clicked;
        private int headerTransactionId, detailDepositId;
        private string completedDateTime;
        DataTable dt = new DataTable();
        public ViewTransactionForm()
        {
            InitializeComponent();
            _context = new DataContext();
        }

        private void loadHeaderAndAddToBinding()
        {
            _context.HeaderDeposits.Load();
            vWHeaderDepositCustomerBindingSource.DataSource = _context.vWHeaderDepositCustomers.ToList();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            loadHeaderAndAddToBinding();

            dt.Columns.Add(new DataColumn("ServceName", typeof(string)));
            dt.Columns.Add(new DataColumn("PrePaidPackageId",typeof(string)));
            dt.Columns.Add(new DataColumn("Price Per Unit",typeof (int)));
            dt.Columns.Add(new DataColumn("Total Unit",typeof(int)));
            dt.Columns.Add(new DataColumn("Complete Time",typeof(string)));
            //dt.Columns.Add(new DataColumn("Action",typeof(System.Windows.Forms.Button)));
            dataGridView2.DataSource = dt;     
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            _context.Dispose();
            _context = null;
        }

        private void autoCompleteByName()
        {
            var name = _context.Customers.Select(n => n.Name).ToArray();
            AutoCompleteStringCollection autoCompleteName = new AutoCompleteStringCollection();
            autoCompleteName.AddRange(name);
            tbSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbSearch.AutoCompleteCustomSource = autoCompleteName;
        }

        private void autoCompleteByEName()
        {
            var employeName = _context.Employees.Select(e => e.Name).ToArray();
            AutoCompleteStringCollection autoCompleteEmployeeName = new AutoCompleteStringCollection();
            tbSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbSearch.AutoCompleteCustomSource = autoCompleteEmployeeName;
        }

        private void autoCompleteByTransactionDateTime()
        {
            var dateTime = _context.HeaderDeposits.Select(h => h.TransactionDateT).ToArray();
            AutoCompleteStringCollection autoCompleteTransactionDate = new AutoCompleteStringCollection();
            tbSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            tbSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbSearch.AutoCompleteCustomSource = autoCompleteTransactionDate;
        }

        private async void showByCustomerName(string customerName)
        {
            _context.vWHeaderDepositCustomers.Load();
            List<VWHeaderDepositCustomer> deposits = await _context.vWHeaderDepositCustomers.Where(h => h.CustomerName.Contains(customerName)).ToListAsync();
            vWHeaderDepositCustomerBindingSource.DataSource = deposits;
            dataGridView1.Refresh();
        }

        private async void showByEmployeeName(string employeeName)
        {
            _context.vWHeaderDepositCustomers.Load();
            List<VWHeaderDepositCustomer> deposits = await _context.vWHeaderDepositCustomers.Where(h => h.EmployeName.Contains(employeeName)).ToListAsync();
            vWHeaderDepositCustomerBindingSource.DataSource = deposits;
            dataGridView1.Refresh();
        }

        private async void showByTransactionDateTime(string dateTime)
        {
            _context.vWHeaderDepositCustomers.Load();
            List<VWHeaderDepositCustomer> deposits = await _context.vWHeaderDepositCustomers.Where(h => h.TransactionTime.ToString().Contains(dateTime)).ToListAsync();
            vWHeaderDepositCustomerBindingSource.DataSource = deposits;
            dataGridView1.Refresh();
        }

        private void tbSearch_Leave(object sender, EventArgs e)
        {
            showByCustomerName(tbSearch.Text.ToString());
        }

        private async void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            var selectedHeader = (VWHeaderDepositCustomer)vWHeaderDepositCustomerBindingSource[index];
            headerTransactionId = selectedHeader.Id;

            await loadDetailDeposit(headerTransactionId);
            
           
        }

        private async Task loadDetailDeposit(int headerID)
        {
          
            List<VWDetailDepositsAndService> detailDeposits = await _context.vWDetailDepositsAndServices
                                                    .Where(d => d.HeaderDepositId == headerID)
                                                    .ToListAsync();
            foreach(var detail in detailDeposits)
            {
                DataRow dr = dt.NewRow();   
                dr[0] = detail.ServiceName;
                dr[1] = detail.PrepaidPackageId.ToString();
                dr[2] = detail.PriceUnit;
                dr[3] = detail.TotalUnit;
                dr[4] = detail.CompletedDateTime.ToString();
               
                
                Button actionButton = new Button();
                actionButton.Text = "Complete";
                dr[5] = actionButton;
                actionButton.Visible = true;
                
                dt.Rows.Add(dr);
            }
        }   

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView2.Columns["Action"].Index && e.RowIndex >= 0) ;
            {
                int index = e.RowIndex;
                DataGridViewRow row = dataGridView2.Rows[index];
                row.Cells[4].Value = DateTime.Now.ToString();
                dataGridView2.Refresh();
            }
        }
    }
}

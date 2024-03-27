using Esemka_Laundry.Models;
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
    public partial class AddCustomerForm : Form
    {
        DataContext? _context;
        public AddCustomerForm()
        {
            InitializeComponent();
            _context = new DataContext();
        }

        private void clearField()
        {
            tbAddCustomer.Text = string.Empty;
            tbPhoneNumber.Text = string.Empty;
            rtbAddress.Text = string.Empty;
        }

        private async void btnAddSubmit_Click(object sender, EventArgs e)
        {
         if(tbAddCustomer.Text == "" || tbPhoneNumber.Text == "" || rtbAddress.Text == "")
            {
               MessageBox.Show("Cant add a customer, please enter complete data","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            { 
                Customer customer = new Customer();
                customer.Name = tbAddCustomer.Text;
                customer.PhoneNumber = tbPhoneNumber.Text.ToString();
                customer.Address = rtbAddress.Text.ToString();

                _context.Customers.Add(customer);
                await _context.SaveChangesAsync();
                clearField();
            }
        }
    }
}

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
    public partial class EmployeeForm : Form
    {
        DataContext _context;
        public EmployeeForm()
        {
            InitializeComponent();
            _context = new DataContext();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _context.VwEmployeeAndJob.Load();
            vWEmployeeAndJobBindingSource.DataSource = _context.VwEmployeeAndJob.Local.ToBindingList();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            _context.Dispose();
            _context = null;
        }
    }
}

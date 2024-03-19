
using Esemka_Laundry.Forms;
using Microsoft.EntityFrameworkCore;

namespace Esemka_Laundry
{
    public partial class LoginForm : Form
    {
         DataContext _context;
        public LoginForm()
        {
            _context = new DataContext();
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _context = new DataContext();
            _context.Database.EnsureCreated();
            tbLoginUsername.Text = "adefrain0@diigo.com";
            tbLoginPassword.Text = "fkuXmGlww";
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            _context.Dispose();
            _context = null;
        }
        private void ClearForm()
        {
            tbLoginUsername.Text = string.Empty;
            tbLoginPassword.Text = string.Empty;
        }

        private async void btnLoginLogin_Click(object sender, EventArgs e)
        {
           if(tbLoginUsername.TextLength == 0 ||  tbLoginPassword.TextLength == 0)
            {
                MessageBox.Show("Username dan Password harus terisi","Eror",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

           var  userData = await _context.Employees.Where(e => e.Email == tbLoginUsername.Text).FirstOrDefaultAsync();
           if(userData == null) 
            {
                MessageBox.Show("Username tidak ditemukan", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if(userData.Password == tbLoginPassword.Text)
                { 
                    this.Hide();
                    var mainForm = new MainForm();
                    mainForm.Show(); //Pindah ke halaman berikutnya yaitu 02 Main Form
                }
            }
        }

        private void btnLoginReset_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}

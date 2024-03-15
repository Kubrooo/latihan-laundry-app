
namespace Esemka_Laundry
{
    public partial class LoginForm : Form
    {
        private DataContext? _context;
        public LoginForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _context = new DataContext();
            //eror
            _context.Database.EnsureCreated();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            _context.Dispose();
            _context = null;
        }
    }
}

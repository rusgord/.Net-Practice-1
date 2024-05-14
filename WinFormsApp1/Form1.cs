using WinFormsControlLibrary1;

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            usCtrl.Left = (this.ClientSize.Width - usCtrl.Width) / 2;
            usCtrl.Top = (this.ClientSize.Height - usCtrl.Height) / 2;
        }

        private void Size(object sender, EventArgs e)
        {
            usCtrl.Left = (this.ClientSize.Width - usCtrl.Width) / 2;
            usCtrl.Top = (this.ClientSize.Height - usCtrl.Height) / 2;
        }
    }
}

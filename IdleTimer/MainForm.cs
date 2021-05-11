using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using PInvoke.Win32;

namespace IdleTimer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            while (true)
            {
                label.Text = UserInput.IdleTime.ToString(@"hh\:mm\:ss\.fff");
                await Task.Delay(10);
            }
        }
    }
}

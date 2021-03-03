using System.Windows.Forms;

namespace BlockFluteConverter.src.Forms
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void link_deleteThis_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://youtu.be/N0VjXVTqMx4");
        }
    }
}

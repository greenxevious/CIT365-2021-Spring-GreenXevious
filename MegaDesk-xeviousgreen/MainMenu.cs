using System;
using System.Windows.Forms;

namespace MegaDesk_xeviousgreen
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            AddQuote f1 = new AddQuote();
            f1.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)//Exit button
        {
            this.Close();
        }
    }
}

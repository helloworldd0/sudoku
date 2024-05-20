using System;
using System.Windows.Forms;

namespace судоку
{
    public partial class Form3 : Form
    {
        Form1 form1 = new Form1();
        int seconds;
        int minutes;

        public Form3(int seconds, int minutes)
        {
            InitializeComponent();
            this.seconds = seconds;
            this.minutes = minutes;
            if (minutes < 10 && seconds < 10)
            {
                this.result.Text = $"0{minutes} : 0{seconds}";
            }
            else if (minutes < 10)
            {
                this.result.Text = $"0{minutes} : {seconds}";
            }
            else if (seconds < 10)
            {
                this.result.Text = $"{minutes} : 0{seconds}";
            }
            else
            {
                this.result.Text = $"{minutes} : {seconds}";
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            form1.Show();
        }
    }
}

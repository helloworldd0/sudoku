using System;
using System.Drawing;
using System.Windows.Forms;

namespace судоку
{
    public partial class Form1 : Form
    {
        Size originalSize;
        Point originalPoint;

        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        } 

        private void easyMode_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.GenerateMapEasy();
            this.Hide();
            form2.Show();
        }

        private void mediumMode_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.GenerateMapMedium();
            this.Hide();
            form2.Show();
        }

        private void hardMode_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.GenerateMapHard();
            this.Hide();
            form2.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void easyMode_MouseEnter(object sender, EventArgs e)
        {
            originalSize = easyMode.Size;
            originalPoint = easyMode.Location;
            int widthIncrease = (int)(easyMode.Width * 0.1);
            int heightIncrease = (int)(easyMode.Height * 0.1);
            easyMode.Size = new Size(easyMode.Width + widthIncrease, easyMode.Height + heightIncrease);
            easyMode.Location = new Point(easyMode.Location.X - widthIncrease / 2, easyMode.Location.Y - heightIncrease / 2);
        }

        private void easyMode_MouseLeave(object sender, EventArgs e)
        {
            easyMode.Size = originalSize;
            easyMode.Location = originalPoint;
        }

        private void mediumMode_MouseEnter(object sender, EventArgs e)
        {
            originalSize = mediumMode.Size;
            originalPoint = mediumMode.Location;
            int widthIncrease = (int)(mediumMode.Width * 0.1);
            int heightIncrease = (int)(mediumMode.Height * 0.1);
            mediumMode.Size = new Size(mediumMode.Width + widthIncrease, mediumMode.Height + heightIncrease);
            mediumMode.Location = new Point(mediumMode.Location.X - widthIncrease / 2, mediumMode.Location.Y - heightIncrease / 2);
        }

        private void mediumMode_MouseLeave(object sender, EventArgs e)
        {
            mediumMode.Size = originalSize;
            mediumMode.Location = originalPoint;
        }

        private void hardMode_MouseEnter(object sender, EventArgs e)
        {
            originalSize = hardMode.Size;
            originalPoint = hardMode.Location;
            int widthIncrease = (int)(hardMode.Width * 0.1);
            int heightIncrease = (int)(hardMode.Height * 0.1);
            hardMode.Size = new Size(hardMode.Width + widthIncrease, hardMode.Height + heightIncrease);
            hardMode.Location = new Point(hardMode.Location.X - widthIncrease / 2, hardMode.Location.Y - heightIncrease / 2);
        }

        private void hardMode_MouseLeave(object sender, EventArgs e)
        {
            hardMode.Size = originalSize;
            hardMode.Location = originalPoint;
        }
    }
}

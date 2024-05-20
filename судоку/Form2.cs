using System;
using System.Drawing;
using System.Windows.Forms;

namespace судоку
{
    public partial class Form2 : Form
    {
        const int n = 3;
        public int[,] map = new int[n * n, n * n];
        public int[,] tempmap = new int[n * n, n * n];
        public Button[,] buttons = new Button[n * n, n * n];
        public int[,] changable = new int[n * n, n * n];
        Random random = new Random();
        int seconds = 0;
        int minutes = 0;
        Form1 form1 = new Form1();

        public Form2()
        {
            InitializeComponent();
            timer1.Start();
        }

        public void GenerateMapEasy()
        {
            for (int i = 0; i < n * n; i++)
            {
                for (int j = 0; j < n * n; j++)
                {
                    map[i, j] = (i * n + i / n + j) % (n * n) + 1;
                }
            }
            Mix();
            CreateMap();
            HideButtonsEasy();
        }

        public void GenerateMapMedium()
        {
            for (int i = 0; i < n * n; i++)
            {
                for (int j = 0; j < n * n; j++)
                {
                    map[i, j] = (i * n + i / n + j) % (n * n) + 1;
                }
            }
            Mix();
            CreateMap();
            HideButtonsMedium();
        }

        public void GenerateMapHard()
        {
            for (int i = 0; i < n * n; i++)
            {
                for (int j = 0; j < n * n; j++)
                {
                    map[i, j] = (i * n + i / n + j) % (n * n) + 1;
                }
            }
            Mix();
            CreateMap();
            HideButtonsHard();
        }

        public void CreateMap()
        {
            for (int i = 0; i < n * n; i++)
            {
                for (int j = 0; j < n * n; j++)
                {
                    Button button = new Button();
                    button.Size = new Size(33, 33);
                    button.Text = map[i, j].ToString();
                    if (i == 0 && j == 0)
                    {
                        button.Location = new Point(115, 50);
                    }
                    else
                    {
                        button.Location = new Point(115 + j * 33, 50 + i * 33);
                    }
                    if ((i < n && (j < n || j >= n + n)) || (i >= n && i < n + n && j >= n && j < n + n) || (i >= n + n && (j < n || j >= n + n)))
                    {
                        button.BackColor = Color.LightGreen;
                    }
                    else
                    {
                        button.BackColor = Color.LightYellow;
                    }
                    buttons[i, j] = button;
                    button.Click += Button_Click;
                    this.Controls.Add(button);
                }
            }
        }

        public void Transposing()
        {
            for (int i = 0; i < n * n; i++)
            {
                for (int j = 0; j < n * n; j++)
                {
                    tempmap[i, j] = map[j, i];
                }
            }
            map = tempmap;
        }

        public void SwapRows()
        {
            int choice = random.Next(1, 10);

            switch (choice)
            {
                case 1:
                    for (int i = 0; i < n * n; i++)
                    {
                        for (int j = 0; j < n * n; j++)
                        {
                            if (i == 0)
                            {
                                tempmap[i, j] = map[1, j];
                            }
                            else if (i == 1)
                            {
                                tempmap[i, j] = map[0, j];
                            }
                            else
                            {
                                tempmap[i, j] = map[i, j];
                            }
                        }
                    }
                    break;
                case 2:
                    for (int i = 0; i < n * n; i++)
                    {
                        for (int j = 0; j < n * n; j++)
                        {
                            if (i == 0)
                            {
                                tempmap[i, j] = map[2, j];
                            }
                            else if (i == 2)
                            {
                                tempmap[i, j] = map[0, j];
                            }
                            else
                            {
                                tempmap[i, j] = map[i, j];
                            }
                        }
                    }
                    break;
                case 3:
                    for (int i = 0; i < n * n; i++)
                    {
                        for (int j = 0; j < n * n; j++)
                        {
                            if (i == 1)
                            {
                                tempmap[i, j] = map[2, j];
                            }
                            else if (i == 2)
                            {
                                tempmap[i, j] = map[1, j];
                            }
                            else
                            {
                                tempmap[i, j] = map[i, j];
                            }
                        }
                    }
                    break;
                case 4:
                    for (int i = 0; i < n * n; i++)
                    {
                        for (int j = 0; j < n * n; j++)
                        {
                            if (i == 3)
                            {
                                tempmap[i, j] = map[4, j];
                            }
                            else if (i == 4)
                            {
                                tempmap[i, j] = map[3, j];
                            }
                            else
                            {
                                tempmap[i, j] = map[i, j];
                            }
                        }
                    }
                    break;
                case 5:
                    for (int i = 0; i < n * n; i++)
                    {
                        for (int j = 0; j < n * n; j++)
                        {
                            if (i == 3)
                            {
                                tempmap[i, j] = map[5, j];
                            }
                            else if (i == 5)
                            {
                                tempmap[i, j] = map[3, j];
                            }
                            else
                            {
                                tempmap[i, j] = map[i, j];
                            }
                        }
                    }
                    break;
                case 6:
                    for (int i = 0; i < n * n; i++)
                    {
                        for (int j = 0; j < n * n; j++)
                        {
                            if (i == 5)
                            {
                                tempmap[i, j] = map[4, j];
                            }
                            else if (i == 4)
                            {
                                tempmap[i, j] = map[5, j];
                            }
                            else
                            {
                                tempmap[i, j] = map[i, j];
                            }
                        }
                    }
                    break;
                case 7:
                    for (int i = 0; i < n * n; i++)
                    {
                        for (int j = 0; j < n * n; j++)
                        {
                            if (i == 6)
                            {
                                tempmap[i, j] = map[7, j];
                            }
                            else if (i == 7)
                            {
                                tempmap[i, j] = map[6, j];
                            }
                            else
                            {
                                tempmap[i, j] = map[i, j];
                            }
                        }
                    }
                    break;
                case 8:
                    for (int i = 0; i < n * n; i++)
                    {
                        for (int j = 0; j < n * n; j++)
                        {
                            if (i == 6)
                            {
                                tempmap[i, j] = map[8, j];
                            }
                            else if (i == 8)
                            {
                                tempmap[i, j] = map[6, j];
                            }
                            else
                            {
                                tempmap[i, j] = map[i, j];
                            }
                        }
                    }
                    break;
                case 9:
                    for (int i = 0; i < n * n; i++)
                    {
                        for (int j = 0; j < n * n; j++)
                        {
                            if (i == 8)
                            {
                                tempmap[i, j] = map[7, j];
                            }
                            else if (i == 7)
                            {
                                tempmap[i, j] = map[8, j];
                            }
                            else
                            {
                                tempmap[i, j] = map[i, j];
                            }
                        }
                    }
                    break;
            }
            map = tempmap;
        }

        public void SwapCols()
        {
            int choice = random.Next(1, 10);

            switch (choice)
            {
                case 1:
                    for (int i = 0; i < n * n; i++)
                    {
                        for (int j = 0; j < n * n; j++)
                        {
                            if (j == 0)
                            {
                                tempmap[i, j] = map[i, 1];
                            }
                            else if (j == 1)
                            {
                                tempmap[i, j] = map[i, 0];
                            }
                            else
                            {
                                tempmap[i, j] = map[i, j];
                            }
                        }
                    }
                    break;
                case 2:
                    for (int i = 0; i < n * n; i++)
                    {
                        for (int j = 0; j < n * n; j++)
                        {
                            if (j == 0)
                            {
                                tempmap[i, j] = map[i, 2];
                            }
                            else if (j == 2)
                            {
                                tempmap[i, j] = map[i, 0];
                            }
                            else
                            {
                                tempmap[i, j] = map[i, j];
                            }
                        }
                    }
                    break;
                case 3:
                    for (int i = 0; i < n * n; i++)
                    {
                        for (int j = 0; j < n * n; j++)
                        {
                            if (j == 1)
                            {
                                tempmap[i, j] = map[i, 2];
                            }
                            else if (j == 2)
                            {
                                tempmap[i, j] = map[i, 1];
                            }
                            else
                            {
                                tempmap[i, j] = map[i, j];
                            }
                        }
                    }
                    break;
                case 4:
                    for (int i = 0; i < n * n; i++)
                    {
                        for (int j = 0; j < n * n; j++)
                        {
                            if (j == 3)
                            {
                                tempmap[i, j] = map[i, 4];
                            }
                            else if (j == 4)
                            {
                                tempmap[i, j] = map[i, 3];
                            }
                            else
                            {
                                tempmap[i, j] = map[i, j];
                            }
                        }
                    }
                    break;
                case 5:
                    for (int i = 0; i < n * n; i++)
                    {
                        for (int j = 0; j < n * n; j++)
                        {
                            if (j == 3)
                            {
                                tempmap[i, j] = map[i, 5];
                            }
                            else if (j == 5)
                            {
                                tempmap[i, j] = map[i, 3];
                            }
                            else
                            {
                                tempmap[i, j] = map[i, j];
                            }
                        }
                    }
                    break;
                case 6:
                    for (int i = 0; i < n * n; i++)
                    {
                        for (int j = 0; j < n * n; j++)
                        {
                            if (j == 5)
                            {
                                tempmap[i, j] = map[i, 4];
                            }
                            else if (j == 4)
                            {
                                tempmap[i, j] = map[i, 5];
                            }
                            else
                            {
                                tempmap[i, j] = map[i, j];
                            }
                        }
                    }
                    break;
                case 7:
                    for (int i = 0; i < n * n; i++)
                    {
                        for (int j = 0; j < n * n; j++)
                        {
                            if (j == 6)
                            {
                                tempmap[i, j] = map[i, 7];
                            }
                            else if (j == 7)
                            {
                                tempmap[i, j] = map[i, 6];
                            }
                            else
                            {
                                tempmap[i, j] = map[i, j];
                            }
                        }
                    }
                    break;
                case 8:
                    for (int i = 0; i < n * n; i++)
                    {
                        for (int j = 0; j < n * n; j++)
                        {
                            if (j == 6)
                            {
                                tempmap[i, j] = map[i, 8];
                            }
                            else if (j == 8)
                            {
                                tempmap[i, j] = map[i, 6];
                            }
                            else
                            {
                                tempmap[i, j] = map[i, j];
                            }
                        }
                    }
                    break;
                case 9:
                    for (int i = 0; i < n * n; i++)
                    {
                        for (int j = 0; j < n * n; j++)
                        {
                            if (j == 8)
                            {
                                tempmap[i, j] = map[i, 7];
                            }
                            else if (j == 7)
                            {
                                tempmap[i, j] = map[i, 8];
                            }
                            else
                            {
                                tempmap[i, j] = map[i, j];
                            }
                        }
                    }
                    break;
            }
            map = tempmap;
        }

        public void SwapROWS()
        {
            int choice = random.Next(1, 4);

            switch (choice)
            {
                case 1:
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n * n; j++)
                        {
                            tempmap[i, j] = map[i + n, j];
                        }
                    }
                    for (int i = n; i < n + n; i++)
                    {
                        for (int j = 0; j < n * n; j++)
                        {
                            tempmap[i, j] = map[i - n, j];
                        }
                    }
                    for (int i = n + n; i < n * n; i++)
                    {
                        for (int j = 0; j < n * n; j++)
                        {
                            tempmap[i, j] = map[i, j];
                        }
                    }
                    break;
                case 2:
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n * n; j++)
                        {
                            tempmap[i, j] = map[i + n + n, j];
                        }
                    }
                    for (int i = n; i < n + n; i++)
                    {
                        for (int j = 0; j < n * n; j++)
                        {
                            tempmap[i, j] = map[i, j];
                        }
                    }
                    for (int i = n + n; i < n * n; i++)
                    {
                        for (int j = 0; j < n * n; j++)
                        {
                            tempmap[i, j] = map[i - n - n, j];
                        }
                    }
                    break;
                case 3:
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n * n; j++)
                        {
                            tempmap[i, j] = map[i, j];
                        }
                    }
                    for (int i = n; i < n + n; i++)
                    {
                        for (int j = 0; j < n * n; j++)
                        {
                            tempmap[i, j] = map[i + n, j];
                        }
                    }
                    for (int i = n + n; i < n * n; i++)
                    {
                        for (int j = 0; j < n * n; j++)
                        {
                            tempmap[i, j] = map[i - n, j];
                        }
                    }
                    break;
            }
            map = tempmap;
        }

        public void SwapCOLS()
        {
            int choice = random.Next(1, 4);

            switch (choice)
            {
                case 1:
                    for (int i = 0; i < n * n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            tempmap[i, j] = map[i, j + n];
                        }
                    }
                    for (int i = 0; i < n * n; i++)
                    {
                        for (int j = n; j < n + n; j++)
                        {
                            tempmap[i, j] = map[i, j - n];
                        }
                    }
                    for (int i = 0; i < n * n; i++)
                    {
                        for (int j = n + n; j < n * n; j++)
                        {
                            tempmap[i, j] = map[i, j];
                        }
                    }
                    break;
                case 2:
                    for (int i = 0; i < n * n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            tempmap[i, j] = map[i, j + n + n];
                        }
                    }
                    for (int i = 0; i < n * n; i++)
                    {
                        for (int j = n; j < n + n; j++)
                        {
                            tempmap[i, j] = map[i, j];
                        }
                    }
                    for (int i = 0; i < n * n; i++)
                    {
                        for (int j = n + n; j < n * n; j++)
                        {
                            tempmap[i, j] = map[i, j - n - n];
                        }
                    }
                    break;
                case 3:
                    for (int i = 0; i < n * n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            tempmap[i, j] = map[i, j];
                        }
                    }
                    for (int i = 0; i < n * n; i++)
                    {
                        for (int j = n; j < n + n; j++)
                        {
                            tempmap[i, j] = map[i, j + n];
                        }
                    }
                    for (int i = 0; i < n * n; i++)
                    {
                        for (int j = n + n; j < n * n; j++)
                        {
                            tempmap[i, j] = map[i, j - n];
                        }
                    }
                    break;
            }
            map = tempmap;
        }

        public void Mix()
        {
            int choice = random.Next(0, 6);
            switch (choice)
            {
                case 1:
                    Transposing();
                    break;
                case 2:
                    SwapRows();
                    break;
                case 3:
                    SwapCols();
                    break;
                case 4:
                    SwapROWS();
                    break;
                case 5:
                    SwapCOLS();
                    break;
            }
        }

        public void HideButtonsEasy()
        {
            for (int i = 0; i < n * n; i++)
            {
                for (int j = 0; j < n * n; j++)
                {
                    int r = random.Next(0, 5);
                    if ( r == 0)
                    {
                        buttons[i, j].Text = " ";
                        changable[i, j] = 1;
                    }
                    else
                    {
                        changable[i, j] = 0;
                    }
                }
            }
        }

        public void HideButtonsMedium()
        {
            for (int i = 0; i < n * n; i++)
            {
                for (int j = 0; j < n * n; j++)
                {
                    int r = random.Next(0, 3);
                    if (r == 0)
                    {
                        buttons[i, j].Text = " ";
                        changable[i, j] = 1;
                    }
                    else
                    {
                        changable[i, j] = 0;
                    }
                }
            }
        }

        public void HideButtonsHard()
        {
            for (int i = 0; i < n * n; i++)
            {
                for (int j = 0; j < n * n; j++)
                {
                    int r = random.Next(0, 2);
                    if (r == 0)
                    {
                        buttons[i, j].Text = " ";
                        changable[i, j] = 1;
                    } else
                    {
                        changable[i, j] = 0;
                    }
                }
            }
        }

        public void Button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            for (int i = 0; i < n * n; i++)
            {
                for (int j = 0; j < n * n; j++)
                {
                    if (changable[i, j] == 1 && buttons[i, j] == button)
                    { 
                        if (buttons[i, j].Text == " " || buttons[i, j].Text == "9")
                        {
                            buttons[i, j].Text = "1";
                        } else
                        {
                            int value = Convert.ToInt32(buttons[i,j].Text);
                            value++;
                            buttons[i, j].Text = value.ToString();
                        }
                        buttons[i, j].BackColor = Color.PeachPuff;
                    }
                }
            }
        }

        public bool Check()
        {
            for (int i = 0; i < n * n; i++)
            {
                for (int j = 0; j < n * n; j++)
                {
                    int check;
                    if (buttons[i, j].Text == " ")
                    {
                        check = 0;
                    }
                    else
                    {
                        check = Convert.ToInt32(buttons[i, j].Text);
                    }
                    if (map[i, j] != check)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void cheсking_Click(object sender, EventArgs e)
        {
            if (!Check())
            {
                MessageBox.Show("    Упс! Неверное решение( Попробуйте ещё раз!");
            } else
            {
                Form3 form3 = new Form3(seconds, minutes);
                this.Close();
                form3.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;
            if (seconds == 60) {
                minutes++;
                seconds = 0;
            }
            if (minutes < 10 && seconds < 10)
            {
                this.label1.Text = $"0{minutes} : 0{seconds}";
            } else if (minutes < 10)
            {
                this.label1.Text = $"0{minutes} : {seconds}";
            } else if (seconds < 10)
            {
                this.label1.Text = $"{minutes} : 0{seconds}";
            } else
            {
                this.label1.Text = $"{minutes} : {seconds}";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        { 
            this.Close();
            form1.Show();
        }
    }
}
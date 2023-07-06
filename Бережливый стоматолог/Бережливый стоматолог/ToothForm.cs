using System;
using System.Drawing;
using System.Windows.Forms;

namespace Бережливый_стоматолог
{
    public partial class ToothForm : Form
    {
        bool isMan;
        uint period;
        public ToothForm(bool isMan, uint period)
        {
            InitializeComponent();

            this.isMan = isMan;
            this.period = period;
        }

        private void ToothForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void authorsButton_Click(object sender, EventArgs e)
        {
            AuthorsForm form = new AuthorsForm();
            form.Show();
        }

        private void s36Button_Click(object sender, EventArgs e)
        {
            MyDelegate myDelegate;
            if (isMan)
            {
                if (period == 1)
                {
                    myDelegate = new MyDelegate(Data.Man_firstPeriod_size36);
                }
                else
                {
                    myDelegate = new MyDelegate(Data.Man_secondPeriod_size36);
                }
            }
            else
            {
                if (period == 1)
                {
                    myDelegate = new MyDelegate(Data.Female_firstPeriod_size36);
                }
                else
                {
                    myDelegate = new MyDelegate(Data.Female_secondPeriod_size36);
                }
            }
            ShowData form = new ShowData(isMan, period, 36, myDelegate);
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void s35Button_Click(object sender, EventArgs e)
        {
            MyDelegate myDelegate;
            if(isMan)
            {
                if(period == 1)
                {
                    myDelegate = new MyDelegate(Data.Man_firstPeriod_size35);
                }
                else
                {
                    myDelegate = new MyDelegate(Data.Man_secondPeriod_size35);
                }
            }
            else
            {
                if (period == 1)
                {
                    myDelegate = new MyDelegate(Data.Female_firstPeriod_size35);
                }
                else 
                {
                    myDelegate = new MyDelegate(Data.Female_secondPeriod_size35);
                }
            }
            ShowData form = new ShowData(isMan, period, 35, myDelegate);
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void s37Button_Click(object sender, EventArgs e)
        {
            MyDelegate myDelegate;
            if (isMan)
            {
                if (period == 1)
                {
                    myDelegate = new MyDelegate(Data.Man_firstPeriod_size37);
                }
                else
                {
                    myDelegate = new MyDelegate(Data.Man_secondPeriod_size37);
                }
            }
            else
            {
                if (period == 1)
                {
                    myDelegate = new MyDelegate(Data.Female_firstPeriod_size37);
                }
                else
                {
                    myDelegate = new MyDelegate(Data.Female_secondPeriod_size37);
                }
            }
            ShowData form = new ShowData(isMan, period, 37, myDelegate);
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void s38Button_Click(object sender, EventArgs e)
        {
            MyDelegate myDelegate;
            if (isMan)
            {
                if (period == 1)
                {
                    myDelegate = new MyDelegate(Data.Man_firstPeriod_size38);
                }
                else
                {
                    myDelegate = new MyDelegate(Data.Man_secondPeriod_size38);
                }
            }
            else
            {
                if (period == 1)
                {
                    myDelegate = new MyDelegate(Data.Female_firstPeriod_size38);
                }
                else
                {
                    myDelegate = new MyDelegate(Data.Female_secondPeriod_size38);
                }
            }
            ShowData form = new ShowData(isMan, period, 38, myDelegate);
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void s45Button_Click(object sender, EventArgs e)
        {
            MyDelegate myDelegate;
            if (isMan)
            {
                if (period == 1)
                {
                    myDelegate = new MyDelegate(Data.Man_firstPeriod_size45);
                }
                else
                {
                    myDelegate = new MyDelegate(Data.Man_secondPeriod_size45);
                }
            }
            else
            {
                if (period == 1)
                {
                    myDelegate = new MyDelegate(Data.Female_firstPeriod_size45);
                }
                else
                {
                    myDelegate = new MyDelegate(Data.Female_secondPeriod_size45);
                }
            }
            ShowData form = new ShowData(isMan, period, 45, myDelegate);
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void s46Button_Click(object sender, EventArgs e)
        {
            MyDelegate myDelegate;
            if (isMan)
            {
                if (period == 1)
                {
                    myDelegate = new MyDelegate(Data.Man_firstPeriod_size46);
                }
                else
                {
                    myDelegate = new MyDelegate(Data.Man_secondPeriod_size46);
                }
            }
            else
            {
                if (period == 1)
                {
                    myDelegate = new MyDelegate(Data.Female_firstPeriod_size46);
                }
                else
                {
                    myDelegate = new MyDelegate(Data.Female_secondPeriod_size46);
                }
            }
            ShowData form = new ShowData(isMan, period, 46, myDelegate);
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void s47Button_Click(object sender, EventArgs e)
        {
            MyDelegate myDelegate;
            if (isMan)
            {
                if (period == 1)
                {
                    myDelegate = new MyDelegate(Data.Man_firstPeriod_size47);
                }
                else
                {
                    myDelegate = new MyDelegate(Data.Man_secondPeriod_size47);
                }
            }
            else
            {
                if (period == 1)
                {
                    myDelegate = new MyDelegate(Data.Female_firstPeriod_size47);
                }
                else
                {
                    myDelegate = new MyDelegate(Data.Female_secondPeriod_size47);
                }
            }
            ShowData form = new ShowData(isMan, period, 47, myDelegate);
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void s48Button_Click(object sender, EventArgs e)
        {
            MyDelegate myDelegate;
            if (isMan)
            {
                if (period == 1)
                {
                    myDelegate = new MyDelegate(Data.Man_firstPeriod_size48);
                }
                else
                {
                    myDelegate = new MyDelegate(Data.Man_secondPeriod_size48);
                }
            }
            else
            {
                if (period == 1)
                {
                    myDelegate = new MyDelegate(Data.Female_firstPeriod_size48);
                }
                else
                {
                    myDelegate = new MyDelegate(Data.Female_secondPeriod_size48);
                }
            }
            ShowData form = new ShowData(isMan, period, 48, myDelegate);
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
        Point lastPoint;
        private void ToothForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void ToothForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}

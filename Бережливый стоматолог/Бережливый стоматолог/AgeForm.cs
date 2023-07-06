using System;
using System.Drawing;
using System.Windows.Forms;

namespace Бережливый_стоматолог
{
    public partial class AgeForm : Form
    {
        bool IsMan;
        public AgeForm(bool isMan)
        {
            InitializeComponent();
            IsMan = isMan;

            if (!isMan) 
            {
                firstButton.Text += "(21 - 35 лет)";
                secondButton.Text += "(36 - 55 лет)";
            }
            else
            {
                firstButton.Text += "(22 - 35 лет)";
                secondButton.Text += "(36 - 60 лет)";
            }
        }
        Point lastPoint;
        private void AgeForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void AgeForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void authorsButton_Click(object sender, EventArgs e)
        {
            AuthorsForm form = new AuthorsForm();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void firstButton_Click(object sender, EventArgs e)
        {
            ToothForm form = new ToothForm(IsMan, 1);
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void secondButton_Click(object sender, EventArgs e)
        {
            ToothForm form = new ToothForm(IsMan, 2);
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}

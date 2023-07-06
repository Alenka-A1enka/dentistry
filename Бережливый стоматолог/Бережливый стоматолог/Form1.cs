using System;
using System.Drawing;
using System.Windows.Forms;

namespace Бережливый_стоматолог
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Point lastPoint;

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            authorsButton.BackColor = Color.FromArgb(215, 215, 215);
        }

        private void authorsButton_MouseLeave(object sender, EventArgs e)
        {
            authorsButton.BackColor = Color.FromArgb(240, 240, 240);
        }

        private void button1_MouseEnter_1(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(255, 0, 0);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(213, 40, 40);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void authorsButton_Click(object sender, EventArgs e)
        {
            AuthorsForm form = new AuthorsForm();
            form.Show();
        }

        private void menButton_Click(object sender, EventArgs e)
        {
            AgeForm form = new AgeForm(true);
            this.Hide();
            form.ShowDialog();
            try
            {
                this.Show();
            }
            catch { }
        }

        private void femaleButton_Click(object sender, EventArgs e)
        {
            AgeForm form = new AgeForm(false);
            this.Hide();
            form.ShowDialog();
            try
            {
                this.Show();
            }
            catch { }
        }
    }
}

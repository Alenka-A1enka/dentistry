using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Бережливый_стоматолог
{
    public partial class ShowData : Form
    {
        bool isMan;
        uint period;
        uint tooth_numb;
        MyDelegate myDelegate;
        public ShowData(bool isMan, uint period, uint tooth_numb, MyDelegate mydel)
        {
            InitializeComponent();

            this.isMan = isMan;
            this.period = period;
            this.tooth_numb = tooth_numb;
            myDelegate = mydel;

            this.Text = "Зуб " + (tooth_numb - tooth_numb %  10) / 10 + "." + tooth_numb % 10;
        }

        private void ShowData_Load(object sender, EventArgs e)
        {
            //label9-23
            Stack<Label> labels = new Stack<Label>();
            labels.Push(label23);
            labels.Push(label22);
            labels.Push(label21);
            labels.Push(label20);
            labels.Push(label19);
            labels.Push(label18);
            labels.Push(label17);
            labels.Push(label16);
            labels.Push(label15);
            labels.Push(label14);
            labels.Push(label13);
            labels.Push(label12);
            labels.Push(label11);
            labels.Push(label10);
            labels.Push(label9);
            string[,] data = myDelegate.Invoke();
            for(int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Label label = labels.Pop();
                    label.Text = data[i, j];
                }
            }
        }
    }
}

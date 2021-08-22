using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int choice = 0;
        int x = 250;
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            choice = int.Parse(textBox1.Text);/*
            switch (x)
            {
                case 1: //blå
                    choice = 1;
                    break;
                case 2: //gul
                    Console.WriteLine("Alternativ 2 är också bra!");
                    break;
                case 3: //grön
                    Console.WriteLine("Du matade in alternativ 1");
                    break;
                case 4: //röd
                    Console.WriteLine("Alternativ 2 är också bra!");
                    break;
                default:
                    Console.WriteLine("Du angav felaktigt alternativ");
                    break;
            }  */
            label1.Text = choice.ToString(); //Kollar om det fungerar
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            SolidBrush brush = new SolidBrush(Color.Blue);
            switch (choice)
            {
                case 1: //blå
                    brush = new SolidBrush(Color.Blue);
                    gr.FillEllipse(brush, x, 100, 40, 40);
                    break;
                case 2: //gul
                    brush = new SolidBrush(Color.Yellow);
                    gr.FillEllipse(brush, x, 100, 40, 40);
                    break;
                case 3: //grön
                    brush = new SolidBrush(Color.Green);
                    gr.FillEllipse(brush, x, 100, 40, 40);
                    break;
                case 4: //röd
                    brush = new SolidBrush(Color.Red);
                    gr.FillEllipse(brush, x, 100, 40, 40);
                    break;
                default:
                    break;
            }
        }
        //left
        private void button2_Click(object sender, EventArgs e)
        {
            x -= 10;
            Invalidate();
        }
        //right
        private void button3_Click(object sender, EventArgs e)
        {
            x += 10;
            Invalidate();
        }
    }
}

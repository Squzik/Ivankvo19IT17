using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cal
{
    public partial class IVANKOV19IT17 : Form
    {
        public int a, b;
        public int temp;




        public IVANKOV19IT17()
        {
            InitializeComponent();
        }

        private void minus(object sender, EventArgs e)//Кнопка -
        {
           
                a = int.Parse(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
                temp = 1;
            
          
        }

        private void plus(object sender, EventArgs e)//Кнопка +
        {
            a = int.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            temp = 2;

        }

        private void ymnoj(object sender, EventArgs e)// Кнопка *
        {
            a = int.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            temp = 3;

        }

        private void del(object sender, EventArgs e)// Кнопка /
        {
            a = int.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            temp = 4;


        }



        private void clear(object sender, EventArgs e)// Очистка
        {
            textBox1.Clear();
            a = 0;
            b = 0;
        }


        private void summary(object sender, EventArgs e)// Кнопка =
        {
            cal(temp);
          
        }

      

        private void a1(object sender, EventArgs e)
        {
            textBox1.Text = "1";
        }

        private void a2(object sender, EventArgs e)
        {
            textBox1.Text = "2";
        }

        private void a3(object sender, EventArgs e)
        {
            textBox1.Text = "3";
        }

        private void a4(object sender, EventArgs e)
        {
            textBox1.Text = "4";
        }

        private void a5(object sender, EventArgs e)
        {
            textBox1.Text = "5";
        }

        private void a6(object sender, EventArgs e)
        {
            textBox1.Text = "6";
        }

        private void a7(object sender, EventArgs e)
        {
            textBox1.Text = "7";
        }

        private void a8(object sender, EventArgs e)
        {
            textBox1.Text = "8";
        }

        private void a9(object sender, EventArgs e)
        {
            textBox1.Text = "9";
        }

        private void a0(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        public void cal(int temp)// Кнопка =
        {
            switch(temp)
            {
                case 1:
                    b = a - int.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 2:
                    b = a + int.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 3:
                    b = a * int.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 4:
                    b = a / int.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                default:
                    break;
            }
        }


    }
}

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
        int a, b;
        int temp;




        public IVANKOV19IT17()
        {
            InitializeComponent();
        }

        private void minus(object sender, EventArgs e)
        {
           
                a = int.Parse(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
                temp = 1;
            
          
        }

        private void plus(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            temp = 2;

        }

        private void ymnoj(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            temp = 3;

        }

        private void del(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            temp = 4;


        }



        private void clear(object sender, EventArgs e)
        {
            textBox1.Clear();

        }


        private void rovno(object sender, EventArgs e)
        {
            cal(temp);
          
        }
        public void cal(int temp)
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

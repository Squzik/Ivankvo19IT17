﻿using System;
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
        public double a, b;
        public int temp;




        public IVANKOV19IT17()
        {
            InitializeComponent();
        }

        private void minus(object sender, EventArgs e)//Кнопка -
        {

                
                a = int.Parse(textBox1.Text);
                label2.Text = $"{a}-";
                textBox1.Clear();
                textBox1.Focus();
                temp = 1;
            
          
        }

        private void plus(object sender, EventArgs e)//Кнопка +
        {
            
            a = int.Parse(textBox1.Text);
            label2.Text = $"{a}+";
            textBox1.Clear();
            textBox1.Focus();
            temp = 2;

        }

        private void ymnoj(object sender, EventArgs e)// Кнопка *
        {
            
            a = int.Parse(textBox1.Text);
            label2.Text = $"{a}*";
            textBox1.Clear();
            textBox1.Focus();
            temp = 3;

        }

        private void del(object sender, EventArgs e)// Кнопка /
        {
            
            a = int.Parse(textBox1.Text);
            label2.Text = $"{a}/";
            textBox1.Clear();
            textBox1.Focus();
            temp = 4;


        }



        private void clear(object sender, EventArgs e)// Очистка
        {
            textBox1.Clear();
            a = 0;
            b = 0;
            label2.Text = "0";
        }


        private void summary(object sender, EventArgs e)// Кнопка =
        {
            cal(temp);
          
        }

      

        private void a1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
            
        }

        private void a2(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void a3(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void a4(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void a5(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text +  "5";
        }

        private void a6(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void a7(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void a8(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void a9(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9" ;
        }

        private void a0(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }


 

       
        private void Ctg_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox2.Text);
            label3.Text = $"ctg:{a}";
            textBox2.Clear();
            temp = 8;
        }
        private void Tg_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox2.Text);
            label3.Text = $"tg:{a}";
            textBox2.Clear();
            temp = 7;
        }
        private void Sin_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox2.Text);
            label3.Text = $"sin:{a}";
            textBox2.Clear();
            temp = 6;
        }
        private void Cos_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox2.Text);
            label3.Text = $"cos:{a}";
            textBox2.Clear();
            temp = 5;
        }
        private void minus2_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox2.Text);
            label3.Text = $"{a}-";
            textBox2.Clear();
            textBox2.Focus();
            temp = 9;
        }
        private void plus2_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox2.Text);
            label3.Text = $"{a}+";
            textBox2.Clear();
            textBox2.Focus();
            temp = 10;
        }
        private void ymnoj2_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox2.Text);
            label3.Text = $"{a}*";
            textBox2.Clear();
            textBox2.Focus();
            temp = 11;
        }


        private void del2_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox2.Text);
            label3.Text = $"{a}/";
            textBox2.Clear();
            textBox2.Focus();
            temp = 12;
        }

        private void clear2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            a = 0;
            b = 0;
            label3.Text = "0";
        }

        private void summary2_Click(object sender, EventArgs e)
        {
            cal(temp);
        }
        private void b0_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "0";
        }
        private void b1_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "1";
        }
        private void b2_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "2";
        }
        private void b3_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "3";

        }      
        private void b4_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "4";

        } 
        private void b5_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "5";
        }
        private void b6_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "6";
        }
        private void b7_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "7";
        }
        private void b8_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "8";
        }
        private void b9_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "9";
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
                case 5:
                    b = Math.Cos(a);
                    textBox2.Text = b.ToString();
                    break;
                case 6:
                    b = Math.Sin(a);
                    textBox2.Text = b.ToString();
                    break;
                case 7:
                    b = Math.Tan(a);
                    textBox2.Text = b.ToString();
                    break;
                case 8:
                    b =  1/Math.Tan(a);
                    textBox2.Text = b.ToString();
                    break;
                case 9:
                    b = a - int.Parse(textBox2.Text);
                    textBox2.Text = b.ToString();
                    break;
                case 10:
                    b = a + int.Parse(textBox2.Text);
                    textBox2.Text = b.ToString();
                    break;
                case 11:
                    b = a * int.Parse(textBox2.Text);
                    textBox2.Text = b.ToString();
                    break;
                case 12:
                    b = a / int.Parse(textBox2.Text);
                    textBox2.Text = b.ToString();
                    break;
                default:
                    break;
            }
        }


    }
}

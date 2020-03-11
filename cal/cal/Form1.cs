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

      public int c;
        



        public IVANKOV19IT17()
        {
            InitializeComponent();
        }


        
        


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            label2.Text = $"{1}";


        }

        private void button1_Click(object sender, EventArgs e)
        {

            label2.Text = $"{0}";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = $"{2}";
        }

        private void button4_Click(object sender, EventArgs e)
        {

            label2.Text = $"{3}";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            label1.Text="0"; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            c = (Convert.ToInt32(label2.Text));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (c == 0)
            {
                label1.Text = (Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text)).ToString();
            }
            if (c == 1)
            {
                label1.Text = (Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text)).ToString();
            }
            if (c == 2)
            {
                label1.Text = (Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text)).ToString();
            }
            if (c == 3)
            {
                label1.Text = (Convert.ToInt32(textBox1.Text) / Convert.ToInt32(textBox2.Text)).ToString();
            }
        }
    }
}

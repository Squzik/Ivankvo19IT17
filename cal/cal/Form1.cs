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
            
        private void minus(object sender, EventArgs e)
        {

            label2.Text = "-";
            c = 1;


        }

        private void plus(object sender, EventArgs e)
        {

            label2.Text = "+";
            c = 2;
        }

        private void ymnoj(object sender, EventArgs e)
        {
            label2.Text = "*";
            c = 3;
        }

        private void del(object sender, EventArgs e)
        {

            label2.Text = "/";
            c = 4;

        }



        private void clear(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label1.Text = "0";
            label2.Text = "0";
        }


        private void rovno(object sender, EventArgs e)
        {
           
            if (c == 1)
            {
                label1.Text = (Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text)).ToString();
            }
            if (c == 2)
            {
                label1.Text = (Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text)).ToString();
            }
            if (c == 3)
            {
                label1.Text = (Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text)).ToString();
            }
            if (c == 4)
            {
                label1.Text = (Convert.ToInt32(textBox1.Text) / Convert.ToInt32(textBox2.Text)).ToString();
            }
        }

     
    }
}

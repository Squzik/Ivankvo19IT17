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
        public double a, b,c;
        public int temp;

        public void obrabotka(string textBox1)
        {
            try
            {
                int i = Convert.ToInt32(textBox1);
                textBox1 = Convert.ToString(i);
            }
            catch (FormatException)
            {
               
                MessageBox.Show("Введено нечисловое значение!", "Ошибка");// исключение на ввод букв
            }
        }


        public IVANKOV19IT17()
        {
            InitializeComponent();
        }

        private void minus(object sender, EventArgs e)//Кнопка -
        {
            obrabotka(textBox1.Text);
            a = Convert.ToInt32(textBox1.Text);
                
                textBox1.Clear();
                textBox1.Focus();
                temp = 1;
     
                label2.Text = $"{a}-";
               
        }
        //llll
        private void plus(object sender, EventArgs e)//Кнопка +
        {
            obrabotka(textBox1.Text);
            a = Convert.ToInt32(textBox1.Text);
               
                textBox1.Clear();
                textBox1.Focus();
                temp = 2;            
                label2.Text = $"{a}+";

            
        }

        private void ymnoj(object sender, EventArgs e)// Кнопка *
        {

            obrabotka(textBox1.Text);
            a = Convert.ToInt32(textBox1.Text);
           
                textBox1.Clear();
                textBox1.Focus();
                temp = 3;
           
           
                label2.Text = $"{a}*";
          

        }

        private void del(object sender, EventArgs e)// Кнопка /
        {
            obrabotka(textBox1.Text);
            a = Convert.ToInt32(textBox1.Text);
                
                textBox1.Clear();
                textBox1.Focus();
                temp = 4;
          
           
                label2.Text = $"{a}/";
            


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

            obrabotka(textBox1.Text);

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


            obrabotka(textBox1.Text);
            a = Convert.ToInt32(textBox1.Text);
                label2.Text = $"ctg:{a}";
                textBox1.Clear();
                temp = 8;
          
           
                label2.Text = $"ctg:{a}";
            
        }
        private void Tg_Click(object sender, EventArgs e)
        {

            obrabotka(textBox1.Text);
            a = Convert.ToInt32(textBox1.Text);
              
                textBox1.Clear();
                temp = 7;
                
            
           
                label2.Text = $"tg:{a}";
           
        }
        private void Sin_Click(object sender, EventArgs e)
        {
            obrabotka(textBox1.Text);

            a = Convert.ToInt32(textBox1.Text);
           
                textBox1.Clear();
                temp = 6;
           
               
            
                label2.Text = $"sin:{a}";
            
        }
        private void Cos_Click(object sender, EventArgs e)
        {
            obrabotka(textBox1.Text);
            a = Convert.ToInt32(textBox1.Text); 
                textBox1.Clear();
                temp = 5;
           
           
                label2.Text = $"cos:{a}";
            
        }
     
  
   


        private void sqrt_Click(object sender, EventArgs e)
        {
            obrabotka(textBox1.Text);

            a = Convert.ToInt32(textBox1.Text);
                textBox1.Clear();
                temp = 13;
           
                label2.Text = $"√:{a}";
           

        }

        private void x2_Click(object sender, EventArgs e)
        {
            obrabotka(textBox1.Text);
            a = Convert.ToInt32(textBox1.Text);
                textBox1.Clear();
                temp = 15;
           
                label2.Text = $"x^2:{a}";
            
        }

   
     
        

     
        private void bin_CheckedChanged(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(textBox1.Text);
            textBox1.Text = Convert.ToString(i, 2);

        }

        private void oct_CheckedChanged(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(textBox1.Text);
            textBox1.Text = Convert.ToString(i, 8);
        }

        private void hex_CheckedChanged(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(textBox1.Text);
            textBox1.Text = Convert.ToString(i, 16);
        }

        private void dex_CheckedChanged(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(textBox1.Text);
            textBox1.Text = Convert.ToString(i, 10);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            string a = textBox2.Text.Length.ToString();
            label3.Text = $"Длина строки:{a}";
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            string a = textBox2.Text.ToUpper().ToString();
            textBox3.Text = a;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            string a = textBox2.Text.ToLower().ToString();
            textBox3.Text = a;
        }

        private void stats_CheckedChanged(object sender, EventArgs e)
        {
            int count = 0;
            //Подсчет цифр
            foreach (char ch in textBox2.Text)
            {
                if (Char.IsDigit(ch))
                    count++;
            }
            //Подсчет гласных и согласных
            string glasn = "уеыаоэяиёюУЕЫАОЭЯИЁЮ";
            string soglasn = "цкнгшщзхфвпрлджчсмтбЦКНГШЩЗХФВПРЛДЖЧСМТБ";
            int i=0, j=0; 
            //подсчитываем общее количество гласных и согласных 
            textBox2.Text.ToCharArray().All(z => {
                if (glasn.ToCharArray().Contains(z)) i++;
                else if
            (soglasn.ToCharArray().Contains(z)) j++; return true;});
            //Вывод
            MessageBox.Show
                ($"Сколько строк:{((string[])textBox2.Lines).Length.ToString()} \n" +
                $"Сколько слов:{ textBox2.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length } \n" +
                $"Сколько цифр:{count}\n" +
                $"Гласных: {i}\n" +
                $"Согласных: {j}", "Статистика:");

            

        }

        private void log_Click(object sender, EventArgs e)
        {
           
                a = Convert.ToInt32(textBox1.Text); 
                textBox1.Clear();
                temp = 14;
          
           
                label2.Text = $"log:{a}";
            
        }

        public void cal(int temp)// Кнопка =
        {
            
            switch(temp)
            {   
                case 1:
                    b = a - Convert.ToInt32(textBox1.Text);
                textBox1.Text = b.ToString();
                break;
                case 2:
                    b = a + Convert.ToInt32(textBox1.Text);
                textBox1.Text = b.ToString();
                break;
                case 3:
                    b = a * Convert.ToInt32(textBox1.Text);
                textBox1.Text = b.ToString();
                break;
                case 4:
                   b = a / Convert.ToInt32(textBox1.Text);
                textBox1.Text = b.ToString();
                break;
                case 5:
                    b = Math.Cos(a);
                textBox1.Text = b.ToString();
                break;
                case 6:
                    b = Math.Sin(a);
                textBox1.Text = b.ToString();
                break;
                case 7:
                    b = Math.Tan(a);
                textBox1.Text = b.ToString();
                break;
                case 8:
                    b = 1 / Math.Tan(a);
                textBox1.Text = b.ToString();
                break;
                case 13:
                    b = Math.Sqrt(a);
                textBox1.Text = b.ToString();
                break;
                case 14:
                    b = Math.Log(a);
                textBox1.Text = b.ToString();
                break;
                case 15:
                    b = Math.Pow(a, 2);
                textBox1.Text = b.ToString();
                break;
                default:
                    break;
            
        }
        }


    }
}

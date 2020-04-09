using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace cal
{



 
    public partial class IVANKOV19IT17 : Form
    {
        public double a, b, c;
        public int reg;
        public int temp;
        public int count;
        string[] rum = new string[6] { "46-48", "48-50", "50-52", "52-54", "54-56", "56-58" };
        string[] mejm = new string[6] { "S" ,   "M" ,  "L"  , "XL"  ,"XXL" ,"XXXL" };
        string[] usam = new string[6] { "36-38"  ,  "38-40"  , "40-42" ,  "42-44"  , "44-46" ,  "46-48" };
        string[] enm = new string[6] { "46-48", "48-50", "50-52", "52-54", "54-56", "56-58" };
        string[] enj = new string[10] { "34", "36", "38", "40", "42", "44", "46", "48", "50", "52" };
        string[] usaj = new string[10] { "6"  , "8" ,  "10" ,"12" , "14",  "16"  ,"18" , "20" , "22" , "24" };
        string[] ruj = new string[10] { "40", "42", "44", "46", "48", "50", "52", "54", "56", "58" };
        string[] mejj = new string[10] {"XS", "XS",  "S",  "M",  "M" , "L" ,"XL" ,"XL" ,"XXL" ,"XXXL"};
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
        public void obrabotka2()//Исправление ошибок
        {
            textBox3.Text = textBox2.Text.Replace("жы", "жи");
            textBox3.Text = textBox2.Text.Replace("шы", "ши");


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
            textBox1.Text = textBox1.Text + "5";
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
            textBox1.Text = textBox1.Text + "9";
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

      

        private void textBox2_TextChanged(object sender, EventArgs e)// подсчет длины строки
        {

            string a = textBox2.Text.Length.ToString();
            label3.Text = $"Длина строки:{a}";
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)// кнопка преобразование в заглавные
        {
            string a = textBox2.Text.ToUpper().ToString();
            textBox3.Text = a;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)// кнопка преобразование в строчные
        {
            string a = textBox2.Text.ToLower().ToString();
            textBox3.Text = a;
        }

        private void stats_CheckedChanged(object sender, EventArgs e)// Кнопка статистки
        {

            count = 0;

            //Подсчет цифр
            foreach (char ch in textBox2.Text)
            {
                if (Char.IsDigit(ch))
                    count++;
            }

            //Подсчет гласных и согласных
            string glasn = "уеыаоэяиёюУЕЫАОЭЯИЁЮ";
            string soglasn = "цкнгшщзхфвпрлджчсмтбЦКНГШЩЗХФВПРЛДЖЧСМТБ";
            int i = 0, j = 0;


            //подсчитываем общее количество гласных и согласных 
            textBox2.Text.ToCharArray().All(z => {
                if (glasn.ToCharArray().Contains(z)) i++;
                else if
            (soglasn.ToCharArray().Contains(z)) j++; return true; });

            //Вывод
            MessageBox.Show
                ($"Сколько строк:{((string[])textBox2.Lines).Length.ToString()} \n" +
                $"Сколько слов:{ textBox2.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length } \n" +
                $"Сколько цифр:{count}\n" +
                $"Сколько гласных: {i}\n" +
                $"Сколько согласных: {j}", "Статистика:");



        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)// кнопка преобразование строки
        {
            textBox3.Text = textBox2.Text.Replace(" ", "!");

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)// кнопка исправление ошибок
        {
            obrabotka2();


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (comboBox1.Text == "М")
            {
                comboBox3.Items.Clear();
                comboBox2.Items.Clear();
                comboBox2.Items.AddRange(new string[] { "Российские размеры"/* В БУДУЩЕМ, "Европейские размеры", "Международные размеры", "Размеры США"*/ });
            


            }
            if (comboBox1.Text == "Ж")
            {
                comboBox2.Items.Clear();
                comboBox3.Items.Clear();
                comboBox2.Items.AddRange(new string[] { "Российские размеры"/*В БУДУЩЕМ, "Европейские размеры", "Международные размеры", "Размеры США"*/ });

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text == "М")
            if (comboBox2.SelectedIndex == 0)
            {
                comboBox3.Items.Clear();
                comboBox3.Items.AddRange(rum);
            }
            if(comboBox1.Text == "Ж")
            if (comboBox2.SelectedIndex == 0)
            {
                comboBox3.Items.Clear();
                comboBox3.Items.AddRange(ruj);
            }

            
        }

    
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Жен
            if (comboBox1.Text == "Ж")
            if (comboBox3.SelectedIndex == 0)
            {
                label7.Text = $"Международные размеры : {mejj[0]}\n" +
                    $"Размеры США : {usaj[0]}\n" +
                    $"Европейские размеры : {enj[0]}";
            }
            if (comboBox3.SelectedIndex == 1)
            {
                label7.Text = $"Международные размеры : {mejj[1]}\n" +
                      $"Размеры США : {usaj[1]}\n" +
                      $"Европейские размеры : {enj[1]}";
            }
            if (comboBox3.SelectedIndex == 2)
            {
                label7.Text = $"Международные размеры : {mejj[2]}\n" +
                    $"Размеры США : {usaj[2]}\n" +
                    $"Европейские размеры : {enj[2]}";
            }
            if (comboBox3.SelectedIndex == 3)
            {
                label7.Text = $"Международные размеры : {mejj[3]}\n" +
                     $"Размеры США : {usaj[3]}\n" +
                     $"Европейские размеры : {enj[3]}";
            }
            if (comboBox3.SelectedIndex == 4)
            {
                label7.Text = $"Международные размеры : {mejj[4]}\n" +
                    $"Размеры США : {usaj[4]}\n" +
                    $"Европейские размеры : {enj[4]}";
            }
            if (comboBox3.SelectedIndex == 5)
            {
                label7.Text = $"Международные размеры : {mejj[5]}\n" +
                     $"Размеры США : {usaj[5]}\n" +
                     $"Европейские размеры : {enj[5]}";
            }
            if (comboBox3.SelectedIndex == 6)
            {
                label7.Text = $"Международные размеры : {mejj[6]}\n" +
                    $"Размеры США : {usaj[6]}\n" +
                    $"Европейские размеры : {enj[6]}";
            }
            if (comboBox3.SelectedIndex == 7)
            {
                label7.Text = $"Международные размеры : {mejj[7]}\n" +
                   $"Размеры США : {usaj[7]}\n" +
                   $"Европейские размеры : {enj[7]}";
            }
            if (comboBox3.SelectedIndex == 8)
            {
                label7.Text = $"Международные размеры : {mejj[8]}\n" +
                    $"Размеры США : {usaj[8]}\n" +
                    $"Европейские размеры : {enj[8]}";
            }
            if (comboBox3.SelectedIndex == 9)
            {
                label7.Text = $"Международные размеры : {mejj[9]}\n" +
                     $"Размеры США : {usaj[9]}\n" +
                     $"Европейские размеры : {enj[9]}";     
            }
            //Муж
            if (comboBox1.Text == "М")
            if (comboBox3.SelectedIndex == 0)
            {
                label7.Text = $"Международные размеры : {mejm[0]}\n" +
                    $"Размеры США : {usam[0]}\n" +
                    $"Европейские размеры : {enm[0]}";
            }
            if (comboBox3.SelectedIndex == 1)
            {
                label7.Text = $"Международные размеры : {mejm[1]}\n" +
                      $"Размеры США : {usam[1]}\n" +
                      $"Европейские размеры : {enm[1]}";
            }
            if (comboBox3.SelectedIndex == 2)
            {
                label7.Text = $"Международные размеры : {mejm[2]}\n" +
                    $"Размеры США : {usam[2]}\n" +
                    $"Европейские размеры : {enm[2]}";
            }
            if (comboBox3.SelectedIndex == 3)
            {
                label7.Text = $"Международные размеры : {mejm[3]}\n" +
                     $"Размеры США : {usam[3]}\n" +
                     $"Европейские размеры : {enm[3]}";
            }
            if (comboBox3.SelectedIndex == 4)
            {
                label7.Text = $"Международные размеры : {mejm[4]}\n" +
                    $"Размеры США : {usam[4]}\n" +
                    $"Европейские размеры : {enm[4]}";
            }
            if (comboBox3.SelectedIndex == 5)
            {
                label7.Text = $"Международные размеры : {mejm[5]}\n" +
                     $"Размеры США : {usam[5]}\n" +
                     $"Европейские размеры : {enm[5]}";
            }
            if (comboBox3.SelectedIndex == 6)
            {
                label7.Text = $"Международные размеры : {mejm[6]}\n" +
                    $"Размеры США : {usam[6]}\n" +
                    $"Европейские размеры : {enm[6]}";
            }
            if (comboBox3.SelectedIndex == 7)
            {
                label7.Text = $"Международные размеры : {mejm[7]}\n" +
                   $"Размеры США : {usam[7]}\n" +
                   $"Европейские размеры : {enm[7]}";
            }
            if (comboBox3.SelectedIndex == 8)
            {
                label7.Text = $"Международные размеры : {mejm[8]}\n" +
                    $"Размеры США : {usam[8]}\n" +
                    $"Европейские размеры : {enm[8]}";
            }
            if (comboBox3.SelectedIndex == 9)
            {
                label7.Text = $"Международные размеры : {mejm[9]}\n" +
                     $"Размеры США : {usam[9]}\n" +
                     $"Европейские размеры : {enm[9]}";
            }

        }

        private void label7_Click(object sender, EventArgs e)
        {

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

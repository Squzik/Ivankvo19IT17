<<<<<<< HEAD
﻿using System;

namespace ConsoleApp1
{
	class Program
	{
		/*Задание:
		R минимально, R кратно 21 ,если такого числа нет вывести - 1*/
		static void Main(string[] args)
		{

			{
				
				Random rand = new Random(); //рандома
				int[] massive = new int[1000]; //массива
				for (int i = 0; i < 100; i++) //цикл от 0 до 10000 заполнен рандомными числами
				{
					massive[i] = rand.Next(0, 1000);
					Console.WriteLine(massive[i]);
				}
				int R = massive[0];
				Console.WriteLine("Минимальное число: ");
				for (int i = 0; i < massive.Length; i++) //поиск минимально массива и присвоение его R
				{
					if (massive[i] < R) { R = massive[i]; }
					
				}
				Console.WriteLine(R);
				Console.WriteLine("Условие: ");
				/* проверка на условие если R кратно 21 и является произведением двух случайных чисел массива) 
				если подходит, выводится R, если нет, выводится -1 */
				int a = massive[new Random().Next(0, massive.Length)];
				int b = massive[new Random().Next(0, massive.Length)];

				int c = a * b;
				if ((R % 21 == 0) && (R == c && (a - b <= 8 || b - a <= 8)))
				{
					Console.WriteLine(R);
				}
				else 
				{ 
					Console.WriteLine("-1"); 
				}

			}



		}
	}
}
=======
﻿using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввведите сколько элементов в массиве:");
            int n = int.Parse(Console.ReadLine());
            int[] mass = new int[n];
            var rand = new Random();
            //задаем рандом массиву
            for (var i = 0; i < mass.Length; i++)
                mass[i] = rand.Next(50);
            Console.Write("Изначальный массив: ");
            for (var i = 0; i < mass.Length; i++)
            {
                Console.Write("{0} ", mass[i]);
            }
            int max = mass[0];
            //Ищем максимум значение массива
            for (int i = 0; i < mass.Length; i++)
            {
                if (max < mass[i])
                {
                    max = mass[i];
                }
            }
            //Ищем индекс этого значения
            int index_max = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] == max)
                {
                    index_max = i;
                }
            }
            //Меняем местами
            int temp = mass[0];
            mass[index_max] = temp;
            mass[0] = max;
            Console.Write($";Максимум: {max};");
            for (var i = 0; i < mass.Length; i++)
            {
                Console.Write("{0} ", mass[i]);
            }
            Console.Write(";Сортировка по возрастанию: ");
            Array.Sort(mass);
            for (var i = 0; i < mass.Length; i++)
            {
                Console.Write("{0} ", mass[i]);
            }

            Console.Write("; Сортировка по убыванию:");
            Array.Reverse(mass);
            for (var i = 0; i < mass.Length; i++)
            {
                Console.Write("{0} ", mass[i]);
            }
            Console.ReadLine();

        }
    }
}


>>>>>>> 88baf6a7ddf8b65845cf8f1bd430599ec4485baf

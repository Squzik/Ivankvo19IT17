using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {   //Ввод с клавиатуры 
            Console.WriteLine("Ввведите сколько элементов в массиве:");
            int n = int.Parse(Console.ReadLine());
            int[] mass = new int[n];
            var rand = new Random();
            //Задаем рандом массиву
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
            //Вывод максимума
            Console.Write($";Максимум: {max};");
            for (var i = 0; i < mass.Length; i++)
            {
                Console.Write("{0} ", mass[i]);
            }
            //Вывод сортировки
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



using System;

namespace ConsoleApp4
{
    class QuickSorting
    {
        public static void sorting(double[] mass, long first, long last)
        {
            //Быстрая сортировка
            double p = mass[(last - first) / 2 + first];
            double temp;
            long i = first, j = last;
            while (i <= j)
            {
                while (mass[i] < p && i <= last) ++i;
                while (mass[j] > p && j >= first) --j;
                if (i <= j)
                {
                    temp = mass[i];
                    mass[i] = mass[j];
                    mass[j] = temp;
                    ++i; --j;
                }
            }
            if (j > first) sorting(mass, first, j);
            if (i < last) sorting(mass, i, last);
        }
    }
    class test
    {
        static void Main(string[] args)
        {
            //Ввод с клавиатуры
            Console.WriteLine("Ввведите сколько элементов в массиве:");
            int n = int.Parse(Console.ReadLine());
            double[] mass = new double[n];
            var rand = new Random();
            //Задаем рандом массиву
            for (var i = 0; i < mass.Length; i++)
                mass[i] = rand.Next(50);
            double max = mass[0];
            //Ищем максимум значение массива
            for (int i = 0; i < mass.Length; i++)
            {
                if (max < mass[i])
                {
                    max = mass[i];
                }
            }
            //Вывод изначального массива
            Console.WriteLine("Сгенерированный массив:");
            foreach (double x in mass)
            {
                Console.Write(x + " ");
            }
            //Вывод отсортированного массива
            QuickSorting.sorting(mass, 0, mass.Length - 1);
            Console.WriteLine("\nОтсортированный массив:");
            foreach (double x in mass)
            {
                Console.Write(x + " ");
            }
            Console.ReadLine();
        }
    }
}

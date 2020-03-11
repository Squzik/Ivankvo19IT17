using System;

namespace ConsoleApp12
{
	class Program
	{
		
		static void Main(string[] args)
		{

			{
                Console.WriteLine("Ввведите сколько элементов в массиве:");
				//Задаем массив
                int n = int.Parse(Console.ReadLine());
                int[] a = new int[n];
				//Переменная с рондомом 
                var rand = new Random();
				//Рондом чисел от 0 до 100
                for (var i = 0; i < n; i++)
                    a[i] = rand.Next(0,100);
				//Выводим изначальный массив
                Console.WriteLine("Изначальный массив:");
                for (var i = 0; i < a.Length; i++)
                {
					Console.Write($"[{i}]=");
					Console.WriteLine(a[i]);
                }          
				//Делаю сортировку по возрастанию
                Console.WriteLine("Сортировка по возрастанию: ");
                Array.Sort(a);
                for (var i = 0; i < a.Length; i++)
                {
					Console.Write($"[{i}]=");
					Console.WriteLine("{0} ", a[i]);
                }
				//Сортировка для вывода 1,2,3 места
				int v = a[0];
				int b = a[1];
				int c = a[2];
				for (int i = 3; i < n; i++)
				{
					if (a[i] >= v || a[i] >= b || a[i] >= c)
					{
						if (v <= b && v <= c)
						{
							v = a[i];
						}
						else
						{
							if (b <= c)
							{
								b = a[i];
							}
							else
							{
								c = a[i];
							}
						}
					}
				}
			//Выводим в консоли 3 первых места
				Console.Write($"3 первых места: 1-{v} 2-{c} 3-{b} ");	
				Console.ReadLine();
            }
        }
    }
}

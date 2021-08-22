using System;
using System.Linq;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Введите количество элементов:\t");
            int Count = int.Parse(Console.ReadLine()); //Вводим кол-во элементов в массиве

            int[] arr = new int[Count];//Создание массива

            for (int i = 0; i < arr.Length; i++)//Заполнение массива
            {
                Console.Write($"Введите элемент массива под индексом {i}:\t");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write($"\nЭлементы массива которые кратные 3м:\t");

            for (int i = 0; i < arr.Length; i++)//Вывод элементов простым способом
            {
                if (arr[i]%3==0)
                {
                    Console.Write(arr[i] + "\t");
                }
            }

            Console.WriteLine("\n Количество элементов:\t" + arr.Where(i => i % 3 == 0).Count()); //их количество


            Console.ReadLine();
        }
    }
}

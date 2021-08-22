using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string temp,ans;//инициализация переменных
            bool res = true;


            do
            {
                Console.WriteLine("Введите имя на русском:");
                temp = Console.ReadLine();//ввод имени

                if (temp == "Вячеслав") // проверка на то что имя подходит
                {
                    Console.WriteLine("Привет! " + temp);
                    res = false;
                }
                else
                {
                    Console.WriteLine("Нет такого имени!");
                    Console.WriteLine("Хотите продолжить?");
                    ans = Console.ReadLine();
                    if(ans == "да")
                    {
                        continue;
                    }else
                    {
                        break;
                    }

                }

            } while (res);// цикл, пока не будет правильно введено имя или пользователь не захочет выйти.

            Console.ReadLine();
        }
    }
}

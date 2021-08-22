using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string temp;//временная переменная для записи числа
            int val;//переменная для записи числа
            bool result = false;//для проверки на правильность ввода
            do
            {
                Console.WriteLine("Введите число в диапазоне от 0 до 50:");
                temp = Console.ReadLine();//ввод числа
                int.TryParse(temp, out val);

                if (val > 0 & val < 50)//проверка на правильность записи числа
                {
                    result = true;
                }
                else
                {
                    Console.WriteLine("Неправильное число");
                }
            } while (result != true);//Цикл пока не будет правильно введено число

            if (val>7)// проверка на то, что введенное число больше 7
            {
                Console.WriteLine("Привет");
            }

            Console.ReadLine();
        }
    }
}

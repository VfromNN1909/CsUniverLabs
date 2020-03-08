using System;

namespace CsLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            // тут просто на каждом отрезке смотрим значения функции
            Console.Write("Введите значение аргумента от -8 до 10: ");
            double x = double.Parse(Console.ReadLine());
            double y = 0;
            if (x >= -8 && x <= -5)
            {
                y = -3;
            }
            else if(x > -5 && x <= -3)
            {
                y = x + 3;
            } 
            else if (x > -3 && x <= 3)
            {
                Console.Write("Введите радиус: ");
                double r = double.Parse(Console.ReadLine());
                y = Math.Sqrt(r * r - x * x);
            }
            else if (x > 3 && x <= 8)
            {
                y = x * 0.6 - 1.8;
            }
            else if(x > 8 && x <= 10)
            {
                y = 3;
            }
            else
            {
                Console.WriteLine("Введите значение аргумента от - 8 до 10!");
            }
            Console.WriteLine($"Значение функции = {y}");
            Console.ReadKey();
        }
    }
}

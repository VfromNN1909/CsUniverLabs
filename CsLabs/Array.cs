using System;
using System.Linq; // нужен для работы Select в функции ReadArray();

namespace CsLabs
{
    class Array
    {
       // функция удаляет числа из некоторого интервала
       // сдвигает массив и заполняет оставшуюся часть нулями
        static double[] CleanArray(double[] arr, double a, double b)
        {
            int end = arr.Length - 1; // конец массива
            // проходимся по массиву
            for (int i = 0; i <= end; i++)
                // если число в интервале
                if ((Math.Abs(arr[i]) >= a) && (Math.Abs(arr[i]) <= b))
                {
                    // тогда сдвигаем
                    for (int j = i; j < end; j++)
                    {
                        arr[j] = arr[j + 1];
                    }
                    // в конец добавляем ноль
                    arr[end] = 0; 
                    end--;
                    i--;
                }
            // возвращаем массив
            return arr;
        }
        // функция складывает элементы массива, до последнего положительного
        static double SumUntilLastPositive(double[] arr)
        {
            double sum = 0;
            int len = arr.Length - 1;
            // идем с конца, находим последний положительный
            while (arr[len] < 0)
                len--;
            //  и складываем до него
            for(int i = 0;i < len; i++)
            {
                sum += arr[i];
            }
            // возвращаем сумму
            return sum;
        }
        // читаем массив с клавиатуры
        static double[] ReadArray()
        {
            // возвращаем считанный с клавиатуры массив
            return Console.ReadLine().Split(' ').Select(num => double.Parse(num)).ToArray();
        }
        // печатаем массив
        static void printArray(double[] arr)
        {
            foreach(double element in arr)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
        // проверяем
        static void Main(string[] args)
        {
            Console.Write("Введите элементы массива через пробел : ");
            var arr = ReadArray();
            Console.Write("Введите a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите b: ");
            int b = int.Parse(Console.ReadLine());
            printArray(arr);
            var max = arr.Max();
            Console.WriteLine($"Max - {max}");
            var sum = SumUntilLastPositive(arr);
            Console.WriteLine($"Сумма до последнего позитивного - {sum}");
            var cleanArray = CleanArray(arr, a, b);
            printArray(cleanArray);
            Console.ReadKey();
        }
    }
}

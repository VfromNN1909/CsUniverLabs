using System;
using System.Collections.Generic;
using System.Text;

namespace CsLabs
{
    class TwoDimentionArray1
    {
        // функция для счета суммы элементов столбца без отрицательных элементов
        static void sumInColumnWithoutNegatives(int[,] arr, int size)
        {
            int sum = 0; // сумма
            int count = 0; // количество
            // проходимся по массиву
            for(int i = 0;i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    // если элемент отрицательный
                    if(arr[j, i] < 0)
                    {
                        // то прерываем итерацию цикла
                        break;
                    }
                    // складываем
                    sum += arr[j, i];
                    // выводим
                    if(j == size - 1)
                    {
                        Console.WriteLine($"Сумма элементов столбца {i + 1} = {sum}");
                        count++;
                    }
                }
                // обнуляем сумму для других столбцов
                sum = 0;
            }
            // если нужных столбцов нет,то выводим
            if(count == 0)
            {
                Console.WriteLine("Отсутствуют столбцы, соответствующие условию");
            }
        }
        // заполняем массив рандомными элементами
        static int[,] ReadArray(int size)
        {
            Random random = new Random();
            int[,] arr = new int[size, size];
            for(int i = 0;i < size; i++)
            {
                for(int j = 0;j < size; j++)
                {
                    arr[i, j] = random.Next(-5, 20);
                }
            }
            return arr;
        }
        // выводим массив
        static void PrintArray(int[,] arr, int size)
        {
            for(int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        // проверяем
        static void Main(string[] args)
        {
            Console.Write("Введите размер двумерного массива: ");
            int size = int.Parse(Console.ReadLine());
            int[,] arr = ReadArray(size);
            PrintArray(arr, size);
            sumInColumnWithoutNegatives(arr, size);
        }
    }
}

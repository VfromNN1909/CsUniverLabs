using System;
using System.IO;

namespace CsLabs
{
    class TwoDimentionArray2
    {
        static void Main(string[] args)
        {
            // путь к файлу
            string FilePath = @"C:\Users\DNS\source\repos\CsLabs\CsLabs\SomeWords.txt";
            // используем StreamReader для чтения из файла
            using (StreamReader sr = new StreamReader(FilePath))
            {
                // читать будем построчно
                string line; // собсно строка
                // если не дошли до конца
                while((line = sr.ReadLine()) != null)
                {
                    // то делим строку на слова
                    string[] words = line.Split(new char[] { ' ', ',', '.' });
                    // проходимся по ним
                    for(int i = 0;i < words.Length - 1; i += 2)
                    {
                        // и меняем местами
                        Console.Write(words[i + 1] + " " + words[i] + " ");
                    }
                    // на случай, если количество слов в строке нечетное
                    if(words.Length % 2 != 0)
                    {
                        // просто выводим в конце последнее слово
                        Console.WriteLine(words[words.Length - 1]);
                    }
                }
            }
        }
    }
}

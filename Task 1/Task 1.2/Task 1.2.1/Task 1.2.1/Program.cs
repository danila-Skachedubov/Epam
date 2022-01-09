using System.Text;
using System;

namespace Task_1._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string text = Replace_Punctuation(Console.ReadLine());
            // Replace_Punctuation(text);
            string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int summofsymb = 0;
            foreach (var word in words)
            {
                summofsymb += word.Length;
                Console.WriteLine($"{word}");
            }
            double averageQuantity = Math.Round(summofsymb / (double)words.Length, 0);//задание выполнено с округлением до целого числа
            Console.Write($"Среднее число символов в слове: { averageQuantity } ");
        }
        static string Replace_Punctuation(string text)
        {
            var str =new StringBuilder(text);
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsPunctuation(str[i]))
                {
                    //str.Remove(i, 1);
                    str.Replace(str[i], ' ');
                    i++;
                }
            }
            return str.ToString();
        }

    }
}
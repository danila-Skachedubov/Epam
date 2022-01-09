using System;
using System.Text;


namespace Task_1._2._3_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст:");
            string text = Replace_Punctuation(Console.ReadLine());   
            string [] array = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            bool check = false;
            int wordCounter = 0;
              for (int i = 0; i < array.Length; i++) 
              {       
                foreach (char c in array[i])
                {
                    if (!char.IsLower(c))
                    {
                        break;
                    }
                    else
                    {
                        check = true;
                    }
                }
                if (check == true)
                {
                    wordCounter++;
                }
                check = false;
              }        
            Console.Write("Количество слов с маленько буквы= " + wordCounter);
        }
        static string Replace_Punctuation(string text)
        {
            var str = new StringBuilder(text);
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsPunctuation(str[i]) || char.IsNumber(str[i]))
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

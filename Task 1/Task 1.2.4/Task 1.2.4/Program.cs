using System;
using System.Text;

namespace Task_1._2._4
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string text = Console.ReadLine();          
            Console.WriteLine(text);
            Validator(text);
        }
        public static  void Validator(string text)
        {
            text = text.TrimStart();
            var stringBuilder = new StringBuilder(text);
            stringBuilder[0] = char.ToUpper(stringBuilder[0]);
            for (int i = 1; i < stringBuilder.Length; i++)
            {               
                if (stringBuilder[i] == '.' || stringBuilder[i] == '!' || stringBuilder[i] == '?')
                {
                    while (!char.IsLetter(stringBuilder[i]))
                    {
                        if (i == (stringBuilder.Length - 1))
                        {
                            break;
                        }
                        i++;                 
                    }                                     
                    stringBuilder[i] = char.ToUpper(stringBuilder[i]);
                }
            }
            Console.WriteLine("Измененная строка:" + stringBuilder);     
        }
    }
}

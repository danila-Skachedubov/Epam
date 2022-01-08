using System;


namespace Task1._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первую строку: ");
            string  str1 = Console.ReadLine();
            Console.Write($"{ Environment.NewLine }Введите вторую строку: ");
            string str2 = Console.ReadLine();
            str2.ToCharArray();
            string str3 = " ";
            foreach (char i in str1)
                if (!str2.Contains(i))
                    str3 += i;
                else
                {
               
                    str3 += i;
                    str3 += i;
                }
            Console.WriteLine($"Результат: { str3 }");
        }
    }
}

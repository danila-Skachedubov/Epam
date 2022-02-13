using System;

namespace Task_3._3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                string str = Console.ReadLine();
                char[] ch = str.ToCharArray();
                Console.WriteLine(ch.Language());
            } while (true);
        }
    }
}

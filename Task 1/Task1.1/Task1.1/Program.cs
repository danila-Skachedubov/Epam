using System;

namespace Task1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, user!" + "\n" + "This is homework 1.1. To select the desired task, enter the corresponding number." + "\n\n");
            Console.WriteLine("1 - for RECTANGLE(1.1.1)");
            Console.WriteLine("2 - for TRIANGLE(1.1.1)");
            Console.WriteLine("3 - for ANOTHER TRIANGLE(1.1.1)");
            Console.WriteLine("4 - for X-MAS TREE(1.1.1)");
            Console.WriteLine("5 - for SUM OF NUMBERS(1.1.1)");
            Console.WriteLine("6 - for FONT ADJUSTMENT(1.1.1)");
            Console.WriteLine("7- for ARRAY PROCESSING(1.1.1)");
            Console.WriteLine("8- for NO POSITIVE(1.1.1)");
            Console.WriteLine("9- for NON-NEGATIVE SUM(1.1.1)");
            Console.WriteLine("10- for 2D ARRAY(1.1.1)");
            Console.WriteLine("0- for exit\n");

            int number_selection = int.Parse(Console.ReadLine());
            switch (number_selection)
            {
                case 1:
                    Task1();
                    break;
                case 2:
                    Triangle();
                    break;
                case 3:
                    Another_Triangle();
                    break;
                case 4:

                    break;
                case 5:

                    break;
                case 6:

                    break;
                case 7:

                    break;
                case 8:

                    break;
                case 9:

                    break;
                case 10:

                    break;
                case 0:

                    break;
                default:
                    Console.WriteLine("enter correct value");
                    break;

            }
            static void Task1()
            {
                int lenght = 0, width = 0;
                do
                {
                    Console.WriteLine("Enter length value ");
                    
                }
                while (lenght <= 0 && (!int.TryParse(Console.ReadLine(), out lenght)));
              
                do
                {
                    Console.WriteLine("Enter width value ");
                   
                }
                while (width <= 0 && (!int.TryParse(Console.ReadLine(), out width)));
            
                Console.WriteLine($"Area is: { Rectangle(lenght, width)} ");
            }
            
            static int Rectangle(int x, int y) => x * y;

            static void Triangle()
            {
                int number = 0;
                do
                {
                    Console.WriteLine("Еnter the number of lines  ");

                }
                while (!int.TryParse(Console.ReadLine(), out number));
               
                for (Int32 i = 0; i < number; ++i )
                {
                      Console.WriteLine(new String('*', i+1));
                }
            }

            static void Another_Triangle()
            {
                int number = 0;
                do
                {
                    Console.WriteLine("Еnter the number of lines  ");

                }
                while (!int.TryParse(Console.ReadLine(), out number));

                for (Int32 i = 0; i < number; ++i)
                {
                    String p = new String(' ', number - i - 1);
                    Console.WriteLine(p + new String('*', 1+i*2 ) );
                }
            }
        }


    }

}
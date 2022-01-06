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
                    Task1(); break;
                case 2:
                    Triangle();
                    break;
                case 3:
                    Another_Triangle();
                    break;
                case 4:
                    Xmas_Tree();
                    break;
                case 5:
                    Sum_Of_Numbers();
                    break;
                case 6:
                    Font_Adjustment();
                    break;
                case 7:
                    Array_Processing();
                    break;
                case 8:
                    NoP();
                    break;
                case 9:
                    Non_Negative_Sum();
                    break;
                case 10:
                    SeconD_Aray();
                    break;
                case 0:
                    
                    break;
                default:
                    Console.WriteLine("enter correct value");
                    break;
            }
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

                for (Int32 i = 0; i < number; ++i)
                {
                    Console.WriteLine(new String('*', i + 1));
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
                    Console.WriteLine(p + new String('*', 1 + i * 2));
                }
            }
            static void Xmas_Tree()
            {
                Console.WriteLine("Input number of triangles:");
                if (int.TryParse(Console.ReadLine(), out var n) && n > 0)
                {
                    for (var i = 1; i <= n; i++)
                    {

                        for (var j = 0; j < i; j++)
                        {
                            var space = new String(' ', n - j);
                            var branch = new String('*', j * 2);
                            Console.WriteLine(space + "*" + branch);
                        }
                    }
                }

            }
            static void Sum_Of_Numbers()
            {
                int[] mass = new int[1000];
                int summ = 0;
                for (int i = 0; i < 1000; i++)
                {
                    mass[i] = i;
                }
                foreach (int i in mass)
                {
                    if (mass[i] % 3 == 0 || i % 5 == 0)
                        summ += i;
                }
                Console.WriteLine($"number is: { summ }");
            }
            static void Font_Adjustment()
            {
                bool[] font = new bool[3];
                font[0] = false;
                font[1] = false;
                font[2] = false;
                byte number = 0;
                String text = " ";
                do
                {
                    if (font[0] == true)

                        text += "'bold' ";
                    if (font[1] == true)
                        text += "'italic' ";
                    if (font[2] == true)
                        text += "'underline' ";
                    if (font[0] && font[1] && font[2] == false)
                        Console.Write("None");

                    Console.WriteLine(text);
                    if (text.Length > 0)
                        text = text.Remove(0);

                    Console.WriteLine("Enter number for:\n" + "1: bold \n" + "2: italic \n" + "3:underline \n");
                    number = Convert.ToByte(Console.ReadLine());
                    switch (number)
                    {
                        case 1:
                            font[0] = !font[0];
                            break;
                        case 2:
                            font[1] = !font[1];
                            break;
                        case 3:
                            font[2] = !font[2];
                            break;
                        case 4:
                            Console.Write("Exit");
                            break;
                    }

                }
                while (number != 4);
            }
            static void Array_Processing()
            {
                int[] arr = new int[20];
                Random rand = new Random();

                for (int i = 0; i < 20; i++)
                {
                    arr[i] = rand.Next(100);

                    Console.Write($" {arr[i]} \t");
                }
                Console.WriteLine("\n");
                Min(arr);
                Console.WriteLine("\n");
                Max(arr);
                Console.WriteLine("\n");
                Sort(arr);
                for (int i = 0; i < 20; i++)
                {
                    Console.Write($" {arr[i]} \t");
                }

                static void Sort(int[] array)
                {
                    int temp = 0;
                    for (int i = 0; i < array.Length - 1; i++)

                    {
                        for (int j = i + 1; j < array.Length; j++)
                        {
                            if (array[i] > array[j])
                            {
                                temp = array[i];
                                array[i] = array[j];
                                array[j] = temp;
                            }

                        }
                    }
                }
            }
            static void Min(int[] array)
            {
                int min = array[0];
                for (int i = 1; i < array.Length; i++) {
                    min = (min > array[i]) ? array[i] : min;
                }
                Console.WriteLine($"Минимальное значение { min }");
            }
            static void Max(int[] array)
            {
                int min = array[0];
                for (int i = 1; i < array.Length; i++)
                {
                    min = (min < array[i]) ? array[i] : min;
                }
                Console.WriteLine($"Максимальное значение { min }\n");
            }
            static void NoP()
            {
                //int[,,] array = { { { -1, -1, -1 }, { 4, 5, 6 } } };
                int[,,] array = new int[3, 3, 3];
                Random rand = new Random();
                Console.WriteLine("Initial array:");
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        for (int k = 0; k < array.GetLength(2); k++)
                        {
                            array[i, j, k] = rand.Next(-10, 10);
                            Console.Write($" {array[i, j, k]}\t");
                        }
                    }
                }
                Console.WriteLine("\n\n Измененнный массив \n");
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        for (int k = 0; k < array.GetLength(2); k++)
                        {
                            if (array[i, j, k] < 0)
                                array[i, j, k] = 0;
                            Console.Write($" {array[i, j, k]} \t");
                        }
                    }
                }
                
            }
            static void Non_Negative_Sum()
            {
                int[] array = new int[10];
                int counter = 0;
                Console.WriteLine("Введите значения массива");
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    int number = Convert.ToInt32(Console.ReadLine());
                    array[i] = number;
                    if(array[i] > 0)
                       counter += array[i];
                }
                Console.WriteLine($"Сумма положительных чисел массива = {counter}");
            }
            static void SeconD_Aray()
            {
                int[,] numbers = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
                int counter = 0;
                int rows = numbers.GetUpperBound(0) + 1;    
                int columns = numbers.Length / rows;
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {                   
                        Console.Write($"{numbers[i, j]}\t");
                        if ((i + j) % 2 == 0)
                        {
                            counter += numbers[i, j];
                        }
                    }
                    Console.WriteLine();
                }
                Console.Write($"Сумма членов массива, стоящих на четных позициях = {counter}");
            }
        
    }

}


    



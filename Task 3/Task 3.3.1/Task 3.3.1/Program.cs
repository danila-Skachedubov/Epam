using System;

namespace Task_3._3._1
{
    class Program
    {

        static void Main(string[] args)
        {

            double[] array = { 1, 2, 3, 4, 5 };

            array.Transformation(x => x *2);
            
            double Sum = array.Summ();
            Console.WriteLine(Sum);
            double Average = array.Average();
            Console.WriteLine(Average);
            double Elementscommon = array.MostCommonElement();
            Console.WriteLine(Elementscommon);
        }
    }
}


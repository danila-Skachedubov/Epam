using System;
using System.Collections.Generic;

namespace Task_3._3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pizzaria pizzaria = new Pizzaria();
            User user = new User("Dima");
            Dictionary<PizzaType, int> values = new Dictionary<PizzaType, int>();

            Console.WriteLine("Menu" + Environment.NewLine
                + "Pepperoni with price 300 bucks" + Environment.NewLine
                + "FourSeasons with price 200 bucks" + Environment.NewLine
                + "Margarita with price 100 bucks" + Environment.NewLine
                + "Classic with price 400 bucks" + Environment.NewLine
                );

            Console.WriteLine("Enter the type of pizza");

            PizzaType pizza = PizzaType.None;
            int kol = 0;
            try
            {
                pizza = (PizzaType)Enum.Parse(typeof(PizzaType), Console.ReadLine());

            }
            catch (Exception e)
            {
                Console.WriteLine($"Возникло исключение { e.Message }");
                return;

            }
            Console.WriteLine("Enter the quantity");
            try
            {
                kol = int.Parse(Console.ReadLine());
            }
            catch
            {

                Console.WriteLine("Inavalid type of quantity");
                return;
            }


            values.Add(pizza, kol);
            user.OrderPizza(pizzaria, values);

        }
    }

}

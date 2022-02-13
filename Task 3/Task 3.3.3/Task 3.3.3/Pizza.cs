using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._3._3
{
    public class Pizza
    {
        public PizzaType PizzaType { get; }
        public int Price { get; set; }
        public static int PriceMargarita = 100;
        public static int PriceFourSeasons = 200;
        public static int PricePepperoni = 300;
        public static int PriceClassic = 400;
        public Pizza(PizzaType pizza)
        {
            PizzaType = pizza;
            SetPizzaPrice(pizza);

        }
        private void SetPizzaPrice(PizzaType pizzaType)
        {
            switch (pizzaType)
            {
                case PizzaType.Margarita: Price = PriceMargarita; break;
                case PizzaType.FourSeasons: Price = PriceFourSeasons; break;
                case PizzaType.Pepperoni: Price = PricePepperoni; break;
                case PizzaType.Classic: Price = PriceClassic; break;

            }
        }
    }
    public enum PizzaType : byte
    {
        None = 0,
        Margarita,
        FourSeasons,
        Pepperoni,
        Classic,
    }
}

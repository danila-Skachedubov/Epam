using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._3._3
{
    public class User
    {
        public string name { get; set; }
        public User(string Name)
        {
            this.name = Name;
        }
        public void OrderPizza(Pizzaria pizzaria, Dictionary<PizzaType, int> _orders)
        {
            List<Pizza> _pizzas = new List<Pizza>();
            int sum = 0;
            foreach (var _order in _orders)
            {
                for (int i = 0; i < _order.Value; i++)
                {
                    Pizza pizza = new Pizza(_order.Key);
                    _pizzas.Add(pizza);
                    sum += pizza.Price;
                }
            }

            Order order = new Order(this, _pizzas, sum);
            pizzaria.AddOrder(order);
            pizzaria.TakeOrder(order.OrderPrice);
        }

    }
}

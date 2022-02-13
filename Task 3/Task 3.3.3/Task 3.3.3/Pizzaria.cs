using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_3._3._3
{
    public delegate void StatuReady();
    public delegate void PizzaTime(int sum);

    public class Pizzaria
    {

        PizzaTime? notify;
        int number = 1;
        public Queue<Order> orderList = new Queue<Order>();
        public int GenerateOrderNumber()
        {
            return number++;
        }
        public void AddOrder(Order order)
        {
            order.OrderNumber = GenerateOrderNumber();
            orderList.Enqueue(order);
            Console.WriteLine($"Your ourder number is : {order.OrderNumber}");
            Cooking(IsReady);
            notify = TakeOrder;

        }
        public void Cooking(StatuReady callback)
        {

            while (orderList.Count > 0)
            {
                Thread.Sleep(1000);
                orderList.Dequeue();
                callback();
            }
        }
        public void IsReady()
        {
            Console.WriteLine("Order is ready");
        }
        public void TakeOrder(int sum)
        {
            Console.WriteLine($"Price you order is : {sum}");
        }
    }
}

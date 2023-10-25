using QA_Task1.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_Task1.Service
{
    public class DeliveryService
    {
        public List<Order> OrderList = new List<Order>();
        public List<IDelivery> DeliveryList = new List<IDelivery>();

        public void AddOrder(Order order) 
        { 
            OrderList.Add(order);
        }

        public void AddDelivery(IDelivery delivery) 
        {
            DeliveryList.Add(delivery);
        }

        public void DeliveryOrderWithLove(Order order) 
        {
            if (OrderList.Contains(order) && DeliveryList.Count > 0) 
            {
                OrderList.Remove(order);
                var bestDelivery = DeliveryList.OrderBy(x => x.ExpectedDeliveryTime(order)).FirstOrDefault();
                DeliveryList.Remove(bestDelivery);
                Console.WriteLine($"{order.ProductName} will be delivered by {bestDelivery.DeliveryInfo()}");
            }

        }
    }
}

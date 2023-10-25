using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_Task1.Entity
{
    public class DroneDelivery : IDelivery
    {
        public string DeliveryName = "HelicopcerHelicopcer";
        public void DeliverOrder(Order order)
        {
            throw new NotImplementedException();
        }
        public string DeliveryInfo()
        {
            return DeliveryName;
        }

        public DateTime ExpectedDeliveryTime(Order order)
        {
            var expectedDeliveryTime = DateTime.Today.AddHours(1);
            return expectedDeliveryTime;
        }
    }
}

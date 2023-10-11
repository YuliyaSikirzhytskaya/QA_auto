using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_Task1.Entity
{
    internal class MotoDelivery : IDelivery
    {
        public string DeliveryName = "MotoHrust";
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
            var expectedDeliveryTime = DateTime.Today.AddHours(2);
            return expectedDeliveryTime;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_Task1.Entity
{
    internal class PedestrianDelivery : IDelivery
    {
        public string DeliveryName = "TopTop";
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
            var expectedDeliveryTime = DateTime.Today.AddHours(4);
            return expectedDeliveryTime;
        }
    }
}

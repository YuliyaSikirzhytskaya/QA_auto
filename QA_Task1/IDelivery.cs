using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_Task1
{
    public interface IDelivery
    {
        public void DeliverOrder(Order order);
        public DateTime ExpectedDeliveryTime(Order order);
        public string DeliveryInfo();

    }
}

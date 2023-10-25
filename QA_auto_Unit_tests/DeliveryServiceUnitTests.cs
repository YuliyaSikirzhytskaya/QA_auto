using QA_Task1;
using QA_Task1.Entity;
using QA_Task1.Service;

namespace QA_auto_Unit_tests
{
    [TestClass]
    public class DeliveryServiceUnitTests
    {
        [TestMethod]
        public void CheckAddingOrder()
        {
            Order order = new Order("pencil", 3752571037883, 13, "Gdynia");
            DeliveryService deliveryService = new DeliveryService();
            deliveryService.AddOrder(order);
            Assert.AreEqual(1, deliveryService.OrderList.Count);
     
        }

        [TestMethod]
        public void CheckAddingDelivery()
        {
            var deliveryAuto = new AutoDelivery();
            DeliveryService deliveryService = new DeliveryService();
            deliveryService.AddDelivery(deliveryAuto);
            Assert.AreEqual(1, deliveryService.DeliveryList.Count);

        }

        [TestMethod]
        public void CheckDeliveryOrderWithLove()
        {
            //prep
            Order order = new Order("pencil", 3752571037883, 13, "Gdynia");
            Order order2 = new Order("pen", 3752571068483, 22, "Gdynia");
            var deliveryAuto = new AutoDelivery();
            var deliveryDrone = new DroneDelivery();
            DeliveryService deliveryService = new DeliveryService();
            deliveryService.AddOrder(order);
            deliveryService.AddOrder(order2);
            deliveryService.AddDelivery(deliveryAuto);
            deliveryService.AddDelivery(deliveryDrone);

            //call
            deliveryService.DeliveryOrderWithLove(order);

            //assert
            Assert.AreEqual(1, deliveryService.DeliveryList.Count);
            Assert.AreEqual(1, deliveryService.OrderList.Count);

        }
    }
}

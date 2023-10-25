using QA_Task1;

namespace QA_auto_Unit_tests
{
    [TestClass]
    public class OrderUnitTests
    {
        [TestMethod]
        public void CheckValidProdutNamePositive()
        {
            Order order = new Order("pencil", 3752571068783, 21, "Gdynia");
            Assert.AreEqual("pencil", order.ProductName);
        }

        [TestMethod]
        public void CheckValidProdutNameNegative()
        {
            try
            {
                Order order = new Order(string.Empty, 3752571068783, 21, "Gdynia");
                
            }
            catch(ArgumentNullException ex) 
            {
                Assert.AreEqual("value", ex.ParamName);
            }
        }

        [TestMethod]
        public void CheckValidPhoneNumberPositive()
        {
            Order order = new Order("pencil", 3752571068783, 21, "Gdynia");
            Assert.AreEqual(3752571068783, order.PhoneNumber);
        }

        [TestMethod]
        public void CheckValidPhoneNumberNegative()
        {
            try
            {
                Order order = new Order("pencil", 37525710687, 21, "Gdynia");

            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual("value", ex.ParamName);
            }
        }

        [TestMethod]
        public void CheckValidCostPositive()
        {
            Order order = new Order("pencil", 3752571068783, 21, "Gdynia");
            Assert.AreEqual(21, order.Cost);
        }

        [TestMethod]
        public void CheckValidCostNegative()
        {
            try
            {
                Order order = new Order("pencil", 37525710687, 0, "Gdynia");

            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual("value", ex.ParamName);
            }
        }

        [TestMethod]
        public void CheckValidDeliveryAddressPositive()
        {
            Order order = new Order("pencil", 3752571068783, 21, "Gdynia");
            Assert.AreEqual("Gdynia", order.DeliveryAddress);
        }

        [TestMethod]
        public void CheckValidDeliveryAddressNegative()
        {
            try
            {
                Order order = new Order(string.Empty, 3752571068783, 21, string.Empty);

            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual("value", ex.ParamName);
            }
        }

        [TestMethod]
        public void CheckGetFullInfo()
        {
            Order order = new Order("pencil", 3752571068783, 21, "Gdynia");
            var getFullInfoResult = order.GetFullInfo();
            Assert.AreEqual("Product Name: pencil; Phone Number: 3752571068783; Cost: 21; Delivery Address: Gdynia", getFullInfoResult);
        }

        [TestMethod]
        public void CheckCompareToLess()
        {
            Order order1 = new Order("pen", 3752571068483, 22, "Gdynia");
            Order order2 = new Order("pencil", 3752571098783, 18, "Gdynia");
            var compareToResult = order1.CompareTo(order2);
            Assert.AreEqual(-1, compareToResult);

        }

        [TestMethod]
        public void CheckCompareToGreate()
        {
            Order order1 = new Order("pen", 3752571168483, 22, "Gdynia");
            Order order2 = new Order("pencil", 3752571098783, 18, "Gdynia");
            var compareToResult = order1.CompareTo(order2);
            Assert.AreEqual(1, compareToResult);

        }

        [TestMethod]
        public void CheckCompareToEqual()
        {
            Order order1 = new Order("pen", 3752571098783, 22, "Gdynia");
            Order order2 = new Order("pencil", 3752571098783, 18, "Gdynia");
            var compareToResult = order1.CompareTo(order2);
            Assert.AreEqual(0, compareToResult);

        }
    }
}
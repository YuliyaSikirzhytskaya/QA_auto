// See https://aka.ms/new-console-template for more information

using QA_Task1;
using QA_Task1.Comparers;

VIPOrder order1 = new VIPOrder("note","book", 3752957198645, 5, "Warszawa");
DiscountOrder order2 = new DiscountOrder(5,"pen", 3752571058783, 1, "Lodz");
Order order3 = new Order("pencil", 3752571068783, 21, "Gdynia");
Order order4 = new Order("pen", 3752571068483, 22, "Gdynia");
Order order5 = new Order("pencil", 3752571098783, 18, "Gdynia");
Order order6 = new Order("pencil", 3752571037883, 13, "Gdynia");

Order[] orders = new Order[3];
orders[0] = order1;
orders[1] = order2;
orders[2] = order3;
//.Where(x => x.PhoneNumber.ToString().StartsWith("375") && x.Cost <= 20 && x.DeliveryAddress.StartsWith("Wa"))
//foreach (Order order in orders)
//{
//    order.OutputInfo();
//}

//ItemNodeList<Order> orderList = new ItemNodeList<Order>();
//orderList.Add(order1);
//orderList.Add(order2);
//orderList.Add(order3);

//orderList.IndexOf(order2);
//Console.WriteLine(orderList.Count());
//foreach (var order in orderList) 
//    {
//    order.OutputInfo();
//    }

List<Order> orderList = new List<Order>() 
                        {
                            order1, order2, order3, order4, order5, order6
                        };

var nameComparer = new ProductNameComparer();
var phoneNumberComparer = new PhoneNumberComparer();
var deliveryAddressComparer = new DeliveryAddressComparer();
var costComparer = new CostComparer();

Console.WriteLine("\nSort by NameComparer: ");
orderList.Sort(nameComparer);
foreach (var order in orderList)
        {
            order.OutputInfo();
        }


Console.WriteLine("\nSort by CostComparer: ");
orderList.Sort(costComparer);
foreach (var order in orderList)
{
    order.OutputInfo();
}

Console.WriteLine(" \nOrder by desc:");
foreach (var order in orderList.OrderByDescending(x => x.PhoneNumber))
{
    order.OutputInfo();
}


Console.WriteLine(" \nOrder by asc: ");
foreach (var order in orderList.OrderBy(x => x.DeliveryAddress))
{
    order.OutputInfo();
}

Console.WriteLine(" \nWhere OrderBy Select: ");
var result = orderList.Where(x => x.Cost <=20).OrderBy(x => x.ProductName).Select(x => x.ProductName).ToList();
foreach (var productName in result) 
{ 
    Console.WriteLine(productName);
}

Console.WriteLine(" \nGroupBy : ");
var maxRecord = orderList.GroupBy(x => x.ProductName).Select(y => new 
{ 
    ProductName = y.Key, 
    Count = y.Count(),
}).OrderByDescending(z => z.Count).FirstOrDefault();
Console.WriteLine(maxRecord.ProductName);

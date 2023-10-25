namespace QA_Task1
{
    public class VIPOrder : Order
    {
        public string GiftDescription {  get; set; }
        public VIPOrder(string giftDescription,string productName, long phoneNumber, float cost, string deliveryAddress) : base(productName, phoneNumber, cost, deliveryAddress)
        {
            GiftDescription = giftDescription; 
        }
        public override string GetFullInfo()
        {
            return $"Product Name: {ProductName}; Phone Number: {PhoneNumber}; Cost: {Cost}; Delivery Address: {DeliveryAddress}; GiftDescription: {GiftDescription}";
        }
    }
}

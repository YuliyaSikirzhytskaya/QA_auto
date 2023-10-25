namespace QA_Task1
{
    public class DiscountOrder : Order
    {
        public float SizeOfDiscount { get; set; }
        public DiscountOrder(float sizeOfDiscount, string productName, long phoneNumber, float cost, string deliveryAddress) : base(productName, phoneNumber, cost, deliveryAddress)
        {
            SizeOfDiscount = sizeOfDiscount;
        }
        public override string GetFullInfo()
        {
            return $"Product Name: {ProductName}; Phone Number: {PhoneNumber}; Cost: {Cost}; Delivery Address: {DeliveryAddress}; SizeOfDiscount: {SizeOfDiscount}%";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_Task1
{
    public class Order:IComparable<Order>
    {
        private string _productName;
        private long _phoneNumber;
        private float _cost;
        private string _deliveryAddress;
        public string ProductName
        {
            get 
            {
                return _productName;
            }
            set
            {
                _productName = value;
            }
        }
        public long PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                //if (value.ToString().Length == 13)
                //{ 
                    _phoneNumber = value;
                //}
            }
        }
        public float Cost
        {
            get
            {
                return _cost;
            }
            set
            {
                //if (value>0 && value<=1000) 
                //{
                _cost = value;
                //}
            }
        }
        public string DeliveryAddress
        {
            get
            {
                return _deliveryAddress;
            }
            set
            {
                _deliveryAddress = value;
            }
        }

        public Order (string productName, long phoneNumber, float cost, string deliveryAddress) 
        {
            ProductName = productName;
            PhoneNumber = phoneNumber;
            Cost = cost;
            DeliveryAddress = deliveryAddress;

        }
        
        public virtual string GetFullInfo()
        {
                return $"Product Name: {ProductName}; Phone Number: {PhoneNumber}; Cost: {Cost}; Delivery Address: {DeliveryAddress}";
        }

        public void OutputInfo() 
        {
            Console.WriteLine(GetFullInfo());
        }

        public int CompareTo(Order? other)
        {
            return (PhoneNumber < other?._phoneNumber) ? -1 : ((PhoneNumber == other?._phoneNumber) ? 0 : 1);
        }
    }
}

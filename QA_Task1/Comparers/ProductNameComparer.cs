using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_Task1.Comparers
{
    internal class ProductNameComparer : IComparer<Order>
    {
        public int Compare(Order? x,Order? y)
        {
            return x.ProductName.CompareTo(y.ProductName);
        }
    }
}

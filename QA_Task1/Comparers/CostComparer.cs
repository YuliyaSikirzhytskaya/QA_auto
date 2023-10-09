using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_Task1.Comparers
{
    internal class CostComparer : IComparer<Order>
    {
        public int Compare(Order? x,Order? y)
        {
            return x.Cost.CompareTo(y.Cost);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_Task1
{
    public class ItemNode<T>
    {
        public T Item { get; set; }
        public ItemNode<T> Next {get; set; }
        public ItemNode(T item, ItemNode<T> next)
        {
            Item = item;
            Next = next;
        }
    }
}

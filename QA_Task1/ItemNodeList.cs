using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_Task1
{
    internal class ItemNodeList<T>:IEnumerable<T>
    {
        public ItemNode<T> Head { get; set; }
        public void Add(T item) 
        {
            if (Head == null)
            {
                Head = new ItemNode<T>(item, null);
            }
            else 
            {
                Head = new ItemNode<T> (item, Head);
            }
        }

        public int IndexOf(T item) 
        {
            var index = -1;
            var counter = 0;
            var current = Head;
            while (current != null)
            {
                if (current.Item.Equals(item))
                {
                    index = counter;
                    break;
                }
                else
                {
                    current = current.Next;
                    counter++;
                }
            }
            return index;
           
        }

        public int Count()
        {
            var counter = 0;
            var current = Head;
            while(current != null)
            {
                counter++;
                current = current.Next;
            }
            return counter;
        }
        public T GetItemByIndex(int index)
        {

            if (index > Count() - 1) 
            {
                return default(T);
            }
            var current = Head;
            var currentIndex = 0;
            while(current != null)
            {
                if (currentIndex == index)
                {
                    break;
                }
                else 
                {
                    current = current.Next;
                    currentIndex++;
                }
            }
            return current.Item;
        }
        public void Delete(T item)
        {
            var current = Head;
            ItemNode<T> prev = null;
            while( current != null)
            {
                if (current.Item.Equals(item)) 
                {
                    prev.Next = current.Next;
                }
                else
                {
                    prev = current;
                    current = current.Next;
                    
                }

            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            var current = Head;
            while (current != null)
            {
                yield return current.Item;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

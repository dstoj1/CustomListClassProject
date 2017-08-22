using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClassProject1
{
    public class CustomList<T> :IEnumerable<T>
    {
        public T[] data = new T[5];
        public int count = 0;
        public int capcity = 5;
        public CustomList()
        {
            //this.count = count;
            //this.capcity = capcity;
        }
        public T this[int index]
        {
            get
            {
                return data[index];
            }
            set
            {
                data[index] = value;
            }
        }
        public int Capacity { get; set; }
        public void Add(T item)
        {
            T[] tempArray = new T[count + 1];
            if (capcity > count)
            {
                data[count] = item;
                count++;
                Console.WriteLine(item);
                return;
            }
            else if (capcity == count)
            {
                capcity += 4;
            }
            for (int index = 0; index < count; index++)
            {
                tempArray[index] = data[index];
            }
            tempArray[count] = item;
            count++;
            data = tempArray;
        }
        public bool Remove(T item)
        {
            int index;
            bool isFound = false;
            T[] tempArray = new T[count + 1];
            T[] nonRemoveArray = new T[count - 1];
            for (index = 0; index < data.Length; index++)
            {   
                if (data[index].Equals(item))
                {
                    tempArray[index] = data[0];
                    count--;
                    isFound = true;
                    continue;
                }
                else if(isFound)
                {
                    nonRemoveArray[index -1] = data[index];
                    continue;                                   
                }
                else
                {
                    nonRemoveArray[index] = data[index];
                }

            }

            data = nonRemoveArray;
            return isFound;
        }
        public override string ToString()
        {
            return " " + " ";  
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)data).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)data).GetEnumerator();
        }
    }
}

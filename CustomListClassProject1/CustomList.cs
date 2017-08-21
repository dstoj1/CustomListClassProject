using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClassProject1
{
    public class CustomList<T> //: //IEnumerable<T>
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
                return;
            }
            else if (capcity == count)
            {
                capcity += 4;
            }
            for (int index = 0; index < count; index++)
            {
                tempArray[index] = data[0];

                //count++;
            }
            tempArray[count] = item;
            count++;
            data = tempArray;
        }
        public bool Remove(T item)
        {
            int index;             
            T[] tempArray = new T[count + 1];
            T[] removeArray = new T[count + 1];
            for (index = 0; index < count; index++)
            {//Go through tempArray    
                //if (index = item)
                //{
                //    removeArray(index) = data[0];
                //}//if index  doesnt match then add to new Array
                //else
                //{
                //    tempArray[index] = data[0];
                //}

            }
            tempArray[count] = item;
            removeArray[count] = item;
            data = tempArray;
            return false;
            //do I need to add capacity to the new Array???
        }    
    }
}

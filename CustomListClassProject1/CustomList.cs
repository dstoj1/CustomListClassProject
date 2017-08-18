using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClassProject1
{
    public class CustomList<T>
    {
        T[] item = new T[0];
        int count;
        public CustomList()
        {
            this.count = count;
        }   
        public T this[int index]
        {
            get
            {
                return item[index];
            }
            set
            {
                item[index] = value;
            }
        }  
        public void Add    
    }
}

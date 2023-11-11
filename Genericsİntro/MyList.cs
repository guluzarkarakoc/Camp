using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    public class MyList <T>
    {

        T[] items;

        public MyList()
        {
           items = new T[0];
        }

        public void Add(T item)
        {
            T[] temparray = items;
            items =new T[items.Length+1];

            for (int i = 0; i < temparray.Length; i++) 
            {
                items[i] = temparray[i];
            }
            items[items.Length-1] = item;

           
        }
        public int Length 
        { 
            get { return items.Length; }
        }

        public T[] Items
        {
            get { return items; }
        }
    }
}

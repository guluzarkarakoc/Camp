using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class BasketManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Sepete Eklendi: " + product.Name );

        }
        public void Add2(string productName, string explain, double unitPrice , int stock)
        {
            Console.WriteLine("Sepete Eklendi: " + productName);
        }
    }
}

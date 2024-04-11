using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace date0411
{
    internal class Product
    {
        public string Name;
        public int Price;

        
       public void print()
        {
            Console.WriteLine($"{Name} : {Price}");
        }
        
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderPattern
{
    public class Product
    {
        public List<string> Parts = new List<string>();


        public void Add(string part)
        {
            Parts.Add(part);
        }

        public void show()
        {
            Console.WriteLine("Product contain the following parts");
            foreach (var item in Parts)
            {
                Console.WriteLine(item);
            }
        }
    }
}

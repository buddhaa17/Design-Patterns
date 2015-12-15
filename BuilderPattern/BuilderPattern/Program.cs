using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            var director = new Director();

            Builder b1 = new ConcreteClassA();

            Builder b2 = new ConcreteClassB();

            director.Construct(b1);
            Product p1 = b1.GetProduct();
            p1.show();

            director.Construct(b2);
            Product p2 = b2.GetProduct();
            p2.show();

            Console.ReadKey();
        }
    }
}

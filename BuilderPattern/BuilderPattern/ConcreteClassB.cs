using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class ConcreteClassB : Builder
    {
        Product product = new Product();

        public override void BuildPartA()
        {
            product.Add("Part X");
        }

        public override void BuildPartB()
        {
            product.Add("Part Y");
        }

        public override Product GetProduct()
        {
            return product;
        }
    }
}

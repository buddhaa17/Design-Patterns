using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadBalancerApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Loadbalancer loadBalancer = Loadbalancer.GetInstance();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("For request {0} Loadbalancer assigned {1}",i+1,loadBalancer.Server);
            }
            Console.ReadKey();

        }
    }
}

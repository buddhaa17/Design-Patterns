using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // This example takes the bill amount and calculates the final bill as per the discounted strategy

            BillCalculateStrategy strategy = null;

            var currentDay = System.DateTime.Now.DayOfWeek;

            var customerBillAmount = 1000;

            if(currentDay == DayOfWeek.Sunday || currentDay == DayOfWeek.Saturday)
            {
                strategy = new DiscountStrategy();
            }
            else
            {
                strategy = new NoDiscountStrategy();    
            }

            var finalBillAmount = strategy.CalculateFinalBill(customerBillAmount);
            Console.WriteLine("your final bill amount is {0}",finalBillAmount);
            Console.ReadKey();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class DiscountStrategy : BillCalculateStrategy
    {

        public override double CalculateFinalBill(double amount)
        {
            // give 10% discount on the amount.
            var discountedAmount = (10*amount)/100;
            return amount - discountedAmount;
        }
    }
}

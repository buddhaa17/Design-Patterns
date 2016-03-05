using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class NoDiscountStrategy : BillCalculateStrategy
    {
        public override double CalculateFinalBill(double amount)
        {
            // No discount is applied
            return amount;
        }
    }
}

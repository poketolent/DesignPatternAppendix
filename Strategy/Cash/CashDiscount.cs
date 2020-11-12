using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Cash
{
    class CashDiscount : PayCash
    {
        private double discountRate = 1d;
        public CashDiscount(string discountRate)
        {
            this.discountRate = Convert.ToDouble(discountRate);
        }
        public override double AcceptCash(double money)
        {
            return money* discountRate;
        }
    }
}

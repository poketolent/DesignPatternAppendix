using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Cash
{
    class CashReturn : PayCash
    {
        private double moneyCondition = 0.0;
        private double moneyReturn = 0.0;
        public CashReturn(string moneyCondition, string moneyReturn)
        {
            this.moneyCondition = Convert.ToDouble(moneyCondition);
            this.moneyReturn = Convert.ToDouble(moneyReturn);
        }
        public override double AcceptCash(double money)
        {
            double result = money;
            if (money > moneyCondition)
            {
                result = money - Math.Floor(money / moneyCondition) * moneyReturn;
            }
            return result;
        }
    }
}

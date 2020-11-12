using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Cash
{
     class CashNormal : PayCash
    {
        public override double AcceptCash(double money)
        {
            return money;
        }
    }
}

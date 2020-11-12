using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Cash
{
    class CashFactory
    {
        public static PayCash createCashAccept(CashEnum cashEnum)
        {
            PayCash payCash = null;
            switch (cashEnum)
            {
                case CashEnum.normal:
                    payCash = new CashNormal();
                    break;
                case CashEnum.refund:
                    payCash = new CashReturn("300", "100");
                    break;
                case CashEnum.discount:
                    payCash = new CashDiscount("0.8");
                    break;
                default:
                    break;
            }
            return payCash;
        }
    }
}
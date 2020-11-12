using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Cash
{
    class Context
    {
        PayCash payCash;
        //public Context(PayCash payCash, CashEnum Mode)
        public Context(CashEnum Mode)
        {
            //this.payCash = payCash;
            switch (Mode)
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

        }
        public double AcceptCash(double acceptCash)
        {
            return payCash.AcceptCash(acceptCash);
        }
    }
}

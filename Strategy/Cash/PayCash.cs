using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Cash
{
    abstract class PayCash
    {
        public abstract double AcceptCash(double money);
    }
}

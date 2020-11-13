using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod2.FactoryMethod
{
    class Nightingale
    {
        public void Sweep()
        {
            Console.WriteLine("掃地");
        }
        public void Wash()
        {
            Console.WriteLine("洗碗");
        }
        public void BuyRice()
        {
            Console.WriteLine("買米");
        }
    }
}

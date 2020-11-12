using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.ProxyPattern
{
    class ProxyMan : IGiveGift
    {
        PursuitMan Peter;
        public ProxyMan(SchoolGirl female)
        {
            Peter = new PursuitMan(female);
        }
        
        public void GiveDolls()
        {
            Peter.GiveDolls();
        }
        public void GiveFlowers()
        {
            Peter.GiveFlowers();
        }
        public void GiveChocolate()
        {
            Peter.GiveChocolate();
        }
    }
}

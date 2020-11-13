using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.ProxyPattern
{
    class PursuitMan
    {
        SchoolGirl _female;
        public PursuitMan(SchoolGirl female)
        {
            _female = female;
        }

        public void GiveDolls()
        {
            Console.WriteLine(_female.Name + "送你娃娃");
        }
        public void GiveFlowers()
        {
            Console.WriteLine(_female.Name + "送你鮮花");
        }
        public void GiveChocolate()
        {
            Console.WriteLine(_female.Name + "送你巧克力");
        }
    }
}

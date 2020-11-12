using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proxy.ProxyPattern;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            SchoolGirl baby = new SchoolGirl();
            baby.Name = "Pig";
            ProxyMan Peter = new ProxyMan(baby);
            Peter.GiveDolls();
            Peter.GiveChocolate();
            Peter.GiveFlowers();
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod2.FactoryMethod;

namespace FactoryMethod2
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactory factory = new UngraduateFactory();
            Nightingale Student = factory.CreateNightingale();
            Student.Sweep();
            Student.Wash();
            Student.BuyRice();
            Console.Read();
        }
    }
}

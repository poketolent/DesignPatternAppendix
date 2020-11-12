using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.People;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Person gg = new Person("Peter");
            //BigTrouser a = new BigTrouser();
            //Suit b = new Suit();
            //Tie c = new Tie();

            //a.Decorate(gg);
            //b.Decorate(a);
            //c.Decorate(b);
            //c.Show();
            SimpleSet ss = new SimpleSet();
            ss.Show();
            Console.ReadLine();
        }
    }
}

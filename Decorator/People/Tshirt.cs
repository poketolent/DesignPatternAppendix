using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.People
{
    class Tshirt : Clothes
    {
        public override void Show()
        {
            Console.Write("T恤");
            base.Show();
        }
    }
}

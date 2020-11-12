using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.People
{
    class Sneaker : Clothes
    {
        public override void Show()
        {
            Console.Write("球鞋");
            base.Show();
        }
    }
}

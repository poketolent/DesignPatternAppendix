using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.People
{
    class LeatherShoes : Clothes
    {
        public override void Show()
        {
            Console.Write("皮鞋");
            base.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.People
{
    class BigTrouser : Clothes
    {
        public override void Show()
        {
            Console.Write("垮褲");
            base.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.People
{
    class SimpleSet : Set
    {
        private void addSet()
        {
            BigTrouser a = new BigTrouser();
            Suit b = new Suit();
            Tie c = new Tie();
            b.Decorate(a);
            c.Decorate(b);
            this.clothes = c;
        }
        public override void Show()
        {
            addSet();
            base.Show();
        }
    }
}

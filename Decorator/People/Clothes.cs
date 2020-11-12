using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.People
{
    class Clothes : Person
    {
        protected Person component;
        public void Decorate (Person component)
        {
            this.component = component;
        }
        public override void Show() {
            if (component != null)
            {
                component.Show();
            }
        }
    }
}

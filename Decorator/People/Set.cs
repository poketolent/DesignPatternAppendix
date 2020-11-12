using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.People
{
    class Set : Clothes
    {
        protected Clothes clothes;

        public void Decorate(Clothes clothes)
        {
            this.clothes = clothes;
        }
        public override void Show()
        {
            if(clothes != null)
            {
                clothes.Show();
            }
            //base.Show();
        }
    }
}

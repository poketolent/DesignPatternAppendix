using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod2.FactoryMethod
{
    interface IFactory
    {
        Nightingale CreateNightingale();
    }
}

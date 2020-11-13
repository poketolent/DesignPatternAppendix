using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Operations
{
    interface IFactory
    {
        Operation CreateOperation();
    }
}

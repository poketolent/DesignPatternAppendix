using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Operations
{
    class SubFactory : IFactory
    {
    public Operation CreateOperation()
        {
            return new OperationSub();
        }
    }
}

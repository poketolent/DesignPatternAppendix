using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Operations
{
    public class OperationSimpleFactory
    {
        public static Operation CreateOperate(string operate)
        {
            switch (operate)
            {
                case "+":
                    return new OperationAdd();
                case "-":
                    return new OperationSub();
                case "*":
                    return new OperationMul();
                case "/":
                    return new OperationDiv();
                default:
                    throw new ArgumentException("參數錯誤");
            }
        }
    }
}

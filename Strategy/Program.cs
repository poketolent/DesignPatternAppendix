using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy.Cash;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = null;
            Console.WriteLine("請輸入金額");
            string strCash = Console.ReadLine();
            Console.WriteLine("請輸入打折方式 1.正常 2.300折100 3.打8折");
            CashEnum Mode = (CashEnum)Enum.Parse(typeof(CashEnum), Console.ReadLine());
            context = new Context(Mode);
            //switch (strMode)
            //{
            //    case CashEnum.normal:
            //        context = new Context(new CashNormal());
            //        break;
            //    case CashEnum.refund:
            //        context = new Context(new CashReturn("300", "100"));
            //        break;
            //    case CashEnum.discount:
            //        context = new Context(new CashDiscount("0.8"));
            //        break;
            //    default:
            //        break;
            //}

            //PayCash payCash = CashFactory.createCashAccept((CashEnum)Enum.Parse(typeof(CashEnum),Console.ReadLine()));
            double totalPrices = 0d;
            totalPrices = context.AcceptCash(Convert.ToDouble(strCash));
            Console.WriteLine(totalPrices);
            Console.ReadLine();
        }
    }
}

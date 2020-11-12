using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleFactory.Operations;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("請輸入數字A: ");
                string strNumberA = Console.ReadLine();
                Console.Write("請輸入運算符號(+、-、*、/): ");
                string strOperate = Console.ReadLine();
                Console.Write("請輸入數字B: ");
                string strNumberB = Console.ReadLine();
                var operation = OperationSimpleFactory.CreateOperate(strOperate);
                string strResult = "";
                operation.NumberA = Convert.ToDouble(strNumberA);
                operation.NumberB = Convert.ToDouble(strNumberB);
                strResult = operation.GetResult().ToString();
                Console.WriteLine(strResult);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("您輸入有誤: " + ex.Message);
                Console.ReadLine();
            }
        }
    }
}

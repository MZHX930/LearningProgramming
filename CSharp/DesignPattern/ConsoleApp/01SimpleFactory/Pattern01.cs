using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp._01SimpleFactory.Instance;

namespace ConsoleApp._01SimpleFactory
{
    internal class Pattern01
    {
        public void Run()
        {
            var oper = OperationFactory.CreateOperation("/");
            oper.NumberA = 1;
            oper.NumberB = 2;
            Console.WriteLine(oper.GetResult());
            Console.Read();
        }

    }
}

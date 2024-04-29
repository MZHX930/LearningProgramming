using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp._02Strategy
{
    /// <summary>
    /// 具体算法A
    /// </summary>
    internal class ConcreteStrategyA : Strategy
    {
        //算法A实现方法
        public override void AlgorithmInterface()
        {
            Console.WriteLine("算法A实现");
        }
    }
}

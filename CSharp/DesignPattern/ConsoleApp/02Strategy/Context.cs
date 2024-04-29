using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp._02Strategy
{
    internal class Context
    {
        Strategy strategy;

        /// <summary>
        /// 初始化时，传入具体的策略对象
        /// </summary>
        public Context(Strategy strategy)
        {
            this.strategy = strategy;
        }

        /// <summary>
        /// 根据具体的策略对象，调用其算法的方法
        /// </summary>
        public void ContextInterface()
        {
            strategy.AlgorithmInterface();
        }

    }
}

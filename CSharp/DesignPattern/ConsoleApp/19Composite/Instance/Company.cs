using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp._19Composite.Instance
{
    public abstract class Company
    {
        protected string name;
        public Company(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// 增加
        /// </summary>
        public abstract void Add(Company c);

        /// <summary>
        /// 移除
        /// </summary>
        public abstract void Remove(Company c);

        /// <summary>
        /// 显示
        /// </summary>
        public abstract void Display(int depth);

        /// <summary>
        /// 履行职责
        /// </summary>
        public abstract void LineOfDuty();
    }
}

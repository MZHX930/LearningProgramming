using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp._19Composite.Instance;

namespace ConsoleApp._19Composite
{
    /// <summary>
    /// 模式19  组合模式Composite
    /// 将对象组合成树状结构以表示“部分-整体”的层次结构。组合模式使得用户对单个对象和组合对象的使用具有一致性。
    /// 整体和部分可以被一致对待的问题
    /// 主干 - 分支 - 叶子 
    /// </summary>
    public class Pattern19
    {
        public void Run()
        {
            ConcreteCompany root = new ConcreteCompany("北京总公司");
            root.Add(new HRDepartment("总公司人力资源部"));
            root.Add(new FinanceDepartment("总公司财务部"));

            ConcreteCompany comp = new ConcreteCompany("上海华东分公司");
            comp.Add(new HRDepartment("华东分公司人力资源部"));
            comp.Add(new FinanceDepartment("华东分公司财务部"));
            root.Add(comp);

            ConcreteCompany comp1 = new ConcreteCompany("南京办事处");
            comp1.Add(new HRDepartment("南京办事处人力资源部"));
            comp1.Add(new FinanceDepartment("南京办事处财务部"));
            root.Add(comp1);

            ConcreteCompany comp2 = new ConcreteCompany("杭州办事处");
            comp2.Add(new HRDepartment("杭州办事处人力资源部"));
            comp2.Add(new FinanceDepartment("杭州办事处财务部"));
            root.Add(comp2);

            Console.WriteLine("\n 结构图：");
            root.Display(1);

            Console.WriteLine("\n 职责：");
            root.LineOfDuty();

            Console.Read();
        }
    }
}

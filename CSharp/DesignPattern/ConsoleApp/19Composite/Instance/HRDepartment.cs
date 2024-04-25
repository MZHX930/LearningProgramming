using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp._19Composite.Instance
{
    //人力资源部
    public class HRDepartment : Company
    {
        public HRDepartment(string name) : base(name)
        {
        }

        public override void Add(Company c) { }

        public override void Remove(Company c) { }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + name);
        }

        public override void LineOfDuty()
        {
            Console.WriteLine("{0} 员工招聘培训管理", name);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp._19Composite.Instance
{
    public class ConcreteCompany : Company
    {
        private List<Company> children = new List<Company>();

        public ConcreteCompany(string name) : base(name)
        {
        }

        public override void Add(Company c)
        {
            children.Add(c);
        }

        public override void Remove(Company c)
        {
            children.Remove(c);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + name);

            foreach (var compoent in children)
            {
                compoent.Display(depth + 2);
            }
        }

        public override void LineOfDuty()
        {
            foreach (var compoent in children)
            {
                compoent.LineOfDuty();
            }
        }


    }
}

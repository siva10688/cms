using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Opps
{
    internal abstract class ParentClass
    {
        public void Display()
        {
            Console.WriteLine("Normal Method");
        }

        public abstract void Add(int a, int b);
    }
}

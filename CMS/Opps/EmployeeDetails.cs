using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Opps
{
    internal class EmployeeDetails : Employee
    {
        public void IncrementBy2() {
            this.count += 2;
        }

        public new void Increment()
        {
            this.count += 10;
        }

        public override void Display()
        {
            //base.Display();
            Console.WriteLine("Child Display");
        }
    }
}

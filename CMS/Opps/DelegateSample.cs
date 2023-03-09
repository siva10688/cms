using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Opps
{
    public class DelegateSample
    {
        public delegate int SumDel(int a, int b);

        public void Display()
        {
            var del = new SumDel(this.Sum);
            del += this.Subtract;

            var list = del.GetInvocationList();

            foreach(var delItem in list)
            {
                Console.WriteLine(delItem.DynamicInvoke(10,20));
            }

            del -= this.Subtract;

            var list2 = del.GetInvocationList();

            foreach (var delItem in list2)
            {
                Console.WriteLine(delItem.DynamicInvoke(10, 20));
            }
        }

        public int Sum(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }
    }
}

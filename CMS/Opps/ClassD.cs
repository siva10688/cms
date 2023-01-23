using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Opps
{
    internal class ClassD : INotification
    {
        public void Sum(int a, int b)
        {
            Console.WriteLine(a + b);
        }
    }
}

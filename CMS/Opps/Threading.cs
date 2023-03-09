using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CMS.Opps
{
    internal class Threading
    {

        public void Function1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Function 1 executed " + i.ToString());
                Thread.Sleep(1000);
            }
        }
        public void Function2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Function 2 executed " + i.ToString());
                Thread.Sleep(1000);


                Thread obj1 = new Thread(Function1);
                Thread obj2 = new Thread(Function2);
                obj1.Start();
                obj2.Start();
            }
        }
    }
}

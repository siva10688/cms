﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Opps
{
    internal class ClassA : ParentClass
    {
        public override void Add(int a, int b)
        {
            var total = a + b;
            Console.WriteLine(total);
        }
    }
}

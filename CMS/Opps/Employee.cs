using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Opps
{
    internal partial class Employee
    {
        //private Employee()
        //{

        //}

        public Employee()
        {
        }

        public Employee(string name)
        {
            this.Name = name;
        }

        public static string title = "Welcome";

        //public static int count = 0;

        public int count = 0;

        public string company = "Agility";

        public string? Name { get; set; }

        public int Id { get; set; }

        public void Increment()
        {
            count++;
        }

        public void Increment(int value)
        {
            count += value;
        }

        public virtual void Display()
        {
            Console.WriteLine("Hello");
        }
    }
}

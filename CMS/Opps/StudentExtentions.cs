using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Opps
{
    internal static class StudentExtentions
    {
        public static string GetName(this List<Student> students)
        {
            var names = students.Select(s => s.Name).ToList();

            return string.Join(",", names);
        }
    }
}

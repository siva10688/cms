using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;



namespace CMS.Opps
{
    public   class  Student
    {
        int count = 0;

        public string? Name { get; set; }

        public int Id { get; set; }

        public void Linq()
        {

            List<Student> students = new List<Student> {
                                                      new Student{ Id=1,Name="ravi"},
                                                      new Student{ Id=2,Name="mohan" },
                                                      new Student{ Id=3,Name="rohan" },
                                                      new Student{ Id=4,Name="ravi" },
                                                      new Student{ Id=5,Name="venkat"}
            };

            students.GetName();

            var query = from s in students where s.Name == "ravi" select new Student { };


            var result = query.ToList();

            Console.WriteLine(result.Count());
        }

        public static void GetStudents()
        {
            List<Student> students = new List<Student> {
                                                      new Student{ Id=1,Name="ravi"},
                                                      new Student{ Id=2,Name="mohan" },
                                                      new Student{ Id=3,Name="rohan" },
                                                      new Student{ Id=4,Name="ravi" },
                                                      new Student{ Id=5,Name="venkat"}
            };

            var tempStudents = students
                .Where(s => s.Name == "ravi")
                .Select(s => new Student
                {
                    Name = s.Name,

                    
                }).OrderByDescending(s => s.Name);

        }

        public void AnonymusType()
        {
            var student = new
            {
                Id = 10,
                Name = "Raju"
            };

            Console.WriteLine(student.Id);

            //student.Id = 20;
        }
        
       
    }
}

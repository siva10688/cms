// See https://aka.ms/new-console-template for more information
using CMS.Opps;

Console.WriteLine("Hello, World!");

Console.WriteLine(Employee.title);
var employee = new Employee("Raju");
Console.WriteLine(employee.company);
Console.WriteLine(employee.Name);
employee.Increment();
employee.Increment();
employee.Increment(5);
employee.Welcome();
Console.WriteLine(employee.count);

var employee1 = new Employee();
Console.WriteLine(employee1.count);

Console.WriteLine("Employee Details");
var empDetails = new EmployeeDetails();
empDetails.Increment();
empDetails.Display();
Console.WriteLine(empDetails.count);
Console.WriteLine(empDetails.company);

Console.WriteLine("Abstract Classes");
//var parent = new ParentClass();

var a = new ClassA();
a.Add(10, 20);

var b = new ClassB();
b.Add(5, 6);

var d=new ClassD();
d.Sum(20, 20);

var s = new ClassS();
s.Display();
Console.ReadLine();
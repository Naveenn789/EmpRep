// See https://aka.ms/new-console-template for more information
using ConAppOne;

Console.WriteLine("Hello, World!");
List<Employee> employees = new List<Employee>()
{
     new Employee(){Id = 1,Name="Ram",Designation="Mangaer",Doj=new DateTime(day:12,month:11,year:2022) },
     new Employee(){Id = 2,Name="Sam",Designation="Tester",Doj=new DateTime(day:07,month:02,year:2020) },
     new Employee(){Id = 3,Name="Gagan",Designation="Devloper",Doj=new DateTime(day:29,month:05,year:2021) },
     new Employee(){Id = 4,Name="Simha",Designation="Tester",Doj=new DateTime(day:13,month:01,year:2018) },
     new Employee(){Id = 5,Name="Surya",Designation="Developer",Doj=new DateTime(day:02,month:12,year:2023) },
};
Console.WriteLine("ID\t Name\t Designation\t Date of Joing");

foreach (Employee emp in employees)
{
    Console.Write(emp.Id+"\t ");
    Console.Write(emp.Name + "\t ");
    Console.Write(emp.Designation + "\t\t");
    Console.Write(emp.Doj + "\t");
    Console.WriteLine("\n");
}

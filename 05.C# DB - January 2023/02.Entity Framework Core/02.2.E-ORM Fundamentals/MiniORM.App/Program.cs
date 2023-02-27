using MiniORM.App.Data;
using MiniORM.App.Data.Entities;

namespace MiniORM.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new SoftUniDbContext(Config.connectionString);

            context.Employees.Add(new Employee
            {
                FirstName = "Marto",
                LastName = "Simov",
                DepartmentId = context.Departments.First().Id,
                IsEmployed = true
            });

            var employee = context.Employees.Last();
            employee.FirstName = "Martin";

            context.SaveChanges();
        }
    }
}
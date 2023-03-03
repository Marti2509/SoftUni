using SoftUni.Data;
using SoftUni.Models;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace SoftUni;

public class StartUp
{
    static void Main(string[] args)
    {
        SoftUniContext dbContext = new SoftUniContext();
        Console.WriteLine(RemoveTown(dbContext));
    }

    // Problem 3
    public static string GetEmployeesFullInformation(SoftUniContext context)
    {
        StringBuilder sb = new StringBuilder();

        var employees = context.Employees
            .OrderBy(e => e.EmployeeId)
            .Select(e => new
            {
                e.FirstName,
                e.LastName,
                e.MiddleName,
                e.JobTitle,
                e.Salary
            })
            .ToList();

        foreach (var employee in employees)
        {
            sb.AppendLine($"{employee.FirstName} {employee.LastName} {employee.MiddleName} {employee.JobTitle} {employee.Salary:F2}");
        }

        return sb.ToString().TrimEnd();
    }

    // Problem 4
    public static string GetEmployeesWithSalaryOver50000(SoftUniContext context)
    {
        StringBuilder sb = new StringBuilder();

        var employees = context.Employees
            .Where(e => e.Salary > 50000)
            .OrderBy(e => e.FirstName)
            .Select(e => new
            {
                e.FirstName,
                Salary = e.Salary.ToString("F2")
            })
            .ToArray();

        foreach (var employee in employees)
        {
            sb.AppendLine($"{employee.FirstName} - {employee.Salary}");
        }

        return sb.ToString().TrimEnd();
    }

    // Problem 5
    public static string GetEmployeesFromResearchAndDevelopment(SoftUniContext context)
    {
        StringBuilder sb = new StringBuilder();

        var employees = context.Employees
            .Where(e => e.Department.Name == "Research and Development")
            .OrderBy(e => e.Salary)
            .ThenByDescending(e => e.FirstName)
            .Select(e => new
            {
                e.FirstName,
                e.LastName,
                e.Department.Name,
                Salary = e.Salary.ToString("F2")
            })
            .ToArray();

        foreach (var employee in employees)
        {
            sb.AppendLine($"{employee.FirstName} {employee.LastName} from {employee.Name} - ${employee.Salary}");
        }

        return sb.ToString().TrimEnd();
    }

    // Problem 6
    public static string AddNewAddressToEmployee(SoftUniContext context)
    {
        StringBuilder sb = new StringBuilder();

        Address address = new Address
        {
            AddressText = "Vitoshka 15",
            TownId = 4
        };

        var nakovEmployee = context.Employees
            .First(e => e.LastName == "Nakov");

        nakovEmployee.Address = address;

        context.SaveChanges();

        var addresses = context.Employees
            .OrderByDescending(e => e.AddressId)
            .Take(10)
            .Select(e => e.Address.AddressText)
            .ToArray();

        foreach (var currAddress in addresses)
        {
            sb.AppendLine(currAddress);
        }

        return sb.ToString().TrimEnd();
    }

    // Problem 7
    public static string GetEmployeesInPeriod(SoftUniContext context)
    {
        StringBuilder sb = new StringBuilder();

        var employees = context.Employees
            .Select(e => new
            {
                e.FirstName,
                e.LastName,
                ManagerFristName = e.Manager.FirstName,
                ManagerLastName = e.Manager.LastName,
                Projects = e.EmployeesProjects
                    .Where(p => p.Project.StartDate.Year >= 2001 && p.Project.StartDate.Year <= 2003)
                    .Select(p => new
                    {
                        p.Project.Name,
                        StartDateWithTime = p.Project.StartDate.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture),
                        EndDateWithTime = p.Project.EndDate.HasValue ? p.Project.EndDate.Value.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture) : "not finished"
                    })
            })
            .Take(10)
            .ToArray();

        foreach (var employee in employees)
        {
            sb.AppendLine($"{employee.FirstName} {employee.LastName} - Manager: {employee.ManagerFristName} {employee.ManagerLastName}");

            foreach (var project in employee.Projects)
            {
                sb.AppendLine($"--{project.Name} - {project.StartDateWithTime} - {project.EndDateWithTime}");
            }
        }

        return sb.ToString().TrimEnd();
    }

    // Problem 8
    public static string GetAddressesByTown(SoftUniContext context)
    {
        StringBuilder sb = new StringBuilder();

        var addresses = context.Addresses
            .Select(a => new
            {
                PeopleCount = a.Employees.Count,
                TownName = a.Town.Name,
                a.AddressText,
            })
            .OrderByDescending(a => a.PeopleCount)
            .ThenBy(a => a.TownName)
            .ThenBy(a => a.AddressText)
            .Take(10)
            .ToArray();

        foreach (var address in addresses)
        {
            sb.AppendLine($"{address.AddressText}, {address.TownName} - {address.PeopleCount} employees");
        }

        return sb.ToString().TrimEnd();
    }

    // Problem 9
    public static string GetEmployee147(SoftUniContext context)
    {
        StringBuilder sb = new StringBuilder();

        var employee = context.Employees
            .Find(147);

        sb.AppendLine($"{employee.FirstName} {employee.LastName} - {employee.JobTitle}");

        foreach (var project in employee.EmployeesProjects.OrderBy(p => p.Project.Name))
        {
            sb.AppendLine(project.Project.Name);
        }

        return sb.ToString().TrimEnd();
    }

    // Problem 10
    public static string GetDepartmentsWithMoreThan5Employees(SoftUniContext context)
    {
        StringBuilder sb = new StringBuilder();

        var departments = context.Departments
            .Where(d => d.Employees.Count > 5)
            .Select(d => new
            {
                DepartmentName = d.Name,
                EmployeesCount = d.Employees.Count,
                ManagerFirstName = d.Manager.FirstName,
                ManagerLastName = d.Manager.LastName,
                Employees = d.Employees
                    .Select(e => new
                    {
                        EmployeeFirstName = e.FirstName,
                        EmployeeLastName = e.LastName,
                        e.JobTitle
                    })
            })
            .OrderBy(d => d.EmployeesCount)
            .ThenBy(d => d.DepartmentName)
            .ToArray();

        foreach (var department in departments)
        {
            sb.AppendLine($"{department.DepartmentName} - {department.ManagerFirstName} {department.ManagerLastName}");

            foreach (var employee in department.Employees.OrderBy(e => e.EmployeeFirstName).ThenBy(e => e.EmployeeLastName))
            {
                sb.AppendLine($"{employee.EmployeeFirstName} {employee.EmployeeLastName} - {employee.JobTitle}");
            }
        }

        return sb.ToString().TrimEnd();
    }

    // Problem 11
    public static string GetLatestProjects(SoftUniContext context)
    {
        StringBuilder sb = new StringBuilder();

        var projects = context.Projects
            .OrderByDescending(p => p.StartDate)
            .Take(10)
            .Select(p => new
            {
                p.Name,
                p.Description,
                p.StartDate,
            })
            .OrderBy(p => p.Name)
            .ToArray();

        foreach ( var project in projects)
        {
            sb.AppendLine(project.Name);
            sb.AppendLine(project.Description);
            sb.AppendLine(project.StartDate.ToString("M/d/yyyy h:mm:ss tt"));
        }

        return sb.ToString().TrimEnd();
    }

    // Problem 12
    public static string IncreaseSalaries(SoftUniContext context)
    {
        StringBuilder sb = new StringBuilder();

        var employees = context.Employees
            .Where(e => e.Department.Name == "Engineering" ||
            e.Department.Name == "Tool Design" ||
            e.Department.Name == "Marketing" ||
            e.Department.Name == "Information Services")
            .OrderBy(e => e.FirstName)
            .ThenBy(e => e.LastName)
            .ToArray();

        foreach (var employee in employees)
        {
            employee.Salary += employee.Salary * 0.12m;

            sb.AppendLine($"{employee.FirstName} {employee.LastName} (${employee.Salary:f2})");
        }

        return sb.ToString().TrimEnd();
    }

    // Problem 13
    public static string GetEmployeesByFirstNameStartingWithSa(SoftUniContext context)
    {
        StringBuilder sb = new StringBuilder();

        var employees = context.Employees
            .Where(e => e.FirstName.StartsWith("Sa"))
            .OrderBy(e => e.FirstName)
            .ThenBy(e => e.LastName)
            .ToArray();

        foreach (var employee in employees)
        {
            sb.AppendLine($"{employee.FirstName} {employee.LastName} - {employee.JobTitle} - (${employee.Salary:F2})");
        }

        return sb.ToString().TrimEnd();
    }

    // Problem 14
    public static string DeleteProjectById(SoftUniContext context)
    {
        StringBuilder sb = new StringBuilder();

        var projectsWithId4 = context.EmployeesProjects
            .Where(p => p.ProjectId == 4)
            .ToArray();

        var projectWithId4 = context.Projects
            .Find(4);

        foreach (var project in projectsWithId4)
        {
            context.EmployeesProjects.Remove(project);
        }

        context.Projects.Remove(projectWithId4);

        context.SaveChanges();

        var projects = context.Projects
            .Take(10)
            .ToArray();

        foreach (var project in projects)
        {
            sb.AppendLine(project.Name);
        }

        return sb.ToString().TrimEnd();
    }

    // Problem 15
    public static string RemoveTown(SoftUniContext context)
    {
        var town = context.Towns
            .FirstOrDefault(t => t.Name == "Seattle");

        var addressesId = context.Addresses
            .Where(a => a.Town.Name == town.Name)
            .ToArray();

        int rowsAffected = addressesId.Count();

        var employees = context.Employees
            .ToArray();

        foreach (var employee in employees)
        {
            foreach (var addressId in addressesId)
            {
                if (employee.AddressId == employee.AddressId)
                {
                    employee.AddressId = null;
                }
            }
        }

        context.Addresses.RemoveRange(addressesId);

        context.Towns.Remove(town);

        context.SaveChanges();

        return $"{rowsAffected} addresses in Seattle were deleted";
    }
}
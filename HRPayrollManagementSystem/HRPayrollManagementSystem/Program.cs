using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRPayrollSystem
{
	internal class Program
	{
		static async Task Main(string[] args)
		{
			using (EmployeeRepository repo = EmployeeRepository.Instance)
			{
				repo.Add(new Employee("Alice", Designation.Manager, 50000, 10000, 2000));
				repo.Add(new Employee("Bob", Designation.Developer, 40000, 8000, 1000));
				repo.Add(new Employee("Charlie", Designation.HR, 30000, 5000, 500));
				repo.Add(new Employee("David", Designation.Accountant, 35000, 4000, 800));

				Console.WriteLine("All Employees:");
				foreach (var emp in repo)
				{
					Console.WriteLine($"\nID: {emp.Id}\n{emp.Name}, {emp.Role}, Net Salary: {emp.NetSalary:C}");
				}

				var bob = repo.FindByName("Bob");
				bob.Allowance = 10000;
				repo.Update(bob);

				var charlie = repo.FindByName("Charlie");
				repo.Remove(charlie);

				Console.WriteLine("\nAfter Update & Remove:");
				foreach (var emp in repo)
				{
					Console.WriteLine($"\nID: {emp.Id}\n{emp.Name}, {emp.Role}, Net Salary: {emp.NetSalary:C}");
				}

				var result = await repo.SearchAsync("Developer");
				Console.WriteLine("\nSearch Result:");
				foreach (var emp in result)
				{
					Console.WriteLine($"\nID: {emp.Id}\n{emp.Name}, {emp.Role}, Net Salary: {emp.NetSalary:C}");
				}
			}

			Console.ReadLine();
		}
	}
}

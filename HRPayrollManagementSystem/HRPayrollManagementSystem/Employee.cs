using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRPayrollSystem
{
	public enum Designation
	{
		Manager,
		Developer,
		HR,
		Accountant
	}

	internal class Employee : IModel
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public Designation Role { get; set; }
		public decimal BasicSalary { get; set; }
		public decimal Allowance { get; set; }
		public decimal Deduction { get; set; }
		public DateTime JoinDate { get; set; } = DateTime.Today;

		public decimal NetSalary => BasicSalary + Allowance - Deduction;

		public Employee(Guid? id = null)
		{
			Id = id ?? Guid.NewGuid();
		}

		public Employee(string name, Designation role, decimal basic, decimal allowance, decimal deduction, DateTime? joinDate = null) : this()
		{
			Name = name;
			Role = role;
			BasicSalary = basic;
			Allowance = allowance;
			Deduction = deduction;
			JoinDate = joinDate ?? DateTime.Now;
		}

		public void Dispose() { }
	}
}
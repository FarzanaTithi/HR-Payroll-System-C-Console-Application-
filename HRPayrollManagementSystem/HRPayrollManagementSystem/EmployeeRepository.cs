using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRPayrollSystem

{
	internal class EmployeeRepository : IRepository<Employee>, IDisposable
	{
		private static EmployeeRepository obj;

		public static EmployeeRepository Instance
		{
			get
			{
				if (obj == null)
				{
					obj = new EmployeeRepository();
				}
				return obj;
			}
		}

		private EmployeeRepository()
		{
			Data = new List<Employee>();
		}

		public List<Employee> Data { get; }

		public void Add(Employee employee) => Data.Add(employee);

		public Employee FindById(string id) => Data.Find(e => e.Id.ToString() == id);

		public Employee FindByName(string name) => Data.Find(e => e.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

		public bool Remove(Employee employee) => Data.Remove(employee);

		public bool Update(Employee employee)
		{
			var index = Data.FindIndex(e => e.Id == employee.Id);
			if (index == -1) return false;
			Data[index] = employee;
			return true;
		}

		public List<Employee> Search(string text)
		{
			return Data.Where(e =>
				e.Name.IndexOf(text, StringComparison.OrdinalIgnoreCase) >= 0 ||
				e.Role.ToString().IndexOf(text, StringComparison.OrdinalIgnoreCase) >= 0 ||
				e.Id.ToString().Contains(text) ||
				e.NetSalary.ToString() == text).ToList();
		}

		public Task<List<Employee>> SearchAsync(string text) => Task.FromResult(Search(text));

		public IEnumerator<Employee> GetEnumerator() => Data.GetEnumerator();

		IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

		public void Dispose() => Data.Clear();
	}
}
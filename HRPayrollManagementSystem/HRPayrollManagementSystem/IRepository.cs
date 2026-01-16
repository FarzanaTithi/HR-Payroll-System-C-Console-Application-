using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRPayrollSystem
{
	internal interface IRepository<T> : IEnumerable<T> where T : IModel
	{
		void Add(T item);
		T FindById(string id);
		T FindByName(string name);
		bool Remove(T item);
		bool Update(T item);
		List<T> Search(string text);
		Task<List<T>> SearchAsync(string text);
	}
}
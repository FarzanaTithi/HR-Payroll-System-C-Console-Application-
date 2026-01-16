using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRPayrollSystem
{
	internal interface IModel : IDisposable
	{
		Guid Id { get; set; }
	}
}

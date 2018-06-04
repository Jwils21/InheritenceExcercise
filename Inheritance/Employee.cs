using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance {
	class Employee {

		public string Name { get; set; }
		public string Position { get; set; }
		public decimal Salary { get; set; }
		public Manager Manager { get; set; }
		public int VacationDays { get; set; }
		
		private int EmployeeOnly = 0;

		protected void GiveRaise(Employee Employee, decimal RaiseAmount) {
			Employee.Salary += RaiseAmount;
		}

		public virtual string Print() {
			return $"Employee: {Name}, Salary: ${Salary}";
		}
	}
}

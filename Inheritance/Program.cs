using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance {
	class Program {
		static void Main(string[] args) {


			Employee Jonathan = new Employee() {
				Name = "Jonathan",
				Position = "Analyst",
				Salary = 60000,
				VacationDays = 15
			};
			

			Employee Aaron = new Employee() {
				Name = "Aaron",
				Position = "Associate",
				Salary = 75000,
				VacationDays = 20

			};

			Manager Jerry = new Manager() {
				Name = "Jerry",
				Position = "VP",
				PurchaseAuth = 500000,
				Salary = 150000,
				VacationDays = 25
			};

			Manager Ryan = new Manager() {
				Name = "Ryan",
				Position = "Director",
				Salary = 90000,
				VacationDays = 20,
				PurchaseAuth = 100000,
			};

			Administrator Sarah = new Administrator() {
				Name = "Sarah",
				Position = "Administrator",
				Salary = 80000,
				Manager = Jerry,
				AssignedTo = Ryan,
				VacationDays = 18
			};
			//Jonathan.Print();
			//Aaron.Print();
			//Ryan.Print();
			//Jerry.Print();


			Jonathan.Manager = Ryan;
			Aaron.Manager = Ryan;
			Ryan.Manager = Jerry;

			List<Employee> employees = new List<Employee>();
			employees.Add(Jonathan);
			employees.Add(Aaron);
			employees.Add(Sarah);
			employees.Add(Ryan);
			employees.Add(Jerry);

			foreach(Employee employee in employees) {
				string msg = employee.Print();
				Console.WriteLine(msg);

			}

		}
	}
}

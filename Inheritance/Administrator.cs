using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance {
	class Administrator : Employee {
		//Assistant to another manager
		public Manager AssignedTo { get; set; }

		public override string Print() {
			string msg = base.Print();
			return $"Administrator: Assigned to {AssignedTo.Name}" + msg;
		}

	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2NicholasNieto 
{
    class SalaryEmployee : Employee
    {


        public double Salary { get; private set; }
        public SalaryEmployee(string name, typeOfEmployee empType, double salary) : base(name, empType)
        {
            Salary = salary;
        }


        public override double grossEarnings()
        {
            return Salary;
        }

    }
}

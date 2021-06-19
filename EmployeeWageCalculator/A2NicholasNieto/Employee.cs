using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2NicholasNieto
{


    public enum typeOfEmployee
    { SalariedEmployee, HourlyEmployee, ComissionEmployee }

   public abstract class Employee
    {
        public string EmpName { get; private set; }
      
        public typeOfEmployee EmpType { get; private set; }

      
        public double NetEarnings { get { return grossEarnings() - getTax(); } }

        public abstract double grossEarnings();

        public double Tax
        { get { return getTax(); } }



    public Employee(string name, typeOfEmployee employeeType)
        {

            EmpName = name;
            EmpType = employeeType;
     
        }


       private double getTax()
        {
          return  grossEarnings() * 0.2;

        }
    }

}

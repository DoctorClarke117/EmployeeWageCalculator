using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2NicholasNieto
{
    class HourlyEmployee : Employee
    {
        public int Hours { get; private set; }
        public double Wage { get; private set; }

        public HourlyEmployee(string name, typeOfEmployee empType, int hours, double
           wage) : base(name, empType)

        {
            Hours = hours;
            Wage = wage;
        }

        public override double grossEarnings()
        {
            if (Hours <= 40)
                return Hours * Wage;
            else
                return (40 * Wage) + (Hours - 40) * Wage * 1.5;
        }


    }
}

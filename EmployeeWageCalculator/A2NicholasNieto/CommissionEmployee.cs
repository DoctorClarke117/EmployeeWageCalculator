using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2NicholasNieto
{
    class CommissionEmployee : Employee
    {
        public double GrossSales { get; private set; }
        public double CommissionRate { get; private set; }


        public CommissionEmployee(string name, typeOfEmployee empType, double grossSales, double commissionRate) :
        base(name, empType)
        {
            GrossSales = grossSales;
            CommissionRate = commissionRate;

        }

        public override double grossEarnings()
        {
            return GrossSales * CommissionRate;
        }



    }
}

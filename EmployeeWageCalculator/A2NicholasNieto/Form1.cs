using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A2NicholasNieto
{
    public partial class Form1 : Form
    {
        private List<Employee> employeeList;
     

        public Form1()
        {
            InitializeComponent();
            employeeList = new List<Employee>();
           
        }

        private void calculate_Click(object sender, EventArgs e)
        {

          

            if (empName.Text == "")
            {
              
                MessageBox.Show("No fields cannot be empty");
                empName.Text = "Employee";


            }
            else if (hourlyWage.Text == "")
            {
                MessageBox.Show("No fields cannot be empty");
            }
            else if(hoursWorked.Text == "")
            {
                MessageBox.Show("No field's cannot be empty");
            }
            else

            if (hourlyPay.Checked)
            {

                int hours = int.Parse(hoursWorked.Text);
                double wage = double.Parse(hourlyWage.Text);
                string name = empName.Text;


                
                if (hours < 0 || wage < 0)
                {
                    MessageBox.Show("Enter a positive number");

                } 

                else if (hours > 80)
                {
                    MessageBox.Show("Hours worked cannot be more than 80");
                }
                else

                {

                    Employee hourly = new HourlyEmployee(name, typeOfEmployee.HourlyEmployee, hours, wage);
                    employeeList.Add(hourly);

                    listEmployees.Items.Add(hourly.EmpName);
                    lessTax.Text = hourly.Tax.ToString("C");
                    grossEarnings.Text = hourly.grossEarnings().ToString("C");
                    netEarnings.Text = hourly.NetEarnings.ToString("C");

                }

                }
            else if (commissionBased.Checked)
                {

                    typeOfEmployee commission = typeOfEmployee.ComissionEmployee;
                    double rate = double.Parse(hourlyWage.Text);
                    double sales = double.Parse(hoursWorked.Text);
                    string name = empName.Text;




                    CommissionEmployee comm = new CommissionEmployee(name, commission, sales, rate);
                    employeeList.Add(comm);
                    listEmployees.Items.Add(comm.EmpName);
                    lessTax.Text = comm.Tax.ToString("C");
                    grossEarnings.Text = comm.grossEarnings().ToString("C");
                    netEarnings.Text = comm.NetEarnings.ToString("C");


                }
                else if (weeklySalary.Checked)
                {

                    typeOfEmployee salary = typeOfEmployee.SalariedEmployee;
                    double salaryRate = double.Parse(hoursWorked.Text);
                    string name = empName.Text;




                    SalaryEmployee salaried = new SalaryEmployee(name, salary, salaryRate);
                    employeeList.Add(salaried);
                    listEmployees.Items.Add(salaried.EmpName);
                    lessTax.Text = salaried.Tax.ToString("C");
                    grossEarnings.Text = salaried.grossEarnings().ToString("C");
                    netEarnings.Text = salaried.NetEarnings.ToString("C");

                }





            

        }

        private void commissionBased_CheckedChanged(object sender, EventArgs e)
        {
            lblHours.Text = "Gross Sales";
            lblWage.Text = "Commission Rate";

        }

        private void weeklySalary_CheckedChanged(object sender, EventArgs e)
        {

            lblHours.Text = "Weekly Salary";
            lblWage.Hide();
            hourlyWage.Hide();

        }

        private void hourlyPay_CheckedChanged(object sender, EventArgs e)
        {
            lblHours.Text = "Hours Worked";
            lblWage.Text = "Hourly Wage";
            lblWage.Show();
            hourlyWage.Show();

        }

        private void listEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {

        

            int i = listEmployees.SelectedIndex;
            
               
                    if (employeeList[i].EmpType == typeOfEmployee.HourlyEmployee)
                    {

                    HourlyEmployee hourly = (HourlyEmployee)employeeList[i];
                    empName.Text = hourly.EmpName;
                    hoursWorked.Text = hourly.Hours.ToString();
                    hourlyWage.Text = hourly.Wage.ToString();
                    grossEarnings.Text = hourly.grossEarnings().ToString("C");
                    lessTax.Text = hourly.Tax.ToString("C");
                    netEarnings.Text = hourly.NetEarnings.ToString("C");
                


                    }else if (employeeList[i].EmpType == typeOfEmployee.ComissionEmployee)
                   {

                    CommissionEmployee comm = (CommissionEmployee)employeeList[i];
                    empName.Text = comm.EmpName;
                    hoursWorked.Text = comm.CommissionRate.ToString("C");
                    hourlyWage.Text = comm.GrossSales.ToString("C");
                    grossEarnings.Text = comm.grossEarnings().ToString("C");
                    lessTax.Text = comm.Tax.ToString("C");
                    netEarnings.Text = comm.NetEarnings.ToString("C");



                  } else if (employeeList[i].EmpType == typeOfEmployee.SalariedEmployee)

                 {


                    SalaryEmployee sal = (SalaryEmployee)employeeList[i];
                    empName.Text = sal.EmpName;
                    hoursWorked.Text = sal.Salary.ToString("C");
                    grossEarnings.Text = sal.grossEarnings().ToString("C");
                    lessTax.Text = sal.Tax.ToString("C");
                    netEarnings.Text = sal.NetEarnings.ToString("C");




            }

        }

        private void clearAll_Click(object sender, EventArgs e)
        {
            empName.Text = "";
            hoursWorked.Text = "";
            grossEarnings.Text = "";
            netEarnings.Text = "";
            hourlyWage.Text = "";
            lessTax.Text = "";
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

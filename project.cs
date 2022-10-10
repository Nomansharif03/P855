using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication50
{

    public class SalarySlip
    {
        static void Main(string[] args)
        {
            int designation;
            Console.WriteLine(" Choose your designation");
            Console.WriteLine(" 1. Engineer " + " 2. Manager " + " 3. Hr");
            designation = int.Parse(Console.ReadLine());
            
            if (designation == 1)
            {
                Employee employee = new Engineer();
                Console.WriteLine(employee.GetSalary());
            }
            else if(designation == 2){
                Employee employee = new Manager();
                Console.WriteLine(employee.GetSalary());
            }
            else if (designation == 3)
            {
                Employee employee = new Hr();
                Console.WriteLine(employee.GetSalary());
            }
            Console.WriteLine();
            Console.ReadLine();
        }

    }
    public class Employee
    {
        public float BaseSalary;
        public float FuelAllowance;
        public float MedicalAllowance;
        public Employee()
        {
            BaseSalary = 1500;
        }
        public virtual float GetSalary()
        {
            return BaseSalary;
        }
    }
    public class Engineer : Employee
    {
        public override float GetSalary()
        {
            return 7000f / 12 + base.GetSalary();

        }
    }

    public class Manager : Employee
    {
        public Manager()
        {
            FuelAllowance = 250;
            MedicalAllowance = 1000;
        }
        public override float GetSalary()
        {

            return base.GetSalary() + FuelAllowance + MedicalAllowance - 0.17f * base.GetSalary();
        }
    }
    public class Hr : Employee
    {
        public Hr()
        {
            MedicalAllowance = 800;
            FuelAllowance = 150;
        }
        public override float GetSalary()
        {
            return 0.10f * (FuelAllowance + MedicalAllowance) + MedicalAllowance + FuelAllowance + base.GetSalary();

        }
    }
}


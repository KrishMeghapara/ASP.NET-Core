using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Staff
    {
        String Name;
        String Department;
        String Designation;
        int Experience;
        int Salary;

        public void GetStaffDetails()
        {
           
            Name = Console.ReadLine();
            Department = Console.ReadLine();
            Designation = Console.ReadLine();
            Experience = Convert.ToInt32(Console.ReadLine());
            Salary = Convert.ToInt32(Console.ReadLine());
        }
        public void DisplayStaff()
        {
            if (Designation == "HOD") {
                Console.WriteLine(Name);
                Console.WriteLine(Salary);
            }
        }
    }
}

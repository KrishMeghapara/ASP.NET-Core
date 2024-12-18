using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Student
    {
        long Enrollment_No;
        String Student_Name;
        int Semester;
        Double Spi;
        Double cpi;

         public Student()
        {
            Enrollment_No = Convert.ToInt64(Console.ReadLine());
            Student_Name = Console.ReadLine();
            Semester = Convert.ToInt32(Console.ReadLine());
            Spi = Convert.ToDouble(Console.ReadLine());
            cpi = Convert.ToDouble(Console.ReadLine());

        }

        public void DisplayStudent()
        {
            Console.WriteLine(Enrollment_No);
            Console.WriteLine(Student_Name);
            Console.WriteLine(Semester);
            Console.WriteLine(Spi);
            Console.WriteLine(cpi);
                
        }

    }
}

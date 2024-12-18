using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Candidate c1 = new Candidate();
            c1.GetCandidateDetails();
            c1.DisplayCandidateDetails();

            Staff[] staff = new Staff[5];
            for (int i = 0; i < staff.Length; i++) {
                staff[i]=new Staff();
                staff[i].GetStaffDetails();

            }
            for (int i = 0; i < staff.Length; i++)
            {
                staff[i].DisplayStaff();

            }

            Bank_Account account = new Bank_Account();
            account.GetBank_AccountDetails();
            account.DisplayBank_AccountDetails();

            Student student = new Student();
            student.DisplayStudent();

            AreaOfRectangle areaOfRectangle = new AreaOfRectangle();    

        }
    }
}

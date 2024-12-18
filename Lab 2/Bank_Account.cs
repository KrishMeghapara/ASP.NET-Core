using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab2
{
    internal class Bank_Account
    {
        int Account_No;
        String Email;
        String User_Name;
        String Account_Type;
        int Account_Balance;

        public void GetBank_AccountDetails()
        {
            Account_No = Convert.ToInt32(Console.ReadLine());
            Email = Console.ReadLine();
            User_Name = Console.ReadLine();
            Account_Type = Console.ReadLine();
            Account_Balance = Convert.ToInt32(Console.ReadLine());
        }
        public void DisplayBank_AccountDetails()
        {
            Console.WriteLine(Account_No);
            Console.WriteLine(Email);
            Console.WriteLine(User_Name);
            Console.WriteLine(Account_Type);
            Console.WriteLine(Account_Balance);

        }
    }
}

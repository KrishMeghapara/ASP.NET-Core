using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Lab_2
{
    internal class Account_Details
    {
        public string AccountNumber;
        public string AccountHolder;
        public double PrincipalAmount;
        public double InterestRate;

        public Account_Details()
        {
           int AccountNumber = Convert.ToInt32(Console.ReadLine());
           String AccountHolder = Console.ReadLine();
           int PrincipalAmount = Convert.ToInt32(Console.ReadLine());
            int InterestRate = Convert.ToInt32(Console.ReadLine());
        }

        public void DisplayAccountDetails()
        {
            Console.WriteLine("Account Number: " + AccountNumber);
            Console.WriteLine("Account Holder: " + AccountHolder);
            Console.WriteLine("Principal Amount: " + PrincipalAmount);
            Console.WriteLine("Interest Rate: " + InterestRate + "%");
        }
    }

    class Interest : Account_Details
    {
        public int TimePeriod;

        public Interest()
        {
           int TimePeriod = Convert.ToInt32(Console.ReadLine());
        }
        public double CalculateTotalInterest()
        {
            double interest = (PrincipalAmount * InterestRate * TimePeriod) / 100;
            return interest;
        }

        public void DisplayTotalInterest()
        {
            double interest = CalculateTotalInterest();
            Console.WriteLine("Total Interest for " + TimePeriod + " years: " + interest);
        }
    }
}




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Candidate
    {
        int Id;
        string Name;
        int Age;
        int Weight;
        int Height;

        public void GetCandidateDetails()
        {
            Id = Convert.ToInt32(Console.ReadLine());
            Name = Console.ReadLine();
            Age = Convert.ToInt32(Console.ReadLine());
            Weight = Convert.ToInt32(Console.ReadLine());
            Height = Convert.ToInt32(Console.ReadLine());
        }
        public void DisplayCandidateDetails()
        {
            Console.WriteLine(Id);
            Console.WriteLine(Name);
            Console.WriteLine(Age);
            Console.WriteLine(Weight);
            Console.WriteLine(Height);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Distance
    {
        int dist1;
        int dist2;
        int dist3;
        public Distance() { 
             dist1 = Convert.ToInt32(Console.ReadLine()); 
             dist2 = Convert.ToInt32(Console.ReadLine());
        }
        public void CalculateDistance() 
        {
             dist3 = dist1 + dist2;
        }
        public void DisplayDistance(){
            Console.WriteLine(dist1);
            Console.WriteLine(dist2);
            Console.WriteLine(dist3);
        }
    }
}

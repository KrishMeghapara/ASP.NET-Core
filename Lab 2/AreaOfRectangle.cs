using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class AreaOfRectangle
    {
        int Weight;
        int Height;
        public AreaOfRectangle() {
            Weight = Convert.ToInt32(Console.ReadLine());
            Height = Convert.ToInt32(Console.ReadLine());

            long Area = Weight * Height;
            Console.WriteLine(Area);
        }
    }
}

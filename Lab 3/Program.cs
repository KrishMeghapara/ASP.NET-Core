using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            zeroException z1 = new zeroException();
            IndexOutOfRangeException z2 = new IndexOutOfRangeException();
            Calculate c1 = new Calculate();
            Result r1 = new Result();
            StringClassMethods s2 = new StringClassMethods();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class StringClassMethods
    {
        public StringClassMethods() {
            String a = "Rudra Parsaniya";

            Console.WriteLine(a.ToLower());
            Console.WriteLine(a.ToUpper());
            Console.WriteLine(a.Substring(2));
            Console.WriteLine(a.Reverse());


        }
    }
}

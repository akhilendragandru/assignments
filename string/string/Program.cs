using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "HelloWorld this is c#";
            string s1 = "HelloWorld this is c#";
            int length = s.Length;




            Console.WriteLine("The length of Str are {0}", length);
            Console.WriteLine("The equal of Str are {0}", s.Equals(s1));
            Console.ReadLine();
        }
    }
}

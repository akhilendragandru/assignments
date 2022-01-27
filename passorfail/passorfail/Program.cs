using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passorfail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter marks for the Subjects \n 1:C# \n 2:HTML \n 3:SQL ");
            int m1 = Convert.ToInt32(Console.ReadLine());
            int m2 = Convert.ToInt32(Console.ReadLine());
            int m3 = Convert.ToInt32(Console.ReadLine());

            int avg = average(m1, m2, m3);
            Console.WriteLine(" AVAERAGE IS " + avg);
            if (avg > 50)
            {
                Console.WriteLine("PASSED");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("FAILED");
                Console.ReadLine();
            }
        }
        static int average(int c, int h, int s)
        {
            return (c + h + s) / 3;
            
        }
    }
}

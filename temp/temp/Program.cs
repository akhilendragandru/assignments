using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the TEMPERATURE in Farenhite");
            float temp = Convert.ToSingle(Console.ReadLine());

            float cel = celcius(temp);
            Console.WriteLine("TEMPERATURE in DEGREE CELCIUS is" + cel);
            Console.ReadLine();

        }
        static float celcius(float t)
        {
            return (t - 32) * 5 / 9;
        }
      
    }
}

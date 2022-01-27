using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace min_max_avg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < a.Length; i++)
            {

                sum = sum + a[i];
            }
            int avg = sum / a.Length;
            Console.WriteLine("AVERAGE of ARRAY IS " + avg);
            Console.WriteLine("MAXIMUM VALUE IS " + a.Max());
            Console.WriteLine("MINIMUM VALUE IS " + a.Min());
            Console.ReadLine();
        }
    }
}

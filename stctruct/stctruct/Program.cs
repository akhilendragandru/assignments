using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    class structureex
    {

        struct employee
        {
            public string eName;
            public DOB Date;
        }

        struct DOB
        {
            public int Date;
            public int Month;
            public int Year;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Create a nested structure and store data in an array :");
            Console.WriteLine("-------------------------------------------------------");
            employee[] emp = new employee[2];

            for (int i = 0; i < 2; i++)
            {
                Console.Write("Name of the employee : ");
                string nm = Console.ReadLine();
                emp[i].eName = nm;

                Console.Write("Enter day of birth : ");
                int d = Convert.ToInt32(Console.ReadLine());
                emp[i].Date.Date = d;

                Console.Write("Enter month of birth : ");
                int m = Convert.ToInt32(Console.ReadLine());
                emp[i].Date.Month = m;

                Console.Write("Enter year for birth : ");
                int y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                emp[i].Date.Year = y;
            }
            Console.Read();
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_marks
{
    class studentsmarks
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the stuudent name and his marks:");
            int n = 5;
            string name;
            int chash, sql, html;
            int tot, avg;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter name:");
                name = Console.ReadLine();
                Console.WriteLine("Enter chash marks:");
                chash = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter sql marks:");
                sql = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter html marks:");
                html = Convert.ToInt32(Console.ReadLine());

                tot = chash + sql + html;
                avg = tot / n;
                Console.WriteLine("{0} total is:", tot);
                Console.WriteLine("{0} average is:", avg);


                if (avg > 50)
                {
                    Console.WriteLine("passed");
                }
                else
                {
                    Console.WriteLine("Failed");
                }

            }
        }
    }
}


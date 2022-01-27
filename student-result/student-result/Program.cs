﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_result
{
     class Student
     {
            private string rollno;
            string name;
            string Class;

            public void GetData()
            {
                Console.WriteLine("Enter roll no");
                rollno = Console.ReadLine();
                Console.WriteLine("Enter name");
                name = Console.ReadLine();
                Console.WriteLine("Enter class");
                Class = Console.ReadLine();
            }

            public void PutData()
            {
                Console.WriteLine("name of student=" + name);
                Console.WriteLine("rollnumber=" + rollno);
                Console.WriteLine("class=" + Class);
            }
        }
        class Marks : Student
        {
            protected int[] a = new int[5];
            public void GetMarks()
            {
                for (int i = 0; i < a.Length; i++)
                {
                    Console.Write("Enter subject {0} Marks:", i + 1);// to enter marks in the subject
                    a[i] = Convert.ToInt32(Console.ReadLine());
                }
            }


            public void PutMarks()
            {
                for (int i = 0; i < a.Length; i++)
                {
                    Console.WriteLine("Marks in subject {0} : {1}", i + 1, a[i]);
                }
            }
        }

        class Results : Marks
        {
            int TotalMarks = 0;
            int avg;

            public void GetResult()
            {
                for (int i = 0; i < a.Length; i++)
                {
                    TotalMarks = TotalMarks + a[i];


                    avg = TotalMarks / 5;

                }

            }

            public void DisplayResult()
            {
                Console.WriteLine("===========Result==========");

                PutData();
                PutMarks();
                Console.WriteLine("Total Marks =" + TotalMarks);
                Console.WriteLine("avg =" + avg);
                if (avg > 50)
                {
                    Console.WriteLine("student is passed");
                }
                else
                {
                    Console.WriteLine("Student is failed");
                }
            }
        }


        class Students
        {
            static void Main(string[] args)
            {
                Results result = new Results();
                result.GetData();
                result.GetMarks();
                result.GetResult();
                result.DisplayResult();
                Console.Read();

            }
        }
}

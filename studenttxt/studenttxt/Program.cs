using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studenttxt
{
    internal class Program
    { 
        static void Main(string[] args)
    { 
             interface IStudent
             { 
            int StudentId
            {
                get;
                set;
            }
            string Std_Name
            {
                get;
                set;
            }

            void ShowDetails();
        }

        class Dayscholar : IStudent
        {
            int Sch_id;
            string Sch_name;
            public int StudentId
            {
                get
                {
                    return Sch_id;
                }
                set
                {
                    Sch_id = value;
                }
            }
            public string Std_Name
            {
                get
                {
                    return Sch_name;
                }
                set
                {
                    Sch_name = value;
                }
            }
            public void ShowDetails()
            {
                Console.WriteLine("Scholar Id : {0}", Sch_id);
                Console.WriteLine("Scholar Name : {0}", Sch_name);
            }
        }

        class Resident : IStudent
        {
            int Res_id;
            string Res_name;
            public int StudentId
            {
                get
                {
                    return Res_id;
                }
                set
                {
                    Res_id = value;
                }
            }
            public string Std_Name
            {
                get
                {
                    return Res_name;
                }
                set
                {
                    Res_name = value;
                }
            }
            public void ShowDetails()
            {
                Console.WriteLine("Resedent Id : {0}", Res_id);
                Console.WriteLine("Resedent Name : {0}", Res_name);
            }
        }


        class Program
        {
            static void Main(string[] args)
            {
                IStudent ds = new Dayscholar();
                ds.StudentId = 564783;
                ds.Std_Name = "akhil";
                ds.ShowDetails();
                IStudent res = new Resident();
                res.StudentId = 443;
                res.Std_Name = "gandru";
                res.ShowDetails();
                Console.Read();
            }
        }
    }
}




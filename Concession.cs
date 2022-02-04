using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concession
{
    public class Concession
    {
        int Tf = 500, age;
        double Cf, Fare;
        public void CalculateConcession1()
        {
            Console.WriteLine("Enter  Citizen  age");
            age = Convert.ToInt32(Console.ReadLine());
            if (age <= 5)
            {
                Console.WriteLine("Littel Champs - Free Ticket");
            }
            else if (age > 60)
            {
                Cf = Tf * 0.03;
                Fare = Tf - Cf;
                Console.WriteLine("Senior Citizens to pay:{0}", Fare);
            }
            else
            {
                Console.WriteLine("Ticket Booked With the payment of {0}", Tf);
            }
        }
    }
}

for testing and linked to the library

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculateConcession;

namespace Assignment__4
{
    class Test
    {
        static void Main()
        {
            String Name;
            Console.WriteLine("Enter Name of the Citizen");
            Name = Console.ReadLine();
            Concession cc = new Concession();
            cc.CalculateConcession1();
        }
    }
}

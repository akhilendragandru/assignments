using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Exception
{
    class PassangerException : ApplicationException
    {
        public PassangerException(string msg) : base(msg)
        {



        }
    }



    class Passanger
    {
        int age;
        string name;
        public int noofticket;
        public void TicketBooking(int noticket)
        {
            noofticket = noticket;

            if (noofticket > 5)
            {
                throw (new PassangerException("cannot book more than 2 tickets"));
            }
            else
                Console.WriteLine("Ticket Booked Successfully");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Passanger v = new Passanger();
            int noof = int.Parse(Console.ReadLine());
            try
            {
                v.TicketBooking(noof);
            }
            catch (PassangerException ve)
            {
                Console.WriteLine(ve.Message + " " + ve.Source);
            }
            Console.Read();



        }
    }
}

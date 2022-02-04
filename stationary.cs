using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stationary
{
    class Stationary
    {
        static void Main()
        {
            List<string> Stat = new List<string>();
            Stat.Add("Pencil");
            Stat.Add("Pen");
            Stat.Add("Scale");
            Stat.Add("Sharpner");
            Stat.Add("dot");
            Stat.Add("Book");
            Console.WriteLine("The Added Items are:");
            foreach (var item in Stat)
            {

                Console.WriteLine(item);
            }
            Console.Read();
        }
    }
}

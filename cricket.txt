using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cricket
{
    class Cricket
    {
        public int n;
        void Pointscalculation(int no_of_matches)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("team {0} scores", i + 1);
                for (int j = 0; j < no_of_matches; j++)
                {
                    Console.WriteLine("enter scores of {0} match", j + 1);
                    list.Add(int.Parse(Console.ReadLine()));
                }
                int sum = 0, count = 0;
                foreach (int j in list)
                {
                    sum = sum + j;
                    count++;
                }
                display();
                void display()
                {
                    float f = (float)sum / count;
                    Console.WriteLine("team number {0} sum :{1} and avg is :{2}", i + 1, sum, f);
                }

                list.Clear();
            }
        }
        static void Main(string[] args)
        {
            Cricket cricket = new Cricket();
            Console.WriteLine("enter number of teams");
            cricket.n = int.Parse(Console.ReadLine());
            Console.WriteLine("enter number of matches");
            int matchs = int.Parse(Console.ReadLine());
            cricket.Pointscalculation(matchs);
            Console.Read();
        }
    }
}
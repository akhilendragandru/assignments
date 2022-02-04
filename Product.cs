using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace produts
{
    class Products
    {
        static void Main()
        {
            int ProductID;
            string ProductName;
            SortedList<double, string> product = new SortedList<double, string>();
            Console.WriteLine("Enter 10 Products Details:");
            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine("Enter product {0} Price and Product {1} Name", i + 1, i + 1);
                product.Add(Convert.ToDouble(Console.ReadLine()), Console.ReadLine());
            }
            Console.WriteLine("After sorting the deatils of products are:");
            foreach (KeyValuePair<double, string> prod in product)
            {
                Console.WriteLine("Product name: {1} Productprice: {0}", prod.Key, prod.Value);
            }
            Console.Read();
        }
    }
}

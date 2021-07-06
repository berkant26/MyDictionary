using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> customer = new Dictionary<int, string>();
            customer.Add(22,"berkant");
            Console.WriteLine(customer.Lenght);

            customer.Add(25,"berkant");
            Console.WriteLine(customer.Lenght);
        }
    }
}

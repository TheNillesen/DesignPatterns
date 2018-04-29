using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program 
    {
     
        static void Main(string[] args)
        {

            var Database = SingletonDatabase.Instance;
            var city = "Tokyo";
            Console.WriteLine($"{city} has pop {Database.GetPopulation(city)}");
            Console.ReadKey();

        }

        
    }
}

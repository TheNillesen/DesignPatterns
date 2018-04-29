using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoreLinq;

namespace DesignPatterns
{
    class SingletonDatabase : IDatabase
    {

        private Dictionary<string, int> capitals;

        private static Lazy<SingletonDatabase> instance =
            new Lazy<SingletonDatabase>(() => new SingletonDatabase());
        

        public static SingletonDatabase Instance => instance.Value;

        private SingletonDatabase()
        {

            Console.WriteLine("Initiallizing Database");
            //Der bliver brugt Morelinq for at kunne buffer flere elementer sammen.
            capitals = File.ReadAllLines("Capitals.txt")
                .Batch(2)
                .ToDictionary(
                    list => list.ElementAt(0).Trim(),
                    list => int.Parse(list.ElementAt(1))
                );
        }



        public int GetPopulation(string name)
        {
            return capitals[name];
        }

       
    }
}

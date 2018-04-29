using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var cb = new CodeBuilder();

            cb.AppendLine("class Foo")
                .AppendLine("{")
                .AppendLine("}");

            Console.WriteLine(cb);
            Console.ReadKey();

        }
    }
}

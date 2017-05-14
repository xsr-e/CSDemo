using System;
using System.Linq;

namespace Linq2Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            var tableOfInts = Enumerable.Range(1, 20);
            
            //1. foreach
            foreach (var i in tableOfInts)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            //2. Linq Extension methods
            tableOfInts
                .Where(l => l % 2 == 0)
                .ToList()
                .ForEach(Console.WriteLine);

            //3. Query expressions
            var q = from l in tableOfInts
                    where l % 2 == 0
                    select l;

            q
                .ToList()
                .ForEach(Console.WriteLine);


        }
    }
}

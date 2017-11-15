using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Set set = new Set();
            Set set2 = new Set();
            set.Add(1);
            set.Add(2);
            set.Add(1);
            set.Add(5);
            set.Remove(1);
            set.Remove(-500);
            set.Add(-852);
            set2.Add(5);
            set2.Add(1);

            if (set > set2)
                Console.WriteLine("set Contains set2[0]");
            set.Add(1);

            if (set < set2)
                Console.WriteLine("set contains set2");
            set2.Add(55555);
            if (set < set2)
                Console.WriteLine("set contains set2");

            Console.WriteLine("FIRST: "+ set.First());
            Set.RemovePositive(ref set);

            MathObject.Truncate(ref set);

            Console.WriteLine("MIN: " + MathObject.Min(set2));

            Console.WriteLine("MAX: " + MathObject.Max(set2));

            Console.WriteLine("Date is " + DateTime.Now);
           
        }
    }
}

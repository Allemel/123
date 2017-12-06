using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    class Program
    {
        static string[] months =
            {
                "January", "February", "March", "April", "May", "June", "July", "August", "September", "October",
                "November", "December"
            };


        static string[] types = { "rect", "romb", "square", "rand" };
        static List<Rectanglick> list = new List<Rectanglick>();

        static void Main(string[] args)
        {

            list.Add(new Rectanglick(2, 5, "square"));
            list.Add(new Rectanglick(1, 5, "square"));
            list.Add(new Rectanglick(22, 5, "recr"));
            list.Add(new Rectanglick(12, 32, "rect"));
            list.Add(new Rectanglick(5, 5, "rand"));
            list.Add(new Rectanglick(23, 5, "square"));
            list.Add(new Rectanglick(5, 50, "rect"));
            list.Add(new Rectanglick(5, 6, "square"));
            list.Add(new Rectanglick(7, 5, "rect"));


            Console.WriteLine("==========================");
            foreach (var item in getCustom())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("==========================");
            foreach (var item in typeCount())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("==========================");
            foreach (var item in Min())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("==========================");
            foreach (var item in Max(true))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("==========================");
            foreach (var item in SquareLessThan(30))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("==========================");
            foreach (var item in OrderedByPerimeter())
            {
                Console.WriteLine(item);
            }





        }

        static Dictionary<string, int> typeCount()
        {
            Dictionary<string, int>  dict = new Dictionary<string, int>();
            foreach (var type in types)
            {
                var result = from item in list where item.Type == type select item;
                if (result.ToArray().Length == 0)
                    continue;
                
                dict.Add(type, result.Count());
            }

            return dict;
        }


        static Dictionary<string, double> Min(bool bySquare = false)
        {
            Dictionary<string, double> dictionary = new Dictionary<string, double>();
            foreach (var type in types)
            {
                double min = 0;

                var result = (from item in list where item.Type == type select item);
                if (result.ToArray().Length ==  0)
                    continue;
                
                if (bySquare)
                    min = result.Min(x => x.Square());
                if (!bySquare)
                    min = result.Min(x => x.Perimetr());
                
                dictionary.Add(type, min);

            }


            return dictionary;
        }

        static Rectanglick[] SquareLessThan(int x)
        {
            var result = from item in list where item.Type == "square" && item.Height <= x select item;
            return result.ToArray();
        }

        static Rectanglick[] OrderedByPerimeter()
        {
            var result = from item in list where item.Type == "rect" orderby item.Perimetr() select item;
            return result.ToArray();
        }

        


        static Dictionary<string, double> Max(bool bySquare = false)
        {
            Dictionary<string, double> dictionary = new Dictionary<string, double>();
            foreach (var type in types)
            {
                double max = 0;

                var result = from item in list where item.Type == type select item;
                if (result.ToArray().Length == 0)
                    continue;
                
                if (bySquare)
                    max = result.Max(x => x.Square());
                if (!bySquare)
                    max = result.Max(x => x.Perimetr());

                dictionary.Add(type, max);

            }

            return dictionary;
        }

        static string[] lessThan(int n)
        {
            var result = from month in months where month.Length < n select month;
            return result.ToArray();
        }

        static string[] getSummerAndWinter()
        {
            var result = from month in months
                where
                    month.Contains("uary") || month.ToLower().Contains("dec") || month.ToLower().Contains("ju") ||
                    month.ToLower().Contains("aug")
                select month;
            return result.ToArray();
        }

        static string[] orderedByAlphabet()
        {
            var result = from month in months orderby month select month;

            return result.ToArray();
        }

        static string[] getCustom()
        {
            var result = from month in months where month.ToLower().Contains("u") && month.Length > 4 select month;
            return result.ToArray();
        }
    }
}

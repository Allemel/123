using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Technic one = new Technic(10, 2, 5.4, "One", Technic.Type.Computer);
                Technic two = new Technic(44, 1, 10, "Two", Technic.Type.Printer);
                Technic three = new Technic(100, 33, 12.3, "Three", Technic.Type.Lamp);
                Technic four = new Technic(444, 12, 10.2, "Four", Technic.Type.Computer);
                Technic five = new Technic(1, 1, 1665, "Five", Technic.Type.Xerox);
                Technic six = new Technic(4, 1, 134, "Six", Technic.Type.Computer);
                Technic seven = new Technic(54, 100, 16.3, "Seven", Technic.Type.Printer);
                Technic eight = new Technic(12, 100, 10.88, "Eight", Technic.Type.Lamp);
                Technic nine = new Technic(2, 111, 14.88, "Nine", Technic.Type.Xerox);
                Technic ten = new Technic(5, 14, 11.1, "Ten", Technic.Type.Scaner);
                Technic eleven = new Technic(6, 13, 190, "Eleven", Technic.Type.XRay);
                Technic twelve = new Technic(9, 12, 189, "Twelve", Technic.Type.Printer);
                Technic twelv1e = new Technic(9, 14, 15, "Fourteen", Technic.Type.Printer);

                Laboratory lab = new Laboratory();
                lab.Add(one);
                lab.Add(two);
                lab.Add(three);
                lab.Add(four);
                lab.Add(five);
                lab.Add(six);
                lab.Add(seven);
                lab.Add(eight);
                lab.Add(nine);
                lab.Add(ten);
                lab.Add(eleven);
                lab.Add(twelve);


                Console.WriteLine("Count expired: " + lab.CountExp(12));

                int[] res = lab.TypeCount();
                Console.WriteLine("Type count:");

                Console.WriteLine("Computer: " + res[0]);
                Console.WriteLine("Printer: " + res[1]);
                Console.WriteLine("Scaner: " + res[2]);
                Console.WriteLine("Xerox: " + res[3]);
                Console.WriteLine("Lamp: " + res[4]);
                Console.WriteLine("XRay: " + res[5]);

                Console.WriteLine("Ordered list by price:");
                var list = lab.GetOrdered();

                foreach (var item in list)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("EXCEPTION! " + ex);
                
            }
            finally
            {
                
            }
        }

    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    class Program
    {
        static ArrayList arrayList = new ArrayList();
            
        static void Main(string[] args)
        {
            arrayList.Add(5);
            arrayList.Add(12);
            arrayList.Add(63);
            arrayList.Add(59);
            arrayList.Add(24);
            arrayList.Add("test");

            bool first = true;
            bool second = true;
            while (first)
            {
                Console.WriteLine("1. Delete");
                Console.WriteLine("2. Search");
                Console.WriteLine("0. To next task");
                Console.WriteLine();
                string key = Console.ReadLine();
                Console.WriteLine();


                switch (key)
                {
                    case "1":
                        Console.WriteLine("Input element");
                        string elem = Console.ReadLine();
                
                        Delete(elem);
                        break;
                    case "2":
                        Console.WriteLine("Input element");
                        elem = Console.ReadLine();
                
                        Console.WriteLine(Search(elem) ? "Exists!" : "Not exists");
                        break;
                    case "0":
                        first = false;
                        break;
                    default:
                        Console.WriteLine("Not correct input");
                        break;
                }

                foreach (var item in arrayList)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine("Count = " + arrayList.Count);
    
            }
            Console.WriteLine("Second task:");
            HashSet<long> hash = new HashSet<long>();
            LinkedList<long> linkedList= new LinkedList<long>();
            hash.Add(544);
            hash.Add(743);
            hash.Add(88);
            
            while (second)
            {
                foreach (var item in hash)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine("1. Add");
                Console.WriteLine("2. Delete");
                Console.WriteLine("0. Exit");

                string key = Console.ReadLine();
                try
                {
                    switch (key)
                    {
                        case "1":
                                Console.WriteLine("Input element");
                            string s = Console.ReadLine();
                
                            long el = Convert.ToInt64(s);
                
                            hash.Add(el);
                            break;
                        case "2":
                                Console.WriteLine("Input element");
                           s = Console.ReadLine();
                
                           el = Convert.ToInt64(s);
                
                            hash.Remove(el);
                            break;
                        case "0": 
                            return;
                            
                        default:
                            Console.WriteLine("Not correct input");
                            break;
                    }

                    Console.WriteLine("Copying all from hashSet to LinkedList...");
                    foreach (var item in hash)
                    {
                        linkedList.AddFirst(item);
                    }

                    Console.WriteLine("LinkedList: ");
                    foreach (var item in linkedList)
                    {
                        Console.WriteLine(item);
                    }

                    Console.WriteLine("Input item to find in linkedList");
                    string sf = Console.ReadLine();
                    long elf = Convert.ToInt64(sf);

                    if (linkedList.Contains(elf))
                        Console.WriteLine("Element " + elf + " found in linkedList");
                    else
                        Console.WriteLine("Element " + elf + " not found in linkedList");


                    linkedList.Clear();

                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex);
                    return;
                }
                
            }            
            
        }

        private static bool isInt(string s)
        {
            if (s[0] == '\"' && s[s.Length - 1] == '\"')
            {
                return false;
            }
            try
            {
                int res = Convert.ToInt32(s);
                return true;
            }
            catch 
            {
                return false;
            }
        }

        private static void Delete(string s)
        {
            if (isInt(s))
            {
                arrayList.Remove(Convert.ToInt32(s));
                return;
            }
            s = s.Substring(1, s.Length - 2);
            arrayList.Remove(s);
            
        }

        private static bool Search(string s)
        {
            if (isInt(s))
            {
                if (arrayList.Contains(Convert.ToInt32(s)))
                    return true;
                return false;
            }
            s = s.Substring(1, s.Length - 2);
            if (arrayList.Contains(s))
                return true;
            return false;
        }
    }
}

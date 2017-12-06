using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            Director dir = new Director();
            Student st = new Student("StudName", 50000);
            Tok tk = new Tok("TokName", 40000);

            tk.Up += ShowMsg;
            tk.Down += ShowMsg;
            st.Up += ShowMsg;
            


            dir.Add(tk, 5000);
            dir.Add(st, 300);

            dir.Remove(tk, 100);
            dir.Remove(st, 500);
            //=========================

            
            Func<string, string, int, string> op = Process;
            Console.WriteLine(op("qweqweqweqweqweqwe", "ccccc", 10));
  

        }

        public static void ShowMsg(string msg)
        {
            Console.WriteLine(msg);
        }



        static Trim trim = (x) => x.Trim();
        static Concat concat = (x, y) => x + y;   
        static ToUpper toUpper = (x) => x.ToUpper();
        static ToLower toLower = (x) => x.ToLower();
        static Substring substring = (x, y) => x.Substring(y);

        static string Process(string s1, string s2, int index)
        {
            string res = concat(s1, s2);
            res = trim(res);
            res = toUpper(res);
            res = toLower(res);
            res= substring(res, index);
            return res;
        }


        delegate string Concat(string s1, string s2);

        delegate string Trim(string source);

        delegate string ToUpper(string s);

        delegate string ToLower(string s);

        delegate string Substring(string s, int index);
    }
}

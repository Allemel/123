using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Tovar tov = new Tovar();
            Scaner scan = new Scaner();
            Komp kompich = new Komp(); 
            IAlla scaner = new Scaner();
            IAlla  tovar = new Tovar();
            IAlla kom = new Komp();
            var fds = scaner as Scaner;
            if (fds != null)
            {
                Console.WriteLine(fds.Dod());
            }
            Printer pri = new Printer();
            IAlla[]  allmass = new IAlla[3];
            allmass[0] = scaner;
            allmass[1] = tovar;
            allmass[2] = kom;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(pri.IAmPrinting(allmass[i]));
            }
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Tovar:IComparable, IAlla
    {
        protected int Price;
        protected double Weight;
        protected string Nameki;

        public override string ToString()
        {
          return "Tover";
           
        }

        public override int GetHashCode()
        {
            return Price * 2;
        }

        public bool Equals(Tovar tov)
        {
            if ((Price == tov.Price) && (Weight == tov.Weight) && (Nameki == tov.Nameki))
            {
                return true;
            }
            return false;
        }

        public int CompareTo(object obj)
        {  
            Tovar tov = obj as Tovar;
            if (tov == null)
            {
                throw new ArgumentException("Not tovarius!");
            }



            if (Price == tov.Price)
            {
                return 0;
            }
            if (Price > tov.Price)
            {
                return 1;
            }
            if (Price < tov.Price)
            {
                return -1;
            }
            return 0;
        }
        public string Dod()
        {
            return "Hello, tovar!";
        }
    }

    class Technika:Tovar
    {
        public override string ToString()
        {
            return "Technika";

        }
    }

    abstract class Pechatalki : Technika
    {
        public virtual string Dod(string Jo = "Pechatnaya technika")
        {
            return Jo;
        }
        public override string ToString()
        {
            return "Pechatalki";

        }
    }

    class Scaner:Pechatalki
    {
        

        public override string Dod(string s = "Abstract from scaner")
        {
            return s;
        }
        public override string ToString()
        {
            return "Scaner";

        }
    }

    class Komp:Technika
    {
        public override string ToString()
        {
            return "Komp";

        }
    }

    sealed class Planshet:Technika
    {
        public override string ToString()
        {
            return "Planshet";

        }   
    }

    class Printer
    {
        public string IAmPrinting(IAlla obj)
        {
            Tovar isTovar = obj as Tovar;
            Technika isTechnika = obj as Technika;
            Pechatalki isPechatalki = obj as Pechatalki;
            Scaner isScaner = obj as Scaner;
            Komp isKomp = obj as Komp;
            Planshet isPlanshet = obj as Planshet;
            if (isTovar != null)
            {
                return isTovar.ToString();
            }
            if (isTechnika != null)
            {
                return isTechnika.ToString();
            }
            if (isPechatalki != null)
            {
                return isPechatalki.ToString();
            }
            if (isScaner != null)
            {
                return isScaner.ToString();
            }
            if (isKomp != null)
            {
                return isKomp.ToString();
            }
            if (isPlanshet != null)
            {
                return isPlanshet.ToString();
            }
            return "";


        }
    }

    public interface IAlla
    {
        string Dod();
    }
}

struct Document
{
    public string Name;
    int Count;
   }

enum DocNum
{
    Doc1 = 1, Doc2, Doc3, Doc4, Doc5
}

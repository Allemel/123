using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    partial class Laboratory
    {
        private List<Technic> value = new List<Technic>();

        

        public int[] TypeCount()
        {
            int[] result = new int[6];
            
            foreach (var item in value)
            {
                switch (item.GetType())
                {
                    case Technic.Type.Computer:
                        result[0]++;
                        break;
                    case Technic.Type.Printer:
                        result[1]++;
                        break;
                    case Technic.Type.Scaner:
                        result[2]++;
                        break;
                    case Technic.Type.Xerox:
                        result[3]++;
                        break;
                    case Technic.Type.Lamp:
                        result[4]++;
                        break;
                    case Technic.Type.XRay:
                        result[5]++;
                        break;

                }
           }
            return result;

        }

        public List<Technic> GetOrdered()
        {
            value.Sort((f, s) => s.GetPrice().CompareTo(f.GetPrice()));
            return value;
        }

    }

    class Technic
    {
        private int exp;
        private int count;
        private double price;
        private string name;
        public Type type;
        public enum Type
        {
            Computer = 1, Printer, Scaner, Xerox, Lamp, XRay
        }

        
        public Technic(int exp, int count, double price, string name, Type type)
        {
            Debug.Assert(name != "", "Name cannot be null"); 
            if (exp <= 0)
            {
                throw new ZeroException("Please input number > 0");
            }
            if (name == "")
            {
              throw  new EmptyNameException("Please input valid name");
            }
            if (price < 0.1)
            {
                throw  new CustomException("Please input price");
            }
            this.exp = exp;
            this.count = count;
            this.price = price;
            this.name = name;
            this.type = type;
        }

        public double GetPrice()
        {
            return price;
        }

        public Type GetType()
        {
            return type;
        }
        public override string ToString()
        {
            string gg = "";
            switch (type)
            {
                case Type.Computer:
                    gg = "Computer";
                    break;
                case Type.Printer:
                    gg = "Printer";
                    break;
                case Type.Scaner:
                    gg = "Scaner";
                    break;
                case Type.Xerox:
                    gg = "Xerox";
                    break;
                case Type.Lamp:
                    gg = "Lamp";
                    break;
                case Type.XRay:
                    gg = "XRay";
                    break;
            
            }
            return "Name: " + name + " Price: " + Convert.ToString(price) + " Type: " + gg + " Count: " + Convert.ToString(count)+ " Exp: " + Convert.ToString(exp);

        }

        public bool IsOlder(int old)
        {
            if (old == 9000)
            {
                throw new Exception("Soo oldeeeer.....");
            }
            if (old < exp)
                return true;
            return false;
        }

        
    }

   
}

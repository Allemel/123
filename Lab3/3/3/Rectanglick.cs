using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Rectanglick
    {
        static int count;//стат поле
        public static int RectCount;
        public static int SquareCount;
        public static int RombCount;
        public static int RandCount;


        const int IKI = 18;
        readonly double id;//поле для чтения 
        double _h;
        double _w;
        public string Type;
        public double Height
        {
            get { return _h; }
            set
            {
                if (value > 0)
                {
                    _h = value;
                }
            }
        }
        public double Width
        {
            get { return _w; }
            set
            {
                if (value > 0)
                {
                    _w = value;
                }
            }
        }

        static double Lol;
        private int _i;

        public int I//геттеры сеттеры для поля
        {
            get { return _i; }
            set { _i = value; }
        }


        public Rectanglick(double h, double w, string t = "")//с параметрами
        {
            count++;
            switch (t)
            {
                case "rect":
                    RectCount++;
                    break;
                case  "romb":
                    RombCount++;
                    break;
                case "square":
                    SquareCount++;
                    break;
                case "rand":
                    RandCount++;
                    break;
                default:
                    break;
            }

            Height = h;
            Width = w;
            Type = t;
            id = (h * w) - (IKI + 32);
        }
        public Rectanglick()//без  параметров
        {
        }

        public Rectanglick(int i, double h = 4.6)//по умолчанию
        {
            Height = h;
            Width = 10;

        }
        static  Rectanglick()//стат.конструктор (вызывается при первом обр к классу
        {
            Lol = 9;
        }
        private Rectanglick(int y)//закрытый
        {
        }

        static public void Tik(ref int i, out int ju)//обл видимости (ток к глоб переменным)
        {
            ju = 8;//не иниц 
            i += 10;//передача значения,будет выход в+10
        }
        static public string Metodinf()
        {
            return "Welcome to BelSTU";// метод возвращ строку
        }
        public override string ToString()//ovr -переопределить метод родителя
        {
            return "H: " + Height.ToString() + " W: " + Width.ToString();//строка+строка значени
        }
        public double Perimetr()
        {
            return Height * 2 + Width * 2;
        }
        public double Square()
        {
            return Height * Width;
        }
    }
}

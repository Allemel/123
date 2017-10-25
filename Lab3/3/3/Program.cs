using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Создать класс типа - Прямоугольник. Поля - высота и
ширина. Методы вычисления площади, периметра,
Свойства должны проверять корректность задаваемых
параметров.
Создать массив объектов. Вывести:
a) количество четырехугольников разного типа (квадрат,
прямоугольник, ромб, произвольный)
b) определить для каждой группы наибольший и наименьший
по площади (периметру) объект.*/
namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            var square = new Rectanglick(5, 5, "square");
            var rect = new Rectanglick(5, 10, "rect");
            var romb = new Rectanglick(7, 7, "romb");
            var rand = new Rectanglick(5.7, 6.3, "rand");


            Rectanglick[] arr = new Rectanglick[] {square, rect,  romb, rand};
            Console.WriteLine("Rects: " + Rectanglick.RectCount.ToString() + " Squares: " + Rectanglick.SquareCount.ToString()  + 
                " Rombs: " + Rectanglick.RombCount.ToString() +  " Rands: " + Rectanglick.RandCount.ToString());

            double rectSMin = 10000;
            double rectSMax = 1;
            double randSMin = 10000;
            double randSMax = 1;
            double squareSMin = 10000;
            double squareSMax = 1;
            double rombSMin = 10000;
            double rombSMax = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                

                switch (arr[i].Type)
                {
                    case "square":
                        var s = arr[i].Square();
                        if (s > squareSMax)
                            squareSMax = s;
                        if (s < squareSMin)
                            squareSMin = s;
                        break;
                    case "rect":
                        s = arr[i].Square();
                        if (s > rectSMax)
                            rectSMax = s;
                        if (s < rectSMin)
                            rectSMin = s;
                        break;
                    case "rand":
                        s = arr[i].Square();
                        if (s > randSMax)
                            randSMax= s;
                        if (s < randSMin)
                            randSMin = s;
                        break;
                    case "romb":
                        s = arr[i].Square();
                        if (s > rombSMax)
                            rombSMax = s;
                        if (s < rombSMin)
                            rombSMin = s;
                        break;
                    default:
                        break;
                }

            }
            Console.WriteLine("Rect: Max: " + rectSMax.ToString()  + " Min: " + rectSMin.ToString());
            Console.WriteLine("Rand: Max: " + randSMax.ToString()  + " Min: " + randSMin.ToString());
            Console.WriteLine("Romb: Max: " + rombSMax.ToString()  + " Min: " + rombSMin.ToString());
            Console.WriteLine("Square: Max: " + squareSMax.ToString()  + " Min: " + squareSMin.ToString());


            var a = new Rectanglick(5.7, 6.3);
            var v = new Rectanglick(5.7, 6.3);//стат члены
            var l = new Rectanglick(2);
            int la = 15;
            int ju2;
            Rectanglick.Tik(ref la, out ju2);
            var t = a.ToString();
 



            var n = " ";
        }

    }
}

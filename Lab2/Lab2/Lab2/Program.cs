using System;//директива using сообщает компилятору где искать классы
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2//определение пространства имен
{
    class Program//объявление класса    
    {
        static void Main(string[] args)//статическая функция с возвращ значением
        {//тело функции
            string s = "";//явные преобразование
            int i = 0;
            bool b = false;
            float f = 0;
            char c = 'd';
            uint ui = 2;

            long l = (long)i;//неявные преобразования(табл.неявн.преобр.)
            double d = (float)f;
            i = (int)c;
            decimal dd = (decimal)i;//128-разр тип данных
            l = (long)ui;

            i = Convert.ToInt32("25");
            s = b.ToString();
            ui = Convert.ToUInt32(55);
            int ii = Convert.ToInt32(true);
            s = ui.ToString();

            Object o;//упаковка 
            o = ii;
            int gg = (int)o;//распаковка

            var bb = "sss";//отличие ссылочных типов от типов значений - перем.ссыл.типом могут принимать нал.
            Object ob = null;

            string s1 = "123";//объявление строковых литералов и создание строк на основе стринг
            string s2 = "456";
            string s3 = "7 8 9";
            if (s1 == s2)//сравнение
            {
                Console.WriteLine("Equal");
            }

            var res = String.Concat(s1, s2, s3);//сцепление
            res = String.Copy(s1);//копирование
            res = s1.Substring(1);//выделение подстроки
            var res2 = s3.Split(' ');//разделение строки на слова
            var res4 = s3.Insert(0, s2);//вставляет строку 2
            res = s2.Replace("4", "");//перестановка подстроки в указ место
            string s4 = "";
            string s5 = null;//nullстрока
            if (String.IsNullOrEmpty(s4))
            {
                Console.WriteLine("Empty");//яв-ся ли строка 5 пустой или налл
            }
            var sb = new StringBuilder("124");//строка на стр.билдер (позволяет менять строковую переменную)
            sb.Remove(0, 1);//удаление символов
            sb.Insert(0, "44");//вставка
            float[,] arr = new float[,] { { 1, 2, 3 }, { 4, 5, 6 } };//оддномерн массив строк
            Random ran = new Random();
            for (int iq = 0; i < 2; iq++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arr[iq, j] = ran.Next(1, 15);
                    Console.Write("{0}\t", arr[iq, j]);
                }
                Console.WriteLine();
            }

            string[] str = new string[] { "111", "222", "333" };//одномерн массив строк
            for (int iq = 0; iq < str.Length; iq++)
            {
                Console.Write(str[iq] + "\t");
            }
            Console.WriteLine();
            int pos = Convert.ToInt32(Console.ReadLine());
            if (pos > str.Length)
            {
                return;
            }//ввод значчения - 
            string e = Console.ReadLine();
            str[pos-1] = e;
            for (int iq = 0; iq < str.Length; iq++)
            {
                Console.Write(str[iq] + "\t");
            }
            Console.WriteLine();


            double[,] db = new double[3,4];//ступенч массив
            int tmp = 2;
            for (int iq = 0; iq < 3; iq++)
            {
                for (int j = 0; j < tmp; j++)
                {
                    double key = Convert.ToDouble(Console.ReadLine());
                    db[iq,j] = key;
                }
                tmp++;

            }

            tmp = 2;
            for (int iq = 0; iq < 3; iq++)
            {
                for (int j = 0; j < tmp; j++)
                {
                    Console.Write(db[iq, j] + "\t");
                }
                tmp++;
                Console.WriteLine();
            }

            var bbb = new string[] { "123", "sss" };//неявно типиз переменные для хран массива и строки
            var bbbb = "ffff";

            var ss = new Tuple<int, string, char, string, ulong>(1,"",'s',"",2);//кортеж
            Console.WriteLine(ss);//вывод всего и по ээлементам

            Console.WriteLine();
            Console.WriteLine(ss.Item1);
            Console.WriteLine(ss.Item3);
            Console.WriteLine(ss.Item4);

            int[] aa = new int[] { 12, 13, 44, 55, 77, 88 };

            var r = Corteg(aa, "test");
            Console.WriteLine(r.Item1);
            Console.WriteLine(r.Item2);
            Console.WriteLine(r.Item3);
            Console.WriteLine(r.Item4);

        }

        static Tuple<int, int, int, char> Corteg(int[] a, string s)
        {
           Array.Sort(a);
           int l = a.Length;
           int sum = 0;
           for (int i = 0; i < l; i++)
                sum += a[i];
           
            return Tuple.Create<int, int, int, char>(a[l-1], a[0], sum, s[0]);//мин макс эл строки 
        }
    }


    
}

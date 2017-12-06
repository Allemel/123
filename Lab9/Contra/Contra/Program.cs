using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contra
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                GoodStack<string> gs = new GoodStack<string>(10);
                gs.Push("111");
                gs.Pop("111");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }

    class GoodStack<T> : Stack<T> where T : class
    {
        private Stack<T> value = new Stack<T>();

        public GoodStack(int count)
        {
            if (count == 0)
                throw new Exception("Cannot be 0");
        }

        public void Push(T t)
        {
            value.Push(t);
        }

        public void Pop(T t)
        {
            throw new InsufficientExecutionStackException("Exception");
        }

    }
}

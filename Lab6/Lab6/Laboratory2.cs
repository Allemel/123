using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    partial class Laboratory
    {
        public void Add(Technic obj)
        {
            value.Add(obj);
        }

        public void Remove(Technic obj)
        {
            value.Remove(obj);
        }

        public int CountExp(int exp)
        {
            int count = 0;
            if (count > 100)
            {
                throw new System.ArgumentOutOfRangeException("Index out of range");
            }
            foreach (var item in value)
            {
                if (item.IsOlder(exp))
                    count++;

            }
            return count;
        }
    }
}

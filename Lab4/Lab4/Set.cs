using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Set //класс-множество set, позволяет добавл и удалять в нем элементы
    {
        public List<int> value = new List<int>();
        Owner owner = new Owner(44444, "Alla" , "HOME");
        DateTime date = new DateTime();


        public string GetOwnerName()
        {
            return owner.name;
        }
        public string Now()
        {
            return DateTime.Now.ToString();
        }
        public void Add(int key)
        {
            if (!value.Contains(key))    
                value.Add(key);
        }

        public void Remove(int key)
        {
            if (value.Contains(key))
                value.Remove(key);
        }

        public static bool operator >(Set set, Set set2)//peregruzka i prenadlenost'
        {
            return set.value.Contains(set2.value.First());
        }

        public static bool operator <(Set set, Set set2)//peregruzka i podmnojestvo
        {
            for (int i = 0; i < set2.value.Count; i++)
            {
                bool flag = false;
                for (int j = 0; j < set.value.Count; j++)
                {
                    if (set2.value[i] == set.value[j])
                    {
                        flag = true;
                        break;
                    }

                }
                if (!flag)
                {
                    return false;
                }

            }
            return true;
        }

        public static Set operator *(Set set, Set set2)
        {
            Set res = new Set();
            for (int i = 0; i < set.value.Count; i++)
            {
                for (int j = 0; j < set2.value.Count; j++)
                {
                    if (set.value[i] == set2.value[j])
                        res.Add(set.value[i]);
                }
            }

            return res;
        }

        public int First()
        {
            return value.First();
        }

        public static void RemovePositive(ref Set set)
        {
            int j = 2;
            while (j > 0)
            {
                for (int i = 0; i < set.value.Count; i++)
                {
                    if (set.value[i] > 0)
                        set.Remove(set.value[i]);
                }

                j--;
            }
            
        }
    }

    class Owner
    {
        public int id;
        public string name;
        public string org;

        public Owner(int id, string name, string org)
        {
            this.id = id;
            this.name = name;
            this.org = org;
        }
    }

    static class MathObject
    {
        public static void Truncate(ref Set set)
        {
            set.value.Clear();
        }

        public static int Max(Set set)
        {
            return set.value.Max();
        }

        public static int Min(Set set)
        {
            return set.value.Min();
        }
    }
}

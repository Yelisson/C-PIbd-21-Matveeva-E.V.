using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class ClassArray<T>where T:Interface1
    {
        private Dictionary<int, T> places;
        private int maxCount;
        private T defaultValue;

        public ClassArray(int size, T defVal)
        {
            defaultValue = defVal;
            places = new Dictionary<int, T>();
            maxCount = size;
        }
        public static int operator +(ClassArray<T> p, T poisonousSnake)
        {
            if (p.places.Count == p.maxCount)
            {
                return -1;
            }
            for (int i = 0; i < p.places.Count; i++)
            {
                if (p.CheckFreePlace(i))
                {
                    p.places.Add(i, poisonousSnake);
                    return i;
                }
            }
            p.places.Add(p.places.Count, poisonousSnake);
            return p.places.Count - 1;
        }

        public static T operator -(ClassArray<T> p, int index)
        {
            if (p.places.ContainsKey(index))
            {
                T poisonousSnake = p.places[index];
                p.places.Remove(index);
                return poisonousSnake;
            }
            return p.defaultValue;
        }

        private bool CheckFreePlace(int index)
        {
            return !places.ContainsKey(index);
        }

        public T this[int ind]
        {
            get
            {
                if (places.ContainsKey(ind))
                {
                    return places[ind];
                }
                return defaultValue;
            }
        }
    }
}

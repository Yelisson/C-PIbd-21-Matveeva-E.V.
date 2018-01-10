using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class ClassArray<T> : IEnumerator<T>, IEnumerable<T>, IComparable<ClassArray<T>>, IDisposable
    {
        private int currentIndex;
        public T Current
        {
            get
            {
                return places[places.Keys.ToList()[currentIndex]];
            }
        }

        object IEnumerator.Current { get { return Current; } }
        bool disposed = false;
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
   
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                this.disposed = true;
            }
        }
        public bool MoveNext()
        {
            if (currentIndex + 1 >= places.Count)
            {
                Reset();
                return false;
            }
            currentIndex++;
            return true;
        }
        public void Reset()
        {
            currentIndex = -1;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int CompareTo(ClassArray<T> other)
        {
            if (this.Count() > other.Count())
            {
                return -1;
            }
            else if (this.Count() < other.Count())
            {
                return 1;
            }else
            {
                var thisKeys = this.places.Keys.ToList();
                var otherKeys = other.places.Keys.ToList();
                for(int i = 0; i < this.places.Count; ++i)
                {
                    if(this.places[thisKeys[i]] is PoisonousSnake && 
                        other.places[thisKeys[i]] is Kobra)
                    {
                        return 1;
                    }
                    if(this.places[thisKeys[i]] is Kobra &&
                        other.places[thisKeys[i]] is PoisonousSnake)
                    {
                        return -1;
                    }
                    if(this.places[thisKeys[i]] is PoisonousSnake &&
                        other.places[thisKeys[i]]is PoisonousSnake)
                    {
                        return (this.places[thisKeys[i]] is PoisonousSnake).CompareTo(other.places[thisKeys[i]] is PoisonousSnake);
                    }
                    if (this.places[thisKeys[i]] is Kobra &&
                      other.places[thisKeys[i]] is Kobra)
                    {
                        return (this.places[thisKeys[i]] is Kobra).CompareTo(other.places[thisKeys[i]] is Kobra);
                    }
                }
            }
            return 0;
        }


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

            var isKobra = poisonousSnake is Kobra;
            if (p.places.Count == p.maxCount)
            {
                throw new TerrariumOverflowException();
            }
            int index = p.places.Count;
            for(int i = 0; i < p.places.Count; i++)
            {
                if (p.CheckFreePlace(i))
                {
                    index = 1;
                }
                if (poisonousSnake.GetType() == p.places[i].GetType())
                {
                    if (isKobra)
                    {
                        if((poisonousSnake as Kobra).Equals(p.places[i]))
                        {
                            throw new TerrariumAlreadyHaveException();
                        }
                    }else if((poisonousSnake as PoisonousSnake).Equals(p.places[i]))
                    {
                        throw new TerrariumAlreadyHaveException();
                    }
                }
            }
            if (index != p.places.Count)
            {
                p.places.Add(index, poisonousSnake);
                return index;
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
            throw new TerrariumIndexOutOfRangeException();
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

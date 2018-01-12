using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_2__samolet_
{

    class ClassArray<T>  : IEnumerator<T>, IEnumerable<T>, IComparable<ClassArray<T>>
    {
        private int currentIndex;
        public T Current
        {
            get
            {
                return places[places.Keys.ToList()[currentIndex]];
            }
        }
        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public void Dispose()
        {
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

        private Dictionary<int, T> places;
        private int maxCount;
        private T defaultValue;

        public ClassArray(int size, T defVal)
        {
            defaultValue = defVal;
            places = new Dictionary<int, T>();
            maxCount = size;
        }

        public static int operator +(ClassArray<T> p, T airplane)
        {
            var isAerobus = airplane is Aerobus;
            if (p.places.Count == p.maxCount)
            {
                throw new ParkingOverflowException();
            }
            int index = p.places.Count;
            for (int i = 0; i < p.places.Count; i++)
            {
                if (p.CheckFreePlace(i))
                {
                    
                        index = i;
                    }
                    if (airplane.GetType() == p.places[i].GetType())
                    {
                        if (isAerobus)
                        {
                            if ((airplane as Aerobus).Equals(p.places[i]))
                            {
                                throw new ParkingAlreadyHaveException();
                            }
                        }
                        else if ((airplane as Airplane).Equals(p.places[i]))
                        {
                            throw new ParkingAlreadyHaveException();
                        }
                    }
                }
                if (index != p.places.Count)
                {
                    p.places.Add(index, airplane);
                    return index;
                }
                p.places.Add(p.places.Count, airplane);
                return p.places.Count - 1;
            }

        public static T operator -(ClassArray<T> p, int index)
        {
            if (p.places.ContainsKey(index))
            {
                T airplane = p.places[index];
                p.places.Remove(index);
                return airplane;
            }
            throw new ParkingIndexOutOfRangeException();
        }

        private bool CheckFreePlace(int index)
        {
            return !places.ContainsKey(index);
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
            }
            else
            {
                var thisKeys = this.places.Keys.ToList();
                var otherKeys = other.places.Keys.ToList();
                for (int i = 0; i < this.places.Count; ++i)
                {
                    if (this.places[thisKeys[i]] is Airplane && other.places[thisKeys[i]] is Aerobus)
                    {
                        return 1;
                    }
                    if (this.places[thisKeys[i]] is Aerobus && other.places[thisKeys[i]] is Airplane)
                    {
                        return -1;
                    }

                    if (this.places[thisKeys[i]] is Airplane && other.places[thisKeys[i]] is Airplane)
                    {
                        return (this.places[thisKeys[i]] is Airplane)
                        .CompareTo(other.places[thisKeys[i]] is Airplane);
                    }


                    if (this.places[thisKeys[i]] is Aerobus && other.places[thisKeys[i]] is Aerobus)
                    {
                        return (this.places[thisKeys[i]] is Aerobus)
                        .CompareTo(other.places[thisKeys[i]] is Aerobus);
                    }
                }
            }

            return 0;
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




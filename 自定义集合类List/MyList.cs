using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 自定义集合类List
{
    class MyList<T>where T:IComparable
    {

        private T[] array;

        private  int count = 0;

        public MyList(int size)
        {
            if (size >= 0)
            {
                array = new T[size];
            }
        }

        public MyList()
        {
            array = new T[0];
        }

        public T GetItem(int index)
        {
            if (index >= 0 && index <= count - 1)
            {
                return array[index];
            }
            else
            {
                throw new Exception("索引超出范围了");
            }
        }

        public int Capacity
        {
            get { return array.Length; }
        }

        public int Count
        {
            get { return count; }
        }

        public T this[int index]
        {
            get { return GetItem(index); }

            set
            {
                if (index >= 0 && index <= count - 1)
                {
                    array[index] = value;
                }
                else
                {
                    throw new Exception("索引超出范围了");
                }
            }
        }

        public void Add(T item)
        {
            if (Count == Capacity)
            {
                if (Capacity == 0)
                {
                    array = new T[4];
                }
                else
                {
                    var newArray = new T[Capacity * 2];

                    Array.Copy(array, newArray, Count);

                    array = newArray;
                }
            }
            array[Count] = item;
            count++;
        }

        public void Insert(int index, T item)
        {
            if (index >= 0 && index <= count - 1)
            {
                if (Count == Capacity)
                {
                    var newArray = new T[Capacity * 2];

                    Array.Copy(array, newArray, count);

                    array = newArray;
                }

                for (int i = count - 1; i >= index; i--)
                {
                    array[i + 1] = array[i];
                }

                array[index] = item;

                count++;
            }
            else
            {
                throw new Exception("索引超出范围了");
            }
        }

        public void Remove(int index)
        {
            if (index >= 0 && index <= count - 1)
            {
                for (int i = index + 1; i < count; i++)
                {
                    array[i - 1] = array[i];
                }
                count--;
            }
            else
            {
                throw new Exception("索引超出了范围");
            }
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < count; i++)
            {
                if (array[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }

        public int LastIndexOf(T item)
        {
            for (int i = count - 1; i >= 0; i--)
            {
                if (array[i].Equals(item))
                {
                    return i;
                }
            }

            return -1;
        }

        public void Sort()
        {
            for (int j = 0; j < count - 1; j++)
            {
                for (int i = 0; i < Count - 1 - j; i++)
                {
                    if (array[i].CompareTo(array[i + 1]) > 0)
                    {
                        T temp = array[i];

                        array[i] = array[i + 1];

                        array[i + 1] = temp;
                    }
                }
            }
           
        }
    }
}

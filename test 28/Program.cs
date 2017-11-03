using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_28
{
    class Program <T>
    {
        private T[] array;
        public Program (int size)
        {
            array = new T[size + 1];
        }
        public T get(int index)
        {
            return array[index];
        }
        public void set(int index,T value)
        {
            array[index] = value;
        }
    }
}

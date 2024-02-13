using System;

namespace NewLaba3
{
    public class SortedNumbers
    {
        private long[] values;
        private int volume;
        private int count;
        public bool Insert(long value)
        {
            if (count < volume)
            {
                values[count++] = value;
                Array.Sort(values);
                Array.Reverse(values);
                return true;
            }
            else
            {
                if (value > values[volume - 1])
                {
                    values[volume - 1] = value;
                    Array.Sort(values);
                    Array.Reverse(values);
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public int Count
        {
            get { return count; }
        }
        public long this[int index]
        {
            get
            {
                if (index < 0 || index >= count)
                {
                    throw new IndexOutOfRangeException("Индекс вне допустимого диапазона.");
                }
                return values[index];
            }
        }
        public SortedNumbers(int capacity)
        {
            if (capacity <= 0)
            {
                throw new ArgumentException("Вместимость должна быть больше нуля.");
            }
            this.volume = capacity;
            values = new long[capacity];
            count = 0;
        }
    }
    class Program
    {
        static void Main()
        {
            SortedNumbers list = new SortedNumbers(4);

            list.Insert(11);
            list.Insert(20);
            list.Insert(10);
            list.Insert(1);
            list.Insert(100);

            Console.WriteLine("Отсортированный набор чисел:");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}

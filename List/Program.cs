using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<float> list = new List<float>();
            for (int i = 0; i < 5; i++)
            {
                list.Add(i);
            }
            list.Insert(2, 999);

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            bool success = list.Remove(3);
            foreach(int num in list)
            {
                Console.WriteLine(num);
            }
            list.RemoveAt(0);
            list.Clear();
        }
    }
}

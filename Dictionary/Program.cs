using System;
using System.Collections.Generic;

namespace Dictionary
{
    //성능에서 이득을 보고 메모리를 손해본다. 
    //hashtable 이용, c#의 발전의 역사
    //key->item
    class Program
    {
        private class Monster
        {
            public int _id;
            public Monster(int id)
            {
                _id = id;
            }
        }
        static void Main(string[] args)
        {
            Dictionary<int, Monster> dic = new Dictionary<int, Monster>();

            for(int i = 0; i < 10000; i++)
            {
                dic.Add(i, new Monster(i));
            }

            Monster mon;
            dic.TryGetValue(20000, out mon);
            dic.Remove(1);
            dic.Clear();
        }
    }
}

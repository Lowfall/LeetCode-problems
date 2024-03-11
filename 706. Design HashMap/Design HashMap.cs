using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class MyHashMap
    {

        private Dictionary<int, int> dict;

        public MyHashMap()
        {
            dict = new Dictionary<int, int>();
        }

        public void Put(int key, int value)
        {
            if (dict.TryGetValue(key, out var elem))
            {
                dict[key] = value;
            }
            else dict.Add(key, value);
        }

        public int Get(int key)
        {
            if (dict.TryGetValue(key, out var elem)) return elem;
            else return -1;
        }

        public void Remove(int key)
        {
            if (dict.TryGetValue(key, out var elem))
            {
                dict.Remove(key);
            }
        }
    }
}

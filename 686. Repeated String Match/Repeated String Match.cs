using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class Repeated_String_Match
    {
        public static int RepeatedStringMatch(string a, string b)
        {
            string res = "";
            int counter = 0;
            while (res.Length < b.Length)
            {
                res += a;
                counter++;
            }
            if (res.Contains(b))
            {
                return counter;
            }
            else if ((res + a).Contains(b))
            {
                return counter + 1;
            }
            return -1;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class Reverse_String_II
    {
        public static string ReverseStr(string s, int k)
        {
            StringBuilder sb = new StringBuilder(s); 
            int x = s.Length;
            int a = 0;
            int i = a;
            int j = a + k - 1;
            while(a < x)
            {
                while(i < j)
                {
                    char c = sb[i];
                    sb[i] = sb[j];
                    sb[j] = c;
                    i++;
                    j--;
                }
                a += 2 * k;
                i = a;
                j = i + k - 1 > x - 1 ? x - 1 : i + k - 1;
            }

            return sb.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class Count_Square_Sum_Triples
    {
        public static int CountTriples(int n)
        {
            int[] arr = new int[n];
            int counter = 0;
            for (int i = 0; i < n; i++)
            {
                arr[i] = (i + 1) * (i + 1);
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr.Contains(arr[i] + arr[j]))
                    {
                        counter += 2;
                    }
                }
            }

            return counter;
        }
    }
}

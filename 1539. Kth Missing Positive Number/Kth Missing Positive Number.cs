using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class Kth_Missing_Positive_Number
    {
        public static int FindKthPositive(int[] arr, int k)
        {
            var left = 0;
            var right = arr.Length - 1;
            while (left <= right)
            {
                var mid = left + (right - left) / 2;

                if (arr[mid] - mid - 1 < k)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return left + k;
        }
    }
}

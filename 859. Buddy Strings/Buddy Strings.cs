using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class Buddy_Strings
    {
        public static bool BuddyStrings(string s, string goal)
        {
            if (s.Length < goal.Length || s.Length > goal.Length || s.Length < 2 || goal.Length < 2)
                return false;
            if (s == goal)
            {
                HashSet<char> symbols = new HashSet<char>(s);
                return symbols.Count < s.Length;
            }

            List<int> diffIndexes = new List<int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != goal[i])
                {
                    diffIndexes.Add(i);
                }
            }
            if (diffIndexes.Count != 2)
            {
                return false;
            }
            return s[diffIndexes[0]] == goal[diffIndexes[1]] && s[diffIndexes[1]] == goal[diffIndexes[0]];

        }
    }
}

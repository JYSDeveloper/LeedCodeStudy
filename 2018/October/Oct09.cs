using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018.October
{
    public class Oct09
    {
        public static string longestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0) return "";
            var prefix = strs[0];
            for (int i = 1; i < strs.Length; i++)
                while (strs[i].IndexOf(prefix) != 0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                    if (prefix == "") return "";
                }
            return prefix;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018.October
{
    public static class Oct18
    {
        public static int StrStr(string haystack, string needle)
        {
            if (needle == null || needle == string.Empty || haystack == needle)
                return 0;

            if (haystack.Length < needle.Length)
                return -1;

            for (int i = 0; i < haystack.Length; i++)
            {
                if(haystack[i] == needle[0])
                {
                    bool flag = true;
                    if (haystack.Length - i < needle.Length)//剩余长度小于比较长度，毕竟不存在
                        return -1;
                    for (int j = 1; j < needle.Length; j++)
                    {
                        if (haystack[i + j] != needle[j])
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag) return i;
                }
            }
            return -1;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018.October
{
    public static class Oct08
    {
        public static int RomanToInt(string value)
        {
            int result = 0;
            for (int i = value.Length - 1; i >=0; i--) 
            {
                char t = value[i];
                switch (t)
                {
                    case 'I':
                        result += result >= 5 ? -1 : 1;
                        break;
                    case 'V':
                        result += 5;
                        break;
                    case 'X':
                        result += result >= 50 ? -10 : 10;
                        break;
                    case 'L':
                        result += 50;
                        break;
                    case 'C':
                        result += result >= 500 ? -100 : 100;
                        break;
                    case 'D':
                        result += 500;
                        break;
                    case 'M':
                        result += 1000;
                        break;
                }
            }
            return result;
        }
    }
}

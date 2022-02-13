using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._3._2
{
    public static class SuperString
    {
        public enum Lang
        {
            None = 0,
            Russian = 1,
            English = 2,
            Number = 3,
            Mixed = 4
        }

        public static Lang Language(this char[] c)
        {

            bool result1 = c.Any(u => char.IsNumber(u));
            bool result2 = c.Any(u => char.IsPunctuation(u));
            bool result3 = c.Any(u => IsRussian(c));
            bool result4 = c.Any(u => IsEnglish(c));

            if (result1)
            {
                if (result2 || result3 || result4)
                {
                    return Lang.Mixed;
                }
                return Lang.Number;
            }
            if (result2)
            {
                return Lang.Mixed;
            }
            if (result3)
            {
                if (result2 || result1 || result4)
                {
                    return Lang.Mixed;
                }
                return Lang.Russian;
            }
            if (result4)
            {
                if (result2 || result3 || result1)
                {
                    return Lang.Mixed;
                }
                return Lang.English;
            }
            else if (result1 == false && result2 == false && result3 == false && result4 == false)
            {
                return Lang.None;
            }
            return Lang.Mixed;
        }

        public static bool IsRussian(char[] c)
        {
            for (int i = 0; i < c.Length; i++)
            {
                if ((c[i] >= 'А') && (c[i] <= 'Я') || (c[i] >= 'а') && (c[i] <= 'я') || c[i] == 'ё' || c[i] == 'Ё')
                    return true;
            }
            return false;
        }
        public static bool IsEnglish(char[] c)
        {
            for (int i = 0; i < c.Length; i++)
            {
                if ((c[i] >= 'A') && (c[i] <= 'Z') || (c[i] >= 'a') && (c[i] <= 'z'))
                    return true;
            }
            return false;
        }
    }
}

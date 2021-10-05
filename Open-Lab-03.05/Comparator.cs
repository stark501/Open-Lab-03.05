using System;

namespace Open_Lab_03._05
{
    public class Comparator
    {
        public bool MatchCaseInsensitive(string str1, string str2)
        {
            string str1x = str1.ToUpper();
            string str2x = str2.ToUpper();
            bool Comparator = str1x == str2x;
            Console.Write(Comparator);
            return Comparator;

        }
    }
}

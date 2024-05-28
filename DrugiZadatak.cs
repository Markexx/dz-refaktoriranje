using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_refaktoriranje
{
    internal class DrugiZadatak
    {
        public static List<char> UniqueChars(string text)
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();
            List<char> uniqueChars = new List<char>();

            foreach (char c in text)
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount[c] = 1;
                }
            }
            foreach (char c in text)
            {
                if (charCount[c] == 1)
                {
                    uniqueChars.Add(c);
                }
            }

            return uniqueChars;
        }
    }
}

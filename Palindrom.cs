using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace dz_refaktoriranje
{
    public class Palindrom
    {
        public List<string> palindromes(List<string> strings)
        {
            List<string> res = new List<string>();
            if (strings == null) return res;
            foreach (string str in strings)
            {
                string temp1 = str.Replace(" ", "").ToLower();
                string temp2 = new string(temp1.Reverse().ToArray());
                if (temp1.Equals(temp2))
                {
                    res.Add(str);
                }
            }
            return res;
        }

        static void IsPalindrome(List<string> res)
        {
            foreach (string str in strings)
            {
                string temp1 = str.Replace(" ", "").ToLower();
                string temp2 = new string(temp1.Reverse().ToArray());

                if (temp1.Equals(temp2))
                {
                    res.Add(str);
                }
            }
        }
    }
}

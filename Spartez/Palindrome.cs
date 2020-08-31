using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spartez
{
    public class Palindrome
    {
        public int GetPalindromeOrder(string text)
        {
            int counter = 0;

            for (int i = 0; i < text.Length/2; i++)
            {
                if (text[i] != text[(text.Length-i-1)])
                {
                   counter++;
                }
            }
            return counter;
        }
    }
}

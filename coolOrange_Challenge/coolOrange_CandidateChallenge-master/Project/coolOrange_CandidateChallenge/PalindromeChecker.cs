using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coolOrange_CandidateChallenge
{
    public class PalindromeChecker
    {
       
        public PalindromeChecker()
        {
           
        }
        public  bool IsPalindrome(string s)
        {

            char[] charArray = s.ToCharArray(); // string in chararray speichern
            int items = charArray.Count(); // Werte Zählen 
            int e = items - 1;
            int i = 0;
            bool output = false;
            while (e >= i) // von beiden Seiten des Wortes jeweils eine Stelle einrücken und die Buchstaben vergleichen
            {
                if(i < items- 1)
                i++;
                if(e > 0)
                e--;
                if (charArray[e] == charArray[i]) 
                {
                    output = true;
                }                
                else
                {
                    output = false;
                    break;
                }

                if (e == i)
                    break;
                    
               
            }
            return output;
        }
    }
}

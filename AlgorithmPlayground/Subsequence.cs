using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPlayground
{
    public class Subsequence
    {
        public static Boolean IsSubsequence(string s, string t)
        {

            int? foundAtIndex = null;
            for(int i = 0; i < s.Length; i++)
            {
                char sLetter = s[i];
                int currIndex = i;
                bool letterFound = false;
                for(int j = currIndex; j < t.Length; j++)
                {
                    if(sLetter == t[j])
                    {
                        letterFound = true;
                        if(foundAtIndex > j)
                        {
                            return false;
                        }
                        foundAtIndex = j;
                        break;
                    }
                }
                if(!letterFound)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

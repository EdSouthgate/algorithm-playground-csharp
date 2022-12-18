using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
            int maxIndex = 0;
            for(int i = 0; i < s.Length; i++)
            {
                char sLetter = s[i];
                int currIndex = i;
                bool letterFound = false;
                if(foundAtIndex != null)
                {
                    maxIndex = foundAtIndex.Value + 1;
                }
                for(int j = Math.Max(currIndex, maxIndex); j < t.Length; j++)
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPlayground
{
    public class IsomorphicStrings
    {

        public static bool IsIsomorphic(string s, string t)
        {
            Dictionary<char, char> sToTMapping = new Dictionary<char, char>();
            Dictionary<char, char> tToSMapping = new Dictionary<char, char>();
            for(int i = 0; i < s.Length; i++)
            {
                if (sToTMapping.TryGetValue(s[i], out char value))
                {
                    if (value == t[i])
                    {
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    sToTMapping.Add(s[i], t[i]);
                }
            
            if (tToSMapping.TryGetValue(t[i], out char tvalue))
                {
                    if (tvalue == s[i])
                    {
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    tToSMapping.Add(t[i], s[i]);
                }
            }
           return true;
        }
    }
}

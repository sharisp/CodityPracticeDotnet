using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace Codity
{
    public class OddOccurrencesInArray
    {
        /* Problem:
 A non-empty array A consisting of N integers is given.Every element occurs an even number of times, except for one element that occurs an odd number of times.
 Write a function that finds this element.
 Example:
     • A = [9, 3, 9, 3, 9, 7, 9] → 7
 Solution (C#):*/

        public int OddOccurrencesInArrayByDictionary(int[] A)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            foreach (var item in A)
            {
                if (dict.ContainsKey(item))
                {
                    dict[item]++;
                }
                else
                {
                    dict[item] = 1;
                }
            }
            foreach (var kvp in dict)
            {
                if (kvp.Value % 2 != 0)
                {
                    return kvp.Key;
                }
            }
            return -1; // Return -1 if no odd occurrence is found
        }

        public int OddOccurrencesInArrayXOR(int[] A)
        {
            int result = 0;

            foreach (var item in A)
            {
                result= result ^ item; // XOR operation
            }
          
            return result; // Return -1 if no odd occurrence is found
        }
    }
}
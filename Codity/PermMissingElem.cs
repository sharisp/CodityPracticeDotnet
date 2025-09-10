using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace Codity
{
    public class PermMissingElem
    {
        /* Problem:
 An array A contains N distinct integers in the range[1..(N + 1)]. The array contains all numbers in this range except one.
 Write a function that returns the missing element.
 Example:
     • A = [2, 3, 1, 5] → 4
 Solution (C#):*/
        public int PermMissingElemFunc(int[] A)
        {
            int result = 0;
            int n = A.Length + 1; // Since one element is missing, the length of A is N, so we consider N + 1
            int expectedSum = n * (n + 1) / 2; // Sum of first N+1 natural numbers
            int actualSum = A.Sum(); // Sum of elements in the array
            result = expectedSum - actualSum; // The missing element
            return result;
        }

        public int PermMissingElemDict(int[] A)
        {
            int result = 0;
            int n = A.Length + 1; // Since one element is missing, the length of A is N, so we consider N + 1
            var dict = new Dictionary<int, bool>();
            foreach (var num in A)
            {
                dict[num] = true;
            }
            for (int i = 1; i <= n; i++)
            {
                if (!dict.ContainsKey(i))
                {
                    result = i;
                    break;
                }
            }
            return result;
        }
    }
}
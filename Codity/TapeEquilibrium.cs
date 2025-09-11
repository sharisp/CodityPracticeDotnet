using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Codity
{
    public class TapeEquilibrium
    {
        /*Problem:
A non-empty array A of N integers is given.Split the array into two non-empty parts.Minimize the absolute difference of the sum of the two parts.
Example:
	• A = [3, 1, 2, 4, 3] → minimal difference = 1
Solution (C#):*/

        public int TapeEquilibriumFunc(int[] A)
        {
            int leftSum = 0;
            int rightSum = 0;
            int allSum = A.Sum();
            int minDiff = int.MaxValue;

            //should stop at A.Length-1 to ensure both parts are non-empty
            for (int i = 0; i < A.Length-1; i++)
            {
                leftSum = leftSum + A[i];
                rightSum = allSum - leftSum;
                int diff = Math.Abs(leftSum - rightSum);
                minDiff = Math.Min(minDiff, diff);
            }
            return minDiff;
        }
    }
}
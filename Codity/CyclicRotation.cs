using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Codity
{
    public class CyclicRotation
    {
        /* Problem:
 An array A consisting of N integers is given.Rotation of the array means each element is shifted right by one index, and the last element is moved to the first place.
 Write a function that rotates array A K times.
 Example:
     • A = [3, 8, 9, 7, 6], K = 3 → [9, 7, 6, 3, 8]
 Solution(C#):
        */
        public int[] CyclicRotationFunc(int[] A, int K)
        {
            int[] arr = new int[A.Length];
            int rotations = K % A.Length; // Handle cases where K is greater than the length of A

            for (int i = 0; i < A.Length; i++)
            {
                int pos=(i+ rotations)%A.Length;
                arr[pos] = A[i];
            }
            return arr;
        }
    }
}

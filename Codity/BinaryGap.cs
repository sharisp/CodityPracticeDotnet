namespace Codity
{
    public class BinaryGap
    {
        /*
         1. BinaryGap
Problem:
A binary gap within a positive integer N is any maximal sequence of consecutive zeros surrounded by ones in the binary representation of N.
Write a function that returns the length of the longest binary gap of N. If N doesn’t contain a binary gap, return 0.
Example:
N = 529 → binary 1000010001 → longest gap = 4
        */

        public int BinaryGapFunc(int N)
        {
            var binary = Convert.ToString(N, 2);
            int count = 0;
            int maxCount = 0;
            bool counting = false;
            foreach (var item in binary)
            {
                if (item=='1')
                {
                    if (counting==false)
                    {
                        counting = true;
                    }
                    maxCount=Math.Max(maxCount, count);
                    count= 0;
                }
                else if (item == '0' && counting == true)
                {
                    //the last 0, did not calculate maxcount
                    count++;
                }
               
            }
            return maxCount;
        }
    }
}

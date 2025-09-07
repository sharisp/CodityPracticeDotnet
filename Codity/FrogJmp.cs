using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codity
{
    public class FrogJmp
    {
        /*   A frog wants to get from position X to Y.The frog can jump a fixed distance D.
   Write a function that computes the minimal number of jumps needed to reach Y from X.
   Example:
       • X = 10, Y = 85, D = 30 → 3*/
        public int FrogJmpFunc(int X, int Y, int D)
        {
            int distance =Math.Abs(Y - X);
            float jumps = distance / (float)D;
            return (int)Math.Ceiling(jumps);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockFluteConverter.Core.Classes
{
    public static class Gcd
    {
        public static int Execute(int i, int j)
        {
            i = Math.Abs(i);
            j = Math.Abs(j);
            while (i != j)
            {
                if (i > j)
                {
                    i -= j;
                }
                else
                {
                    j -= i;
                }
            }
            return i;
        }
    }
}

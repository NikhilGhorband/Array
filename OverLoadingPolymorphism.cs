using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC3_PolymorphismOverloading
{
    internal class OverLoadingPolymorphism
    {
        public static int add(int x, int y)
        {
            int z = x + y;
            return z;

        }
        public static int add(int x, int y, int z)
        {
            return x + y + x;
        }
    }
}

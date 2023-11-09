using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Algorithm
{
    public class EuclidesSearch
    {
        public int euclidesModulo(int a, int b)
        {
            int temporaryNumber = -1;

            while (temporaryNumber != 0)
            {
                if (temporaryNumber != 0)
                {
                    temporaryNumber = a % b;
                    a = b;
                    b = temporaryNumber;
                }
            }     
            return a;
        }

        public int euclidesRecursiveModulo(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            return euclidesRecursiveModulo(b, (a % b));
        }

        public int euclidesMinusRecursive(int a, int b)
        {
            if (a == b)
            {
                return a;
            } else if (a > b)
            {
                return euclidesMinusRecursive(a - b, b);
            }
            return euclidesMinusRecursive(a, (b - a));
        }

    }


}

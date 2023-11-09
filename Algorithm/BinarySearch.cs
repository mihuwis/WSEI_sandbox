using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Algorithm
{
    public class BinarySearch
    {

        public int binSearch(int[] array, int number)
        {
            int lastIndex = array.Length - 1;
            int firstIndex = 0;
            if (array[(lastIndex + firstIndex)/2] < number)
            {
                firstIndex = (lastIndex + firstIndex) / 2; 
            }
            return -1;
        }
    }
}

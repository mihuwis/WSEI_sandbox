using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Algorithm
{
    public class Sorting
    {
        public int[] bubbleSort(int[] arrayToSort)
        {
            DateTime startTime = DateTime.Now;
            for(int j  = 0; j < arrayToSort.Length; j++)
            {
                for (int i = 0; i < arrayToSort.Length - 1; i++)
                {
                    if (arrayToSort[i] > arrayToSort[i + 1])
                    {
                        int temp = arrayToSort[i];
                        arrayToSort[i] = arrayToSort[i + 1];
                        arrayToSort[i + 1] = temp;
                    }
                }
            }
            DateTime endTime = DateTime.Now;
            Console.WriteLine(endTime.Subtract(startTime).TotalMilliseconds);

            return arrayToSort;
        }
    }
}

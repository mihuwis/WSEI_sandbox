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
            Console.WriteLine("Bubble sort time : " + endTime.Subtract(startTime).TotalMilliseconds);

            return arrayToSort;
        }

        public int[] insertionSort(int[] arrayToSort)
        {
            DateTime startTime = DateTime.Now;
            for (int i = 1; i < arrayToSort.Length ; i ++)
            {
                int keyValue = arrayToSort[i];
                bool isSorted = false;
                for(int j = i - 1; j >= 0 && !isSorted;)
                {
                    if (keyValue < arrayToSort[j])
                    {
                        arrayToSort[j+1] = arrayToSort[j];
                        j--;
                        arrayToSort[j + 1] = keyValue;
                    }
                    else
                    {
                        isSorted = true;
                    }
                }
            }

            DateTime endTime = DateTime.Now;
            Console.WriteLine("insert sort time : " + endTime.Subtract(startTime).TotalMilliseconds);


            return arrayToSort;
        }

        public int[] quickSort(int[] arrayToSort, int begin, int end)
        {

            if (begin < end)
            {
                int pivotIndex = pivot(arrayToSort, begin, end);

                quickSort(arrayToSort, begin, pivotIndex-1);
                quickSort(arrayToSort, pivotIndex+1, end);
            }



            return arrayToSort;

        }

        private int pivot(int[] arr, int begin, int end)
        {
            int pivot = arr[end];
            int i = begin - 1;

            for (int j = begin; j < end; j ++)
            {
                if (arr[j] <= pivot)
                {
                    i++;

                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            int swapTemp = arr[i + 1];
            arr[i + 1] = arr[end];
            arr[end] = swapTemp;
            return i + 1;
        }
    }
}

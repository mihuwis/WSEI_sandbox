using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Algorithm
{
    public class Fibonachi
    {

        public int fibonaciFinder(int indexNumber)
        {
            int counter = 3;
            int a = 1;
            int b = 2;
            int? temp;
            if (indexNumber == 0) { return 0; };
            if (indexNumber == 1 || indexNumber == 2) { return a; };

            while (counter != indexNumber)
            {
                temp = a + b;
                a = b;
                b = temp.Value;
                counter++;
            }
            return b;
        }

        public int fib(int n)
        {
            Console.WriteLine(" n: " + n);
            if (n <= 1) { return n; }
            else
            {
                return fib(n - 1) + fib(n - 2);
            }
        }

        public int fibSuper(int n) {
            int[] arr = new int[n+2];
            arr[0] = 0;
            arr[1] = 1;
            for (int i = 2; i <=n; i++)
            {
                arr[i] = arr[i-1] + arr[i-2];
            }
            Console.WriteLine(arr[n]);
            return arr[n];
        }
    }
}

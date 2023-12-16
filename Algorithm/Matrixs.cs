using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Algorithm
{
    internal class Matrixs
    {
        public int determinantOfSquare2Matrix(int[,] matrix)
        {
            if(matrix.Length != 4)
            {
                throw new ArgumentException("Array to big");
            }

            return (matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]);
        }
    }
}

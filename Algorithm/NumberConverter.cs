using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Algorithm
{
    public class NumberConverter
    {
        public string convertDecimalToBinary(int value)
        {
            string result = "";
            while(value > 0)
            {
                int element = value % 2;
                result = Convert.ToString(element) + result;
                value /= 2;
            }
            return result;
        }

        public double convertNumber(string value, int baseNumber)
        {
            double result = 0;
            if(baseNumber == 0) { return result;  }
            for(int i = 0; i< value.Length; i++)
            {
                int element = int.Parse(value[i].ToString());
                int power = value.Length - i -1;
                result = result + element * Math.Pow(baseNumber, power);
            }

            return result;
        }
    }
}

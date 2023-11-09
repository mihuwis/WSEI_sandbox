using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Model
{
    internal class TestPrograms01
    {
        public void get5AndPrintReverse()
        {
            List<string> list = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                string item = Console.ReadLine();
                list.Add(item);
            }
            for (int i = list.Count-1 ;i >= 0 ;i--)
            {
                Console.WriteLine(list[i]);
            }
        }

        public double bmiCalculator(double height,  double weight)
        {
            return weight/ Math.Pow(height, 2);
        }

        public int daysFromBirth(string birthDate)
        {
            var parseDate = DateTime.Parse(birthDate);
            Console.WriteLine(parseDate);

            return (DateTime.Now - parseDate).Days;
        }
    }
}

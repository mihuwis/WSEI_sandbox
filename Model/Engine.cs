using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Model
{
    public class Engine
    {

        List<string> Capitols = new List<string>();

public Engine(List<string> capitols)
        {
            Capitols = capitols;
        }

        public int addElements(int a, int b)
        {
            int max = 0;
            return a + b;
        }

        public String getCapital()
        {
            var random = new Random();
            int randomIndex = random.Next(Capitols.Count); 
            return Capitols[randomIndex];
        }
    }
}

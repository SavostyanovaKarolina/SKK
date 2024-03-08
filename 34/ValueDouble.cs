using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34
{
    class ValueDouble : Value<double>
    {
        override public double Parse(string s)
        {
            return double.Parse(s);
        }

        private Random rand = new Random();
        override public double Rand()
        {
            return rand.NextDouble();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34
{
    class ValueBool : Value<bool>
    {
        override public bool Parse(string s)
        {
            return bool.Parse(s);
        }

        private Random rand = new Random();

        override public bool Rand()
        {
            return rand.Next(0, 100) % 2 == 1;
        }
    }
}

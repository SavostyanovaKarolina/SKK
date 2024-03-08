using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34
{
    class ValueInt : Value<int>
    {
        override public int Parse(string s)
        {
            return int.Parse(s);
        }

        private Random rand = new Random();

        override public int Rand()
        {
            return rand.Next(0, 200);
        }
    }
}

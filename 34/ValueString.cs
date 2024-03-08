using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34
{
    class ValueString : Value<string>
    {
        override public string Parse(string s)
        {
            return s;
        }

        private Random rand = new Random();

        override public string Rand()
        {
            string res = "";
            for (int i = 0; i < 10; i++)
            {
                res += (char)rand.Next(65, 90);
            }
            return res;
        }
    }
}

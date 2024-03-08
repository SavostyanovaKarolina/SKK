using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34
{
    abstract class Value<T>
    {
        abstract public T Parse(string s);
        abstract public T Rand();
    }
}

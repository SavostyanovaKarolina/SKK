using _34;
using System;
using System.Configuration;
using System.Reflection;
using System.Runtime.CompilerServices;
abstract class GenArray<T> : BaseArray
{
    protected Value<T> ValueProcessor;
    protected GenArray()
    {
        if (new ValueInt() is Value<T>)
        {
            ValueProcessor = new ValueInt() as Value<T>;
        }
        else if (new ValueDouble() is Value<T>)
        {
            ValueProcessor = new ValueDouble() as Value<T>;
        }
        else if (new ValueString() is Value<T>)
        {
            ValueProcessor = new ValueString() as Value<T>;
        }
        else if (new ValueBool() is Value<T>)
        {
            ValueProcessor = new ValueBool() as Value<T>;
        }
        else
        {
            throw new Exception();
        }
    }
}

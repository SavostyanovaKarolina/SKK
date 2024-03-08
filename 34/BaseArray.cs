using System;
using System.Configuration;
using System.Runtime.CompilerServices;
public abstract class BaseArray
{
    protected string _Name;
    protected abstract void Input();
    protected abstract void Rand();
    public abstract void Output();
}

using System;
sealed class OneDimArr<T> : GenArray<T>
{
    private T[] ar;
    private int Len;
    public OneDimArr(string Name, int len, bool input = false)
    {
        _Name = Name;
        Len = len;
        ar = new T[len];
        if (input)
        {
            Input();
        }
        else
        {
            Rand();
        }
    }

    protected override void Input()
    {
        Console.WriteLine("Please, input " + '"' + _Name + '"' + " " + Len);
        Console.WriteLine(ar);
        for (int i = 0; i < Len; i++)
        {
            Console.Write("[" + (i + 1) + "] = ");
            ar[i] = ValueProcessor.Parse(Console.ReadLine());
        }
    }
    protected override void Rand()
    {
        Random rand = new Random();
        for (int i = 0; i < Len; i++)
        {
            ar[i] = ValueProcessor.Rand();
        }
    }

    public override void Output()
    {
        Console.WriteLine();
        Console.WriteLine('"' + _Name + '"');
        foreach (T i in ar)
        {
            Console.Write(i);
            Console.Write(' ');
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}
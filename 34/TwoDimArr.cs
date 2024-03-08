using System;
sealed class TwoDimArr<T> : GenArray<T>
{
    private T[,] matrix;
    private int Width;
    private int Height;

    public TwoDimArr(string Name, int height, int width, bool input = false)
    {
        _Name = Name;
        matrix = new T[height, width];
        Width = width;
        Height = height;
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
        Console.WriteLine("Please, input " + '"' + _Name + '"' + " " + Height + " x " + Width);
        Console.WriteLine();
        for (int i = 0; i < Height; i++)
        {
            for (int j = 0; j < Width; j++)
            {
                Console.Write("[" + (i + 1) + " ; " + (j + 1) + "] = ");
                matrix[i, j] = ValueProcessor.Parse(Console.ReadLine());
            }
        }
    }
    protected override void Rand()
    {
        Random rand = new Random();
        for (int i = 0; i < Height; i++)
        {
            for (int j = 0; j < Width; j++)
            {
                matrix[i, j] = ValueProcessor.Rand();
            }
        }
    }
    public override void Output()
    {

        Console.WriteLine();
        Console.WriteLine('"' + _Name + '"');
        Output(false);
        Console.WriteLine();
        Console.WriteLine();
    }
    public void Output(bool reverse = false)
    {
        for (int i = 0; i < Height; i++)
        {
            for (int j = 0; j < Width; j++)
            {
                if (reverse && i % 2 == 0)
                {
                    Console.Write(matrix[i, Width - j - 1]);
                    Console.Write('\t');
                }
                else
                {
                    Console.Write(matrix[i, j]);
                    Console.Write('\t');
                }
            }
            Console.WriteLine();
        }
    }
}
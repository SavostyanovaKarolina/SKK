using System;
class P 
{
    static void Main() 
    {
        TwoDimArr twoDimArr = new TwoDimArr(3,5);
        Console.WriteLine("Среднее по массиву:" + twoDimArr.Avg().ToString());
        twoDimArr.Output();
        Console.WriteLine();
        twoDimArr.Output(true);
   }
}

class TwoDimArr
{
    private int[,] matrix;
    private int Width;
    private int Height;
    
    public TwoDimArr(int height, int width,bool input = false)
    {
        Random rand = new Random();
        matrix = new int[height,width];
        Width = width;
        Height = height;
        for(int i = 0; i < height; i++)
        {
            for(int j = 0; j < width; j++)
            {
                if(input)
                {
                    Console.WriteLine("Введите [" + i.ToString() + "," + j.ToString() + "]");
                    matrix[i,j] = int.Parse(Console.ReadLine());  
                }
                else
                {
                    matrix[i,j] = rand.Next(0,200);
                }
            }
        }
    }
    
    public double Avg()
    {
        int Sum = 0;
        for(int i =0; i < Height; i++)
        {
            for(int j =0; j < Width; j++)
            {
                Sum += matrix[i,j];
            }
        }
        return (1.0 * Sum) / (Width*Height);
    }
    
    public void Output(bool reverse = false)
    {
        for(int i = 0; i < Height; i++)
        {
            for(int j = 0; j < Width; j++)
            {
                if (reverse && i % 2 == 0)
                {
                    Console.Write(matrix[i,Width - j - 1] + "\t");
                }
                else
                {
                    Console.Write(matrix[i,j] + "\t");
                }
            }
            Console.WriteLine();
        }

    }
}

using System;
class P 
{
    static void Main() 
    {
        StepArr stepArr = new StepArr(3, true);
        Console.WriteLine("Среднее по массиву:" + stepArr.Avg().ToString());
        Console.WriteLine("Средние по массивам:");
        stepArr.StepAvg();
        stepArr.Mult();
        Console.WriteLine("Средние по массивам:");
        stepArr.StepAvg();
  }
}

class StepArr
{
    private int[][] step;
    private int Height;
    
    public StepArr(int height,bool input = false)
    {
        Random rand = new Random();
        step = new int[height][];
        Height = height;
        for(int i = 0; i < height; i++)
        {
            step[i] = new int [i + 1];
            for(int j = 0; j <= i; j++)
            {
                if(input)
                {
                    Console.WriteLine("Введите [" + i.ToString() + "," + j.ToString() + "]");
                    step[i][j] = int.Parse(Console.ReadLine());  
                }
                else
                {
                    step[i][j] = rand.Next(0,200);
                }
            }
        }
    }
    
    public double Avg()
    {
        int Sum = 0;
        int Count = 0;
        for(int i = 0; i < Height; i++)
        {
            for(int j = 0; j < step[i].Length; j++)
            {
                Sum += step[i][j];
                Count++;
            }
        }
        return ((1.0 * Sum) / Count);
    }
    
    public void StepAvg()
    {
        int Sum = 0;
        for(int i = 0; i < Height; i++)
        {
            Sum = 0;
            for(int j = 0; j < step[i].Length; j++)
            {
                Sum += step[i][j];
            }
            Console.WriteLine((1.0 * Sum) / step[i].Length);
        }
    }
    
    public void Mult()
    {
        for(int i = 0; i < Height; i++)
        {
            for(int j = 0; j < step[i].Length; j++)
            {
                if(step[i][j] % 2 == 0)
                {
                    step[i][j] = i * j;
                }
            }
        }
    }
}

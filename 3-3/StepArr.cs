using System;
sealed class StepArr : BaseArray
{
   private int[][] step;
   private int Height;
  
   public StepArr(int height,bool input = false)
   {
       step = new int[height][];
       Height = height;
       for(int i = 0; i < height; i++)
        {
            step[i] = new int[i + 1];
               
       }
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
       for(int i =0; i < Height; i++)
       {
           for(int j =0; j < i + 1; j++)
           {
               step[i][j] = int.Parse(Console.ReadLine());
           }
       }
   }
  
   protected override void Rand()
   {
       Random rand = new Random();
       for(int i = 0; i < Height; i++)
       {
           for(int j = 0; j < i + 1; j++)
           {
                step[i][j] = rand.Next(0,200);
           }
       }
   }


   public override double Avg()
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

   public override void Output()
   {
       for(int i = 0; i < Height; i++)
       {
           for(int j = 0; j < i + 1; j++)
           {
                Console.Write(step[i][j] + "\t");
           }
           Console.WriteLine();
       }
   }
}
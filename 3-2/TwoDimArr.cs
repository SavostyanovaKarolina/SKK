using System;
sealed class TwoDimArr : BaseArray
{
   private int[,] matrix;
   private int Width;
   private int Height;
  
   public TwoDimArr(int height, int width,bool input = false)
   {
       matrix = new int[height,width];
       Width = width;
       Height = height;
               if(input)
               {
                   Input();
               }
               else
               {
                   Rand();
               }
   }
   public override void Input()
   {
       for(int i =0; i < Height; i++)
       {
           for(int j =0; j < Width; j++)
           {
               matrix[i,j] = int.Parse(Console.ReadLine());
           }
       }
   }
   public override double Avg()
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
  
   public override void Rand()
   {
       Random rand = new Random();
       for(int i = 0; i < Height; i++)
       {
           for(int j = 0; j < Width; j++)
           {
                matrix[i,j] = rand.Next(0,200);
           }
       }
   }
    public override void Output()
    {
        Output(false);
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

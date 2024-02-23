using System;
sealed class OneDimArr : BaseArray
{
   private int[] ar;
   private int Len;
   public OneDimArr(int len, bool input = false)
   {
       Len = len;
       ar = new int[len];
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
       Console.WriteLine(ar);
       for (int i = 0; i < Len; i++)
       {
           ar[i] = int.Parse(Console.ReadLine());
       }
   }


   public override double Avg()
   {
       int sum = 0;
       for(int i = 0; i < ar.Length; i++)
       {
           sum += ar[i];
       }
       return (1.0 * sum) / ar.Length;
   }


   protected override void Rand()
   {
       Random rand = new Random();
       for(int i = 0; i < Len; i++)
       {
           ar[i] = rand.Next(0,200);
       }
   }
  
   public override void Output()
       {
           foreach (int i in ar)
           {
               Console.Write(i + " ");
           }
           Console.WriteLine();
       }
}
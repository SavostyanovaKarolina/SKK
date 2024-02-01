using System;
class P
{
   static void Main()
   {
       BaseArray one = new OneDimArr(5);
       BaseArray two = new TwoDimArr(3,5);
       BaseArray step = new StepArr(3);

       Console.WriteLine("One dim");
       one.Output();
       Console.WriteLine("Avg = " + one.Avg().ToString());
      
       Console.WriteLine("Two dim");
       two.Output();
       Console.WriteLine("Avg = " + two.Avg().ToString());

       Console.WriteLine("Step");
       step.Output();
       Console.WriteLine("Avg = " + step.Avg().ToString());

    }
}

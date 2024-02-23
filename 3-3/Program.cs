using System;
class P
{
   static void Main()
   {
       BaseArray[] list = [new OneDimArr(5), new TwoDimArr(3,5), new StepArr(3)];
       string[] names = ["One dim", "Two dim", "Step"];
       
       for(int i = 0; i<3; i++)
       {
              Console.WriteLine(names[i]);
              list[i].Output();
              Console.WriteLine("Avg = " + list[i].Avg().ToString());
       }       
    }
}

using System;
class P
{
   static void Main()
   {
       BaseArray[] list = [new OneDimArr<int>(5), new TwoDimArr<int>(3,5)];
       string[] names = ["One dim", "Two dim"];
       
       for(int i = 0; i<3; i++)
       {
              Console.WriteLine(names[i]);
              list[i].Output();
              Console.WriteLine("Avg = " + list[i].Avg().ToString());
       }       
    }
}
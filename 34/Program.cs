using System;
class P
{
    static void Main()
    {
        BaseArray[] Arrays = {new OneDimArr<bool>("OneDim Bool Random", 5)
                ,new OneDimArr<int>("OneDim Int Random", 5)
                ,new OneDimArr<double>("OneDim Double Random", 5)
                ,new OneDimArr<string>("OneDim String User", 5, true)
                ,new TwoDimArr<bool>("TwoDim Bool Random", 3,3)
                ,new TwoDimArr<int>("TwoDim Int User", 3,3,true)
                ,new TwoDimArr<double>("TwoDim Double Random", 3,3)
                ,new TwoDimArr<string>("TwoDim String Random", 3,3)
        };
        foreach (var arr in Arrays)
        {
            arr.Output();

        }
        Console.ReadKey();

    }
}

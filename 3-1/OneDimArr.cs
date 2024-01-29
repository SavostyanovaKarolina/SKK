using System;
class P 
{
    static void Main() 
    {
        OneDimArr oneDimArr = new OneDimArr(10);
        Console.WriteLine("Среднее по массиву:" + oneDimArr.Avg().ToString());
        oneDimArr.Del(100);
        Console.WriteLine("Среднее по массиву:" + oneDimArr.Avg().ToString());
	oneDimArr.Rep();
        Console.WriteLine("Среднее по массиву:" + oneDimArr.Avg().ToString());      
  }
}
class OneDimArr
{
    private int[] ar;

    public OneDimArr(int len, bool input = false)
    {
        Random rand = new Random();
        ar = new int[len];
        for(int i = 0; i < len; i++)
        {
            if (input)
            {
                Console.WriteLine("Введите число");
                ar[i] = int.Parse(Console.ReadLine());    
            }
            else
            {
                ar[i] = rand.Next(0,200);
            }
        }
    }
    
    public double Avg()
    {
        int sum = 0;
        for(int i = 0; i < ar.Length; i++)
        {
            sum += ar[i];
        }
        return (1.0 * sum) / ar.Length;
    }
    
    public void Del(int mod)
    {
        int newlen = 0;
        int[] ar2 = new int[ar.Length];
        for(int i = 0; i < ar.Length; i++)
        {
            if ((ar[i] <= mod) && (ar[i] >= -mod))
            {
                newlen ++;
            }
            ar2[i] = ar[i];
        }
        ar = new int[newlen];
        int j = 0;
        for(int i = 0; i < ar2.Length; i++)
        {
            if ((ar2[i] <= mod) && (ar2[i] >= -mod))
            {
                ar[j] = ar2[i];
                j++;
            }
        }
        /*for(int i = 0; i < ar.Length; i++)
        {
            Console.WriteLine(ar[i]);
        }*/
    }
    
    public void Rep()
    {
        int n;
        int[] ar2 = new int[ar.Length];
        int Len = 0;
        for(int i = 0; i < ar.Length; i++)
        {
            n = 1;
            for(int j = 0; j < i; j++)
            {  
                if(ar[j] == ar[i])
                {
                    n = 0;
                }
            }
            if(n == 1)
            {
                ar2[Len] = ar[i];
                Len++;
            }
        }
        ar = new int [Len];
        for(int i = 0; i < ar.Length; i++)
        {
            ar[i] = ar2[i];
        }

    }
}

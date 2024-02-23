using System; 
    public class Calend : IPrinter
    {
        Date time;
        

        public Calend() 
        {
            time = Date.Now;

        }

        public void Print()
        {
            for (int i = 0;  i<7; i++)
            {
                time += TimeSpan.FromDays(1);
                Console.WriteLine($"{i+1}： " + _time.DayOfWeek);
            }
            
        }
    }
}
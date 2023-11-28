public class Breathe : IntroOutro
{
    private int _time;
    public Breathe(string intro, string discription, int time):base(intro, discription, time)
    {
        _time = time;
    }


    public void breatheAct()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_time);

        Thread.Sleep(3000);

        
        while (DateTime.Now < futureTime)
        {
            
            getBreathIn();
            getBreathOut();
                      
            
        }

    }        


        private void getBreathIn()
        {
            Console.Write("\nBreath in... 5");
            Thread.Sleep(1000);
            Console.Write("..."); 
            
            Console.Write("4"); 
            Thread.Sleep(1000);
            Console.Write("..."); 
            
            Console.Write("3"); 
            Thread.Sleep(1000);
            Console.Write("..."); 
            
            Console.Write("2"); 
            Thread.Sleep(1000);
            Console.Write("..."); 
            Console.Write("1");
            Thread.Sleep(1000);
        }


        private void getBreathOut()
        {
            Console.Write("\nBreath out ... 5");
            Thread.Sleep(1000);
            Console.Write("..."); 
            
            Console.Write("4"); 
            Thread.Sleep(1000);
            Console.Write("..."); 
            
            Console.Write("3"); 
            Thread.Sleep(1000);
            Console.Write("..."); 
            
            Console.Write("2"); 
            Thread.Sleep(1000);
            Console.Write("..."); 
            Console.Write("1"); 
            Thread.Sleep(1000);
        }


}
using System.ComponentModel;

namespace customisertGodMorgenProgram;

class Program
{
    static void Main(string[] args)
    {
        DateTime currentTime = DateTime.Now;
        int time = currentTime.Hour;
        
        string greeting;
        
            if (currentTime.Hour > 5 && currentTime.Hour < 12)
            {
                greeting = "Good Morning!";
            }
            else if (currentTime.Hour < 12 && currentTime.Hour > 15)
            {
                greeting = "Good afternoon!";
            }
            else if (currentTime.Hour > 15 && currentTime.Hour < 20)
            {
                greeting = "Good evening!";
            }
            else if (currentTime.Hour > 20 && currentTime.Hour < 5)
            {
                 greeting = "Why are you up?";
            }
            else
            {
                greeting = "Homie aint checking the time before printing the message?";
            }


            Console.WriteLine("Hello, what is your name?");

        String navn = Console.ReadLine();

        String message = $"{greeting}, {navn}! Today is " + currentTime.ToLongDateString() + " and the time is " + currentTime.ToLongTimeString();
       
        Console.WriteLine(message);
    
    }
}

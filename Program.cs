using System.ComponentModel;

namespace customisertGodMorgenProgram;

class Program
{
    static void Main(string[] args)
    {
        DateTime currentTime = DateTime.Now;
        string greeting = "";

        if (currentTime.Hour > 5 && currentTime.Hour < 12)
        {
             greeting = "Good Morning!";
        }
        else if (currentTime.Hour > 12 && currentTime.Hour < 15)
        {
            greeting = "Good afternoon!";
        }
        else if (currentTime.Hour > 15 && currentTime.Hour < 20)
        {
            greeting = "Good evening!";
        }
        else if (currentTime.Hour > 20 && currentTime.Hour < 5)
        {
            greeting = "Sleepytime!";
        }
        else
        {
            greeting = "hell is going on here?!";
        }


        Console.WriteLine("Hello, what is your name?");

        string navn = Console.ReadLine()!;

        string message = $"{greeting}, {navn}! Today is {currentTime.ToLongDateString()} and the time is {currentTime.ToLongTimeString()}";

        Console.WriteLine(message);

        Console.WriteLine("Would you like to know how many days are left until Halloween?");
        string spookTober = Console.ReadLine()!;
        if (spookTober == "yes")
        {
            DateTime Halloween = new DateTime(currentTime.Year, 10, 31);
            if (Halloween < currentTime)
                Halloween = Halloween.AddYears(1);
            int daysLeft = (Halloween - currentTime.Date).Days;
            Console.WriteLine($"Its {daysLeft} days left until the spookiest time of year!");
        }
        if (spookTober == "no")
        {
            Console.WriteLine("Guess you dont like candy then..BYE");
        }
    
    }
}

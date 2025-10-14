namespace customisertGodMorgenProgram;

class Program
{
    static void Main(string[] args)
    {
        DateTime now = DateTime.Now;
        //Console.WriteLine(now);
        

        Console.WriteLine("Hello, what is your name?");

        String navn = Console.ReadLine();

        Console.WriteLine($"Hello, {navn}!");

        
    }
}

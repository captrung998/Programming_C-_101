public class Program
{
    public static void Main(string[] args)
    {
        //Part 1 Print a string to the console
        Console.WriteLine("Hello, World!");

        //Part 2 Get user input and print it to the console        
        Console.WriteLine("What your name?");
        string name = Console.ReadLine();
        Console.WriteLine("Hello " + name + ":)");

        //Part 3 Get two inputs from the user and print them on separate lines
        Console.WriteLine("How old are you?");
        string old = Console.ReadLine();
        Console.WriteLine("Hello " + name + "\n" + "Old: " + old);
    }
}
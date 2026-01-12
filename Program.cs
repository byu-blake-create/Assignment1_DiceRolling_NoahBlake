// See https://aka.ms/new-console-template for more information

using Assignment1_DiceRolling_NoahBlake;

internal class Program
{
    public static void Main(string[] args)
    {
        // Opening statement
        Console.WriteLine("Welcome to the dice throwing simulator!");
        Console.WriteLine("\n How many dice rolls would you like to simulate?: ");
        
        // get and convert the number of dice rolled 
        int num_dice = int.Parse(Console.ReadLine());
        
        // continuing opening statement
        Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine("Total number of rolls = " + num_dice);
        
        //DiceRoller roller = new DiceRoller(num_dice);
        
    }
}
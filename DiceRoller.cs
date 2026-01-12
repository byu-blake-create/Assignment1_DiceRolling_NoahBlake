namespace Assignment1_DiceRolling_NoahBlake;

public class DiceRoller
{
    public int[] RollDice(int roll_count)
    {
        int[] counts = new int[13];
        Random rand = new Random();
        for (int i = 0; i < roll_count; i++)
        {
            int die1 = rand.Next(1, 7);
            int die2 = rand.Next(1, 7);
            int sum = die1 + die2;
            counts[sum]++;
        }
        return counts;
    }
}
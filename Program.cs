using System;

public static class Program
{
    public static void Main()
    {
        Random rnd = new Random();
        int rounds = 10;
        int rivalWins = 0;
        int playerWins = 0;

        Console.WriteLine("Dice Game\n\nIn this game you and a computer Rival will play 10 rounds where you will each roll a 6-sided dice, and the player with the highest dice value will win the round. The player who wins the most rounds wins the game.\n\nGood luck! Press any key to start...");
        Console.ReadLine();
        for (int i = 1; i <= rounds; i++)
        {
            int rivalRoll = rnd.Next(1,7);
            int playerRoll = rnd.Next(1,7);
            int result = rivalRoll == playerRoll ? 0 : rivalRoll > playerRoll ? -1 : 1;

            Console.WriteLine($"Round {i}");
            Console.WriteLine($"Rival rolled a {rivalRoll}");
            Console.WriteLine("Press any key to roll the dice...");
            Console.ReadLine();

            Console.WriteLine($"You rolled a {playerRoll}");
            switch (result)
            {
                case -1:
                    Console.WriteLine("The Rival won this round.");
                    rivalWins++;
                    break;
                case 0:
                    Console.WriteLine("This round is a draw!");
                    break;
                case 1:
                    Console.WriteLine("You won this round.");
                    playerWins++;
                    break;
            }
            Console.WriteLine($"The score is now - You : {playerWins}. Rival : {rivalWins}.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
        Console.Clear();
        Console.WriteLine("Dice Game was closed.");
    }
}
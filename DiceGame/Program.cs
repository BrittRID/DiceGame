using System;

namespace DiceGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerRanNum;
            int rivalRanNum;

            int playerPoints = 0;
            int rivalPoints = 0;


            Random random = new Random();   

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Press any key to roll the dice!");
                
                Console.ReadKey();

                playerRanNum = random.Next(1, 7);
                Console.Write(" You rolled: " +   playerRanNum);

                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);

                rivalRanNum = random.Next(1, 7);
                Console.WriteLine(" Rival AI rolled  " + rivalRanNum);

                if(playerRanNum == rivalRanNum)
                {
                    playerPoints++;
                    Console.WriteLine(" Player wins this round!");
                }
                else if (playerRanNum > rivalRanNum)
                {
                    rivalPoints++;
                    Console.WriteLine(" Rival wins this round!");
                }
                else
                {
                    Console.WriteLine(" Draw!");
                }

                Console.WriteLine(" The score is now - Player : " + playerPoints + ". Rival : " + rivalPoints + ".");
                Console.WriteLine();
            }

            if ( playerPoints > rivalPoints)
            {
                Console.WriteLine("You win!");

            }
            else if (playerPoints < rivalPoints)
            {
                Console.WriteLine("You lose!");
            }
            else
            {
                Console.WriteLine("It's a draw!");
            }

            Console.ReadKey();

        }
    }
}

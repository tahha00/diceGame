namespace diceGame
{
     class Program
    {
        static void Main()
        {

            string playAgain = "y"; //initialise playAgain with "y"

            while (playAgain != "n")
            {
                Console.WriteLine("Click a key to roll your dice!");
                Console.ReadLine();

                int myDice = diceRoll();
                Console.WriteLine($"Your total is {myDice}");

                Console.WriteLine("\nClick a key to see the computer's roll");
                Console.ReadLine();

                int computerDice = diceRoll();
                Console.WriteLine($"Computer's total roll is {computerDice}");


                if (myDice > computerDice)
                {
                    Console.WriteLine("\nYou have won!");
                }
                else if (computerDice > myDice)
                {
                    Console.WriteLine("\nYou have lost!");
                }
                else
                {
                    Console.WriteLine("\nIt is a draw!");
                }

                Console.WriteLine("\nTo play again press any key, or to stop playing press n: ");
                playAgain = Console.ReadLine().ToLower();
            }



        }
        static int diceRoll()
        {
            Random dice = new Random();
            int firstDice = dice.Next(1, 7);
            int secondDice = dice.Next(1, 7);

            int diceTotal = firstDice + secondDice;

            Console.WriteLine($"Rolled {firstDice} and {secondDice}");

            return diceTotal;
        }

    }
}

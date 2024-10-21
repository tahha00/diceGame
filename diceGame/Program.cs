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

                int myDiceTotal = diceRoll();
                Console.WriteLine($"Your total is {myDiceTotal}");

                Console.WriteLine("Click a key to see the computer's roll");
                Console.ReadLine();

                int computerDiceTotal = diceRoll();
                Console.WriteLine($"Computer's total roll is {computerDiceTotal}");


                if (myDiceTotal > computerDiceTotal)
                {
                    Console.WriteLine("You have won!");
                }
                else if (computerDiceTotal > myDiceTotal)
                {
                    Console.WriteLine("You have lost!");
                }
                else
                {
                    Console.WriteLine("It is a draw!");
                }

                Console.WriteLine("To play again press any key, or to stop playing press n: ");
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

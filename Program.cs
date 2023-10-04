internal class Program
{
    private static void Main(string[] args)
    {
        Random random = new Random();
        bool playAgain = true;
        string playersChoice;
        string computersChoice;
        string answer;

        while(playAgain)
        {
            playersChoice = "";
            computersChoice = "";
            answer = "";

            while (playersChoice != "ROCK" && playersChoice != "PAPER" && playersChoice != "SCISSORS")
            {
                Console.WriteLine("Enter ROCK, PAPER, or SCISSORS: ");
                Console.WriteLine();
                playersChoice = Console.ReadLine().ToUpper();

            }
 
            switch(random.Next(1, 4))
            {
                case 1:
                    computersChoice = "ROCK";
                    break;
                case 2:
                    computersChoice = "PAPER";
                    break;
                case 3: computersChoice = "SCISSORS";
                    break;
            }

            Console.WriteLine();
            Console.WriteLine(" Players choice: " + playersChoice);
            Console.WriteLine(" Computers choice: " + computersChoice);

            switch(playersChoice)
            {
                case "ROCK":
                    if(computersChoice == "ROCK")
                    {
                        Console.WriteLine();
                        Console.WriteLine("\tIt's a draw!");
                    }
                    else if(computersChoice == "PAPER")
                    {
                        Console.WriteLine();
                        Console.WriteLine("\tYOU LOSE!");
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("\tYOU WIN!");
                    }
                    break;
                case "PAPER":
                    if(computersChoice == "ROCK")
                    {
                        Console.WriteLine();
                        Console.WriteLine("\tYOU WIN!");
                    }
                    else if(computersChoice == "PAPER")
                    {
                        Console.WriteLine();
                        Console.WriteLine("\tIt's a draw!");
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("\tYOU LOSE!");
                    }
                    break;
                case "SCISSORS":
                    if(computersChoice == "ROCK")
                    {
                        Console.WriteLine();
                        Console.WriteLine("\tYOU LOSE!");
                    }
                    else if(computersChoice == "PAPER")
                    {
                        Console.WriteLine();
                        Console.WriteLine("YOU WIN!");
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("\tIt's a draw!");
                    }
                    break;
            }

        Console.WriteLine("Would you like yo play again? Y = Yes, N = No");
        answer = Console.ReadLine().ToUpper();

        if(answer == "Y")
        {
            playAgain = true;
        }
        else
        {
            playAgain = false;
        }

        }


        Console.WriteLine("Thanks for playing!");
    }


}
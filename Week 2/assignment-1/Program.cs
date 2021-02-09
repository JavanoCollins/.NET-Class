using System;

namespace assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            String replay = "Y";

            Console.WriteLine("Enter your name: ");
            String name = Console.ReadLine();

            Console.WriteLine("Hello " + name + ", Welcome to Rock, Papers, Scissors.");


            String userChoice = "";
            String computerChoice = "";

            // Track number of wins
            int userWins = 0;
            int computerWins = 0;

            // Track number of losses
            int userLost = 0;
            int computerLost = 0;

            // Track number of draws
            int bothWins = 0;

            while (replay.ToLower() != "n")
            {

                Console.WriteLine("Enter your choice (0=rock, 1=paper, 2=scissors)");
                int userNum = Convert.ToInt32(Console.ReadLine());
                int computerRnd = rnd.Next(0, 3);

                // User choice asignment
                if (userNum == 0) {
                    userChoice = "ROCK";
                } else if (computerRnd == 1) {
                    userChoice = "PAPER";
                } else {
                    userChoice = "SCISSORS";
                }

                // Computer choice assignment
                if (computerRnd == 0) {
                    computerChoice = "ROCK";
                } else if (computerRnd == 1) {
                    computerChoice = "PAPER";
                } else {
                    computerChoice = "SCISSORS";
                }

                // Checks if user and computer 
                // select the same choice.
                if (userChoice == computerChoice) {
                    Console.WriteLine(name + " select " + userChoice);
                    Console.WriteLine("Computer select " + computerChoice);
                    Console.WriteLine("It's a tie");
                    bothWins++;
                }

                switch (userNum)
                {
                    // If chose ROCK
                    case 0:
                        // If computer chose PAPER
                        if (computerRnd == 1) {
                            Console.WriteLine(name + " selects ROCK");
                            Console.WriteLine("Computer selects PAPER");
                            Console.WriteLine("Computer is the winner");
                            computerWins++;
                            userLost++;
                            break;
                        }

                        // If computer chose SCISSORS
                        else if (computerRnd == 2) {
                            Console.WriteLine(name + " selects ROCK");
                            Console.WriteLine("Computer selects SCISSORS");
                            Console.WriteLine(name + " is the winner");
                            userWins++;
                            computerLost++;
                            break;
                        }
                        break;

                    // If user chose PAPER
                    case 1:
                        // If computer chose SCISSORS
                        if (computerRnd == 2) {
                            Console.WriteLine(name + " selects PAPER");
                            Console.WriteLine("Computer selects SCISSORS");
                            Console.WriteLine("Computer is the winner");
                            computerWins++;
                            userLost++;
                            break;
                        }
                        // If computer chose ROCK
                        else if (computerRnd == 0) {
                            Console.WriteLine(name + " selects PAPER");
                            Console.WriteLine("Computer selects ROCK");
                            Console.WriteLine(name + " is the winner");
                            userWins++;
                            computerLost++;
                            break;
                        }
                        break;
                    // If user chose SCISSORS
                    case 2:
                        // If computer chose ROCK
                        if (computerRnd == 0) {
                            Console.WriteLine(name + " selects SCISSORS");
                            Console.WriteLine("Computer selects ROCK");
                            Console.WriteLine("Computer is the winner");
                            computerWins++;
                            userLost++;
                            break;
                        }
                        // If computer chose PAPER
                        else if (computerRnd == 1) {
                            Console.WriteLine(name + " selects SCISSORS");
                            Console.WriteLine("Computer selects PAPER");
                            Console.WriteLine(name + " is the winner");
                            userWins++;
                            computerLost++;
                            break;
                        }
                        break;
                }
                // End of while loop

                Console.WriteLine("Play again? (Y/N)");
                replay = Console.ReadLine();
                Console.WriteLine("");

                if (replay.ToLower() == "n")
                {
                    // Display number of wins
                    Console.WriteLine(name + " wins " + userWins + " time(s)");
                    Console.WriteLine("Computer wins " + computerWins + " time(s)\n");

                    // Display number of losts
                    Console.WriteLine(name + " lost " + userLost + " time(s)");
                    Console.WriteLine("Computer lost " + computerLost + " time(s)\n");

                    Console.WriteLine("The game resulted in a tie " + bothWins + " time(s)");
                };
            }

        }
    }
}

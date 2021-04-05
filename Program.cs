using System;

namespace Rock_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string rock = "rock";
            string paper = "paper";
            string scissors = "scissors";
            string answerUser = "Yes";
            Random random = new Random();

            Console.WriteLine($"Welcome to the {rock} {paper} {scissors} game! Would you like to continue? Y / N");
            ConsoleKeyInfo userInput = System.Console.ReadKey();
            while (answerUser == "Yes")
            {
                if (userInput.Key == ConsoleKey.Y)
                {
                    Console.Clear();
                    Console.WriteLine($"You will be playing versus the computer, the possibilites are endless");
                    Console.WriteLine($"You have three options in this game Rock, Paper, or Scissors");
                    Console.WriteLine($"Choose one (R)ock, (P)aper, or (S)cissors...");
                    ConsoleKeyInfo userInputGame = System.Console.ReadKey();
                    if (userInputGame.Key == ConsoleKey.R)
                    {
                        Console.Clear();
                        int computerProbability = 25;
                        int next = random.Next(1, 50);
                        if (computerProbability == next)
                        {
                            string computerChoice = "Rock";
                            Console.WriteLine($"You choose rock the computer choose {computerChoice} you tie!");
                            Console.WriteLine($"Do you want to play again? Y / N");
                            ConsoleKeyInfo answer = System.Console.ReadKey();
                            if (answer.Key == ConsoleKey.Y)
                            {
                                Console.ReadLine().ToUpper();
                            }
                            else if (answer.Key == ConsoleKey.N)
                            {
                                Console.Clear();
                                answerUser = "No";
                                Console.WriteLine("Come back again later!");
                            }
                        }
                        else if (computerProbability > next)
                        {
                            string computerChoice = "Paper";
                            Console.WriteLine($"You choose rock the computer choose {computerChoice} you lose haha!");
                            Console.WriteLine($"Do you want to play again? Y / N");
                            ConsoleKeyInfo answer = System.Console.ReadKey();
                            if (answer.Key == ConsoleKey.Y)
                            {
                                Console.ReadLine().ToUpper();
                            }
                            else if (answer.Key == ConsoleKey.N)
                            {
                                Console.Clear();
                                answerUser = "No";
                                Console.WriteLine("Come back again later!");
                            }
                        }
                        else if (computerProbability < next)
                        {
                            string computerChoice = "Scissors";
                            Console.WriteLine($"You choose rock the computer choose {computerChoice} you win haha!");
                            Console.WriteLine($"Do you want to play again? Y / N");
                            ConsoleKeyInfo answer = System.Console.ReadKey();
                            if (answer.Key == ConsoleKey.Y)
                            {
                                Console.ReadLine().ToUpper();
                            }
                            else if (answer.Key == ConsoleKey.N)
                            {
                                Console.Clear();
                                answerUser = "No";
                                Console.WriteLine("Come back again later!");
                            }
                        }
                    }
                    else if (userInputGame.Key == ConsoleKey.P)
                    {
                        Console.Clear();
                        int computerProbability = 25;
                        int next = random.Next(1, 50);
                        if (computerProbability == next)
                        {
                            string computerChoice = "paper";
                            Console.WriteLine($"You choose paper the computer choose {computerChoice} you tie!");
                            Console.WriteLine($"Do you want to play again? Y / N");
                            ConsoleKeyInfo answer = System.Console.ReadKey();
                            if (answer.Key == ConsoleKey.Y)
                            {
                                Console.ReadLine().ToUpper();
                            }
                            else if (answer.Key == ConsoleKey.N)
                            {
                                Console.Clear();
                                answerUser = "No";
                                Console.WriteLine("Come back again later!");
                            }
                        }
                        else if (computerProbability > next)
                        {
                            string computerChoice = "scissors";
                            Console.WriteLine($"You choose paper the computer choose {computerChoice} you lose! haha");
                            Console.WriteLine($"Do you want to play again? Y / N");
                            ConsoleKeyInfo answer = System.Console.ReadKey();
                            if (answer.Key == ConsoleKey.Y)
                            {
                                Console.ReadLine().ToUpper();
                            }
                            else if (answer.Key == ConsoleKey.N)
                            {
                                Console.Clear();
                                answerUser = "No";
                                Console.WriteLine("Come back again later!");
                            }
                        }
                        else if (computerProbability < next)
                        {
                            string computerChoice = "rock";
                            Console.WriteLine($"You choose paper the computer choose {computerChoice} you win!");
                            Console.WriteLine($"Do you want to play again? Y / N");
                            ConsoleKeyInfo answer = System.Console.ReadKey();
                            if (answer.Key == ConsoleKey.Y)
                            {
                                Console.ReadLine().ToUpper();
                            }
                            else if (answer.Key == ConsoleKey.N)
                            {
                                Console.Clear();
                                answerUser = "No";
                                Console.WriteLine("Come back again later!");
                            }
                        }
                    }
                    else if (userInputGame.Key == ConsoleKey.S)
                    {
                        Console.Clear();
                        int computerProbability = 25;
                        int next = random.Next(1, 50);
                        if (computerProbability == next)
                        {
                            string computerChoice = "scissors";
                            Console.WriteLine($"You choose scissors the computer choose {computerChoice} you tie!");
                            Console.WriteLine($"Do you want to play again? Y / N");
                            ConsoleKeyInfo answer = System.Console.ReadKey();
                            if (answer.Key == ConsoleKey.Y)
                            {
                                Console.ReadLine().ToUpper();
                            }
                            else if (answer.Key == ConsoleKey.N)
                            {
                                Console.Clear();
                                answerUser = "No";
                                Console.WriteLine("Come back again later!");
                            }
                        }
                        else if (computerProbability > next)
                        {
                            string computerChoice = "rock";
                            Console.WriteLine($"You choose scissors the computer choose {computerChoice} you lose");
                            Console.WriteLine($"Do you want to play again? Y / N");
                            ConsoleKeyInfo answer = System.Console.ReadKey();
                            if (answer.Key == ConsoleKey.Y)
                            {
                                Console.ReadLine().ToUpper();
                            }
                            else if (answer.Key == ConsoleKey.N)
                            {
                                Console.Clear();
                                answerUser = "No";
                                Console.WriteLine("Come back again later!");
                            }
                        }
                        else if (computerProbability < next)
                        {
                            string computerChoice = "paper";
                            Console.WriteLine($"You choose scissors the computer choose {computerChoice} you win!");
                            Console.WriteLine($"Do you want to play again? Y / N");
                            ConsoleKeyInfo answer = System.Console.ReadKey();
                            if (answer.Key == ConsoleKey.Y)
                            {
                                Console.ReadLine().ToUpper();
                            }
                            else if (answer.Key == ConsoleKey.N)
                            {
                                Console.Clear();
                                answerUser = "No";
                                Console.WriteLine("Come back again later!");
                            }
                        }
                    }
                }
                else if (userInput.Key == ConsoleKey.N)
                {
                    Console.Clear();
                    Console.WriteLine("Aweeee :( you don't want to play the game with us? Try again later!");
                }
            }
        }
    }
}

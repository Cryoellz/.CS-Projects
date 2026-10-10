using System.Numerics;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.Write("What is your first name: ");
            string? firstName = Console.ReadLine();

            Console.WriteLine("Your first name is " + firstName);

            Console.ReadLine(); //allows to run the application without in visual studio
            //ginagawa niya is parang extra line lang paa di rin magautomatically close siya pag nirun through file directory 
        }
    }

    internal class ProgramUnit4
    {
        static void Main(string[] args)
        {
            string text = "Hello";
            Console.WriteLine(text.ToUpper()); // outputs: HELLO makes all capital
            Console.WriteLine(text.ToLower()); //outputs: hello makes all lower case
            Console.WriteLine(text.Replace("H", "J")); //outputs: Jello pinapalitan yung first letter
            Console.WriteLine(text.Length); //outputs: 5 it identifies the number of letters sa text

            //Concatenation (+)
            Console.WriteLine(first + ", " + last + " ! ");

            //String interpolation ($"...")
            Console.WriteLine($"Hello, {name}!");

            //using int (using Parse)
            Console.Write("What is your age? ");
            int age = int.Parse(Console.ReadLine());
        }
    }

    internal class ProgramLoops
    {
        static void Main(string[] args)
        {
            //for loop
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i); //prints 0 1 2 3 4 5
            }

            //while loop
            int health = 3;
            while (health > 0)
            {
                Console.WriteLine("Player is alive: {health} "); //prints Player is alive: health 3 then pababa ng 1 then the loop will exterminate
                health--;
            }

            //do while loop
            int attempts = 0;
            do
            {
                attempts++;
                Console.WriteLine($"Attempt number {attempts};") //print Attempt number 1 ... Attempt number 3
            }
            while (attempts < 3);


            //Controlling Loop using breaks;
            for (int count = 0; count < 10; i++)
            {
                if (count == 5)
                {
                    break:
                        Console.WriteLine(count); //prints 0 1 2 3 4 because we break it in count == 5
                }
                Console.WriteLine("Loop Ended");
            }

            //Continue: Skipping iteration
            for (int count = 0; count < 10; int++)
            {
                if (count == 4)
                {
                    continue:
                        Console.WriteLine(count); //prints 1 2 3 5 8 9 10
                }
                Console.WriteLine("Loop Ended");
            }

            //Managing Loops using break
            while (true)
            {
                Console.Write("Type 'exit' to stop the loop: ");
                string userInput = Console.ReadLine();

                if (userInput.ToLower() == "exit")
                {
                    break;
                }

                Console.WriteLine($"You entered: {userInput}");
            }

            Console.WriteLine("Goodbye!");

            //Using Continue in While Loops
            int currentSlot = 0;

            while (currentSlot < 5)
            {
                currentSlot++; // Crucial: the update happens before the continue check

                if (currentSlot == 3)
                {
                    Console.WriteLine($"Skipping item slot {currentSlot}.");
                    continue;
                }

                Console.WriteLine($"Successfully processed item in slot {currentSlot}.");
            }

            Console.WriteLine("Inventory scan complete!");

            //ASSESSMENT SECRET NUMBER GAME
            // Set up the game
            Random random = new Random();
            int secretNumber = random.Next(1, 21);
            int maxGuesses = 5;
            int guessCount = 0;
            bool hasWon = false;

            Console.WriteLine("I'm thinking of a number between 1 and 20.");
            Console.WriteLine($"You have {maxGuesses} guesses. Good luck!");

            // Ask the player to guess
            while (guessCount < maxGuesses)
            {
                guessCount++;
                Console.Write($"\nGuess #{guessCount}: ");
                int guess = Convert.ToInt32(Console.ReadLine());

                // Check the guess and give feedback
                if (guess == secretNumber)
                {
                    Console.WriteLine($"Correct! You got it in {guessCount} guesses.");
                    hasWon = true;
                    break;
                }
                else if (guess < secretNumber)
                {
                    Console.WriteLine("Too low.");
                }
                else
                {
                    Console.WriteLine("Too high.");
                }
            }

            // Announce the result
            if (!hasWon)
            {
                Console.WriteLine($"\nOut of guesses! The number was {secretNumber}.");
            }

        }
    }

    internal class ProgramArrays
    {
        static void Main(string[] args)
        {
            //Iterating using an array
            int[] scores = { 95, 82, 76, 91 };

            foreach (int score in scores)
            {
                Console.WriteLine(score); //OUTPUTS 95, 82, 76, 91
            }

            //Creating a List
            List<string> colors = new List<string> { "red", "green", "blue" };
            List<int> scores = new List<int>();
            /* list.Count - Returns the number of items
            list.Add(value)	- Adds an item to the end of the list
            list.Remove(value) - Removes the first matching item
            list[i] = value -	Overwrites the item at index i
            list.RemoveAt(i) - Removes the item at index i
            list.Sort() -	Sorts the list in place */

            List<string> colors = new List<string> { "red", "green", "blue" };

            Console.WriteLine(colors.Count); // Output: 3
            colors.Add("yellow");            // Adds "yellow" to the end
            Console.WriteLine(colors.Count); // Output: 4

            colors.Remove("red");            // Removes "red"
            colors[0] = "purple";            // Replaces "green" with "purple"

            //Iterating over a list
            List<int> scores = new List<int> { 95, 82, 76, 91 };

            foreach (int score in scores)
            {
                Console.WriteLine(score); //OUTPUTS 95, 82, 76, 91
            }

            //ASSESSMENT TOP 5 LEADERBOARD
            // Set up the game
            Random random = new Random();
            int roundsPlayed = 8;
            List<int> allScores = new List<int>();

            Console.WriteLine($"Playing {roundsPlayed} rounds...\n");

            // Simulate playing rounds and log every score
            for (int round = 1; round <= roundsPlayed; round++)
            {
                int score = random.Next(0, 101);
                allScores.Add(score);
                Console.WriteLine($"Round {round}: scored {score} points");
            }

            Console.WriteLine($"\nTotal rounds logged: {allScores.Count}");

            // Build the Top 5 leaderboard array
            allScores.Sort();
            allScores.Reverse();

            int[] topScores = new int[5];

            for (int i = 0; i < topScores.Length; i++)
            {
                topScores[i] = allScores[i];
            }

            // Print the leaderboard
            Console.WriteLine("\n🏆 Top 5 Leaderboard 🏆");

            for (int i = 0; i < topScores.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {topScores[i]} points");
            }



        }
    }
}

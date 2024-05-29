
using static System.Console;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment1
{
    /// <summary>
    /// Details related to FizzBuzz game.
    /// </summary>
    class FizzBuzz {
        /// <summary>
        /// Print a simulation of the FizzBuzz game.
        /// </summary>
        /// <param name="n">The number of times that the fizzbuzz game will go up to.</param>
        public static void PrintSimulatedFizzBuzzGame(int n) {
            for (int i = 1; i <= n; i++) {
                string player = (i % 2 == 1) ? "Player 1" : "Player 2";
                bool divisibleBy5 = i % 5 == 0;
                bool divisibleBy3 = i % 3 == 0;
                if (divisibleBy3 && divisibleBy5)
                {
                    Console.WriteLine($"{player}: fizzbuzz");
                }
                else if (divisibleBy3)
                {
                    Console.WriteLine($"{player}: fizz");
                }
                else if (divisibleBy5)
                {
                    Console.WriteLine($"{player}: buzz");
                }
                else {
                    Console.WriteLine($"{player}: {i}");
                }
            }
        }

        /// <summary>
        /// What will happen if this code executes?
        /// The code will fail to execute because WriteLine does not exist in the current context.
        /// Even if you fix the problem, the code will enter an infinite loop because the byte value has a maximum value of 255, so it will never go past the maximum value.
        /// What code could you add to warn us about the problem?
        /// You can add comments to state that the code will be an infinite loop.
        /// </summary>
        public static void ErrorCodeAnalysis() {
            int max = 500;
            // the max value of byte is 255, so this is an infinite loop.
            for (byte i = 0; i < max; i++)
            {
                WriteLine(i);
            }
        }
    }
    class PrintAPyramid {
        /// <summary>
        /// Print a pyramid on the console with a particular height.
        /// </summary>
        /// <param name="n">The number of layers that the pyramid should have.</param>
        public static void PrintNumberOfLayers(int n) {
            for (int i = 1, stars = 1, spaces = n - 1; i <= n; i++, stars += 2, spaces -= 1) {
                for (int j = 0; j < spaces; j++) {
                    Console.Write(" ");
                }
                for (int j = 0; j < stars; j++) {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

    }
    class RandomNumberGuesser {
        /// <summary>
        /// A random number is generated and the user guesses that number.
        /// There is an assumption that only integer values are inputted by the user.
        /// </summary>
        public static void PlayRandomNumberGuessingGame()
        {
            int correctNumber = new Random().Next(3) + 1;
            Console.WriteLine("A random number is generated between 1 and 3.");
            Console.Write("Guess the number: ");
            int guessedNumber = int.Parse(Console.ReadLine());
            if (guessedNumber < 1 || guessedNumber > 3)
            {
                Console.WriteLine("The number you entered is out of range.");
            }
            else if (guessedNumber == correctNumber)
            {
                Console.WriteLine("The number you entered is correct.");
            }
            else if (guessedNumber < correctNumber)
            {
                Console.WriteLine("The number you entered is lower than the correct answer.");
            }
            else
            {
                Console.WriteLine("The number you entered is higher than the correct answer.");
            }
        }
    }
    class AgeCalculator {
        /// <summary>
        /// Calculates the number of days old a person is given the birth date.
        /// </summary>
        /// <param name="birthday">The birth date of the person</param>
        public static void CalculateDaysOld(DateOnly birthday) {
            int days = (int)(DateTime.Now - (birthday.ToDateTime(new TimeOnly()))).TotalDays;
            Console.WriteLine($"A person born on 01/01/2000 has lived {days} days.");
            int daysToNextAnniversary = 10000 - (days % 10000);
            Console.WriteLine($"You have {daysToNextAnniversary} days until your next 10000 day anniversary.");
        }
    }
    class Greetings {
        public static void PrintGreetings() {
            switch (DateTime.Now.Hour) {
                case 21:
                case 22:
                case 23:
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("Good Night");
                    break;
                case 7:
                case 8:
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Good Morning");
                    break;
                case 12:
                case 13:
                case 14:
                case 15:
                case 16:
                    Console.WriteLine("Good Afternoon");
                    break;
                case 17:
                case 18:
                case 19:
                case 20:
                    Console.WriteLine("Good Evening");
                    break;

            }
        }
    }
    class Counting {
        /// <summary>
        /// Print increments up to n by counting by ones, then by twos, then by threes, all the way up to the increments variable stated.
        /// </summary>
        /// <param name="n">The number to print increments up to</param>
        /// <param name="increments">The increments to count by.</param>
        public static void PrintIncrements(int n, int increments) {

            for (int i = 1; i <= increments; i++) {
                Console.Write("0");
                for (int j = i; j <= n; j += i) {
                    Console.Write($",{j}");
                }
                Console.WriteLine();
            }
            
        }
    }

    class Exercise03 {
        public static void Main(string[] args) {
            FizzBuzz.PrintSimulatedFizzBuzzGame(100);
            WriteLine("\n\n\n");
            //FizzBuzz.ErrorCodeAnalysis();
            //WriteLine("\n\n\n");
            PrintAPyramid.PrintNumberOfLayers(5);
            WriteLine("\n\n\n");
            RandomNumberGuesser.PlayRandomNumberGuessingGame();
            WriteLine("\n\n\n");
            AgeCalculator.CalculateDaysOld(new DateOnly(2000, 1, 1));
            WriteLine("\n\n\n");
            Greetings.PrintGreetings();
            WriteLine("\n\n\n");
            Counting.PrintIncrements(24, 4);
        }
    }
}
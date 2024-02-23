using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Number Guess Game!\n" +
                           "Level 1 (Easy): 8 attempts\n" +
                           "Level 2 (Medium): 5 attempts\n" +
                           "Level 3 (Hard): 3 attempts\n");

        bool loop = true;
        while (loop)
        {
            Console.Write("\nChoose a level: ");

            int level = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n");

            if (level == 1)
            {
                Guesser guesserLevel1 = new Guesser(8);
                guesserLevel1.Play();
            }

            else if (level == 2)
            {
                Guesser guesserLevel2 = new Guesser(5);
                guesserLevel2.Play();
            }

            else if (level == 3)
            {
                Guesser guesserLevel3 = new Guesser(3);
                guesserLevel3.Play();
            }

            else
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }

    class Guesser
    {
        private int maxAttempts;
        private int randomNumber;
        private bool won;

        public Guesser(int maxAttempts)
        {
            this.maxAttempts = maxAttempts;
            Random rnd = new Random();
            this.randomNumber = rnd.Next(0, 101);
            this.won = false;
        }

        public void Play()
        {
            Console.WriteLine("Enter a number: ");
            for (int i = 1; i <= maxAttempts; i++)
            {
                int numGuess = Convert.ToInt32(Console.ReadLine());
                if (numGuess > randomNumber)
                {
                    Console.WriteLine("Go lower!");
                }
                else if (numGuess < randomNumber)
                {
                    Console.WriteLine("Go higher!");
                }
                else if (numGuess == randomNumber)
                {
                    Console.WriteLine("You guessed the number!");
                    won = true;
                    break;
                }
            }
            if (!won)
            {
                Console.WriteLine($"The number is {randomNumber}. You didn't guess it! Try again!");
            }
        }
    }

}
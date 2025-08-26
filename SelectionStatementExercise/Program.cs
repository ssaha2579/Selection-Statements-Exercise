using System.ComponentModel.Design;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            var random = new Random();
            var favNumber = random.Next(1, 11);  
            int response = 0;

            while (response != favNumber)
            {
                Console.WriteLine("Guess my favorite number, from the range between 1 to 10 and zero or negatives are invalid");
 
                bool isValid = int.TryParse(Console.ReadLine(), out response);

                if (!isValid || response <= 0 || response > 10)
                {
                    Console.WriteLine("Invalid input, please enter a number between 1 and 10.");
                    continue;
                }

                if (response < favNumber)
                {
                    Console.WriteLine($"Too Low! Your guess: {response}");
                }
                else if (response > favNumber)
                {
                    Console.WriteLine($"Too High! Your guess: {response}");
                }
                else
                {
                    Console.WriteLine($"You guessed it correctly! My favorite number was {favNumber}");
                }
            }
        }
    }
}
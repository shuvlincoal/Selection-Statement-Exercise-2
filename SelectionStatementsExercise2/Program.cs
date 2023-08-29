namespace SelectionStatementsExercise2
{
    public class Program
    {

        static void Guess()
        {
            var r = new Random();
            var favNumber = r.Next(1, 8);
            int guessNbr = 0;

            Console.WriteLine($"Guess a number between 1 and 8");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput == favNumber)
            {
                Console.WriteLine($"You guessed it, {favNumber} was it");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine($"Guess is to high");
            }

            else if (userInput < favNumber)
            {
                Console.WriteLine($"Guess is to low");
            }

            else
            {
                Console.WriteLine($"I have no idea what you meant");
            }

        }



        static void Main(string[] args)
        {
            Guess();

            Console.WriteLine($"What is your favorite school subject? ");
            string userInput = (Console.ReadLine());

            switch (userInput)
            {
            case "english":
                    Console.WriteLine($"Helps to communicate");
                    break;
                case "math":
                    Console.WriteLine($"Numbers are your friend");
                    break;
                default:
                    Console.WriteLine($"Its all good");
                    break;
            }//end case
        }//Main
    }//Program
}//Namespace

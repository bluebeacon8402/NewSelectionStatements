using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please guess a random number");
            var r = new Random();
            var favNumber = r.Next(1, 1000);
            var userInput = int.Parse(Console.ReadLine());

            if (favNumber > userInput)
            {
                Console.WriteLine("Too Low");
            }

            else if (favNumber < userInput)
            {
                Console.WriteLine("Too High");
            }

            else 
            {
                Console.WriteLine("Nevermind");
            }

            Console.WriteLine("What is your favorite subject in school?");
            string subject = Console.ReadLine();
            switch (subject)
            {
                case "english":
                    Console.WriteLine("Your favorite subject is english");
                    break;
                case "math":
                    Console.WriteLine("Your favorite subject is math");
                    break;
                case "geography":
                    Console.WriteLine("Your favorite subject is geography");
                    break;
                case "typing":
                    Console.WriteLine("Your favorite subject is typing");
                    break;
                case "history":
                    Console.WriteLine("Your favorite subject is history");
                    break;
                default:
                    Console.WriteLine("Your favorite subject is not listed");
                    break;

            }



        }
    }
}

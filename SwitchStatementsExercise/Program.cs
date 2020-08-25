using System;

namespace SwitchStatementsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");

            var subject = Console.ReadLine();

            switch (subject)
            {
                case "Math":
                    Console.WriteLine("Math is awesome!!");
                    break;
                case "Science":
                    Console.WriteLine("Science was cool but Chemistry sucked.");
                    break;
                case "English":
                    Console.WriteLine("Nice, do you know Queen's English?");
                    break;
                case "Geography":
                    Console.WriteLine("Now that was my favorite subject also!!");
                    break;



                default:
                    Console.WriteLine("Ah, I have never taken that subject before.");
                    break;







            }
        }
    }
}

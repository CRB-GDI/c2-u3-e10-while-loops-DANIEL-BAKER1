using System.Xml.Serialization;

namespace Exercise10PM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;

            while (choice != 4)
            {
                //Print menu
                Console.WriteLine("**************");
                Console.WriteLine("Menu:");
                Console.WriteLine("1 - New Game");
                Console.WriteLine("2 - Load Game");
                Console.WriteLine("3 - Options");
                Console.WriteLine("4 - Quit");
                Console.WriteLine("**************");
                Console.WriteLine();

                //prompt for and get user choice
                Console.WriteLine("Please enter 1, 2, 3, or 4");
                choice = int.Parse(Console.ReadLine());
                Console.WriteLine(choice);
            }
        }
    }
}
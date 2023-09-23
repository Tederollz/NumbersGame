// Linus Aspelöf SUT23
namespace NumbersGame
{
    internal class Program
    {
        static void Game()
        {
            // creates the random number
            var rnd = new Random();
            int nr = rnd.Next(1,21);
            int input2 = 0;
            bool win = false;
            
            Console.Clear();
            Console.WriteLine("\n\tVälkommen! Jag tänker på ett nummer. " +
                "\n\tKan du gissa vilket? Du får fem försök.");

            for(int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.Write("\n\tGissa nummret: ");

                if (!int.TryParse(Console.ReadLine(), out input2))
                {
                    i--;
                    Console.WriteLine("\n\tError: Ogiltigt input, vänligen ange ett heltal");
                    Console.ReadKey();
                }
                else if (input2 == nr)
                {
                    win = true;
                    Console.WriteLine($"\n\tWoho! Du gjorde det! " +
                        $"\n\t{nr} var rätt svar, du vann!");
                    Console.ReadKey();
                    break;
                }
                else if (input2 < nr)
                {
                    Console.WriteLine("\n\tTyvärr du gissade för lågt!" +
                        $"\n\tDu har {(4-i)} försök kvar");
                    Console.ReadKey();
                }
                else if (input2 > nr)
                {
                    Console.WriteLine("\n\tTyvärr du gissade för högt!" +
                        $"\n\tDu har {(4-i)} försök kvar");
                    Console.ReadKey();
                }
            }
            if (win == false)
            {
                Console.WriteLine("\n\tTyvärr du lyckades inte gissa talet på fem försök!" +
                    "\n\tBättre lycka nästa gång!");
                Console.ReadKey();
            }
        }
        static void Main(string[] args)
        {
            bool run = true;

            // a loop to manually turn of the console
            while (run)
            {
                Console.Clear();
                Console.WriteLine("\n\tVälkommen till Gissa numret\n" +
                    "\n\t[1] Starta nytt spel" +
                    "\n\t[2] Avsluta programmet");
                Console.Write("\n\t");

                int.TryParse(Console.ReadLine(), out int input);
                switch (input)
                {
                    case 1:
                        // Starts the game
                        Game();
                        break;
                    case 2:
                        Console.WriteLine("Programmet avslutas...");
                        Console.ReadKey();
                        run = false;
                        break;
                    default:
                        Console.WriteLine("\n\tError: Ogiltigt input, vänligen ange ett heltal");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
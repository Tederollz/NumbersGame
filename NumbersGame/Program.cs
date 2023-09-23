namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool run = true;

            while (run)
            {
                Console.WriteLine("\n\tVälkommen till Gissa numret\n" +
                    "\n\t[1] Starta nytt spel" +
                    "\n\t[2] Avsluta programmet");

                int.TryParse(Console.ReadLine(), out int input);
                switch (input)
                {
                    case 1:
                        //Starta spelet
                        break;
                    case 2:
                        Console.WriteLine("Programmet avslutas...");
                        Console.ReadKey();
                        run = false;
                        break;
                }
            }
        }
    }
}
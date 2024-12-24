namespace TCSA.MathGame;
internal class Menu
{
    DateTime date = DateTime.UtcNow;
    GameEngine GameEngine = new();

    static string? name = GetName();
    static string GetName()
    {
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        return name;
    }

    internal void DisplayMenu()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine($"Previous High Score: {GameEngine.highScore}\n");
            Console.WriteLine($"Hello {name}. It's {date.DayOfWeek}. Welcome to the math game.\n");
            Console.WriteLine($@"Choose a game:
            A - Addition
            S - Subtraction
            M - Multiplication
            D - Division
            V - View Previous Scores
            Q - Quit the program");

            string gameSelected = Console.ReadLine().ToUpper().Trim();

            switch (gameSelected)
            {
                case "A":
                    Console.Clear();
                    Console.WriteLine("Addition Game");
                    GameEngine.StartGame("+");
                    break;
                case "S":
                    Console.Clear();
                    Console.WriteLine("Subtraction Game");
                    GameEngine.StartGame("-");
                    break;
                case "M":
                    Console.Clear();
                    Console.WriteLine("Multiplication Game");
                    GameEngine.StartGame("*");
                    break;
                case "D":
                    Console.Clear();
                    Console.WriteLine("Division Game");
                    GameEngine.StartGame("/");
                    break;
                case "V":
                    Console.Clear();
                    Console.WriteLine("Viewing Previous Scores");
                    Helpers.ViewScores();
                    Console.ReadLine();
                    break;
                case "Q":
                    Console.Clear();
                    Console.WriteLine("\nGoodbye!");
                    Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid selection!\n");
                    break;
            }
        }
    }
}

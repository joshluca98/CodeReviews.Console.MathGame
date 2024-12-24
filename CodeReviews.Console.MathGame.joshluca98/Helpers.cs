namespace TCSA.MathGame
{
    internal class Helpers
    {
        internal static List<string> games = new();
        internal static int highScore = 0;

        internal static void LogScore(int score, string gameType)
        {
            if (score > highScore)
            {
                highScore = score;
            }
            games.Add($"{DateTime.Now} | {gameType} Game | Score: {score}");
        }
        internal static void ViewScores()
        {
            if (games.Count == 0)
            {
                Console.WriteLine("\nNo previous scores were found.");
            }
            else
            {
                foreach (var game in games)
                {

                    Console.WriteLine(game);
                }
            }
            Console.WriteLine("\nPress ENTER to return to the menu..");
        }
    }
}

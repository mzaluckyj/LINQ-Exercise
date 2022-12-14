namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> videoGames = new List<string>()
            { "Halo", "Call of Duty", "Minecraft", "Legend of Zelda", "Super Smash Bros."};

            var gamesList = videoGames.OrderByDescending(x => x.Length).ToList();
                         

            foreach (var game in gamesList) 
            {
            Console.WriteLine(game);
            }
            Console.WriteLine();
           // IEnumerable<string> videoGames2 = new List<string>();
        }
    }
}

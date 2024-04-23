using GameLibrary;
class Program
{
    static void Main(string[] args)
    {
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine("Hi! Nice to meet you");
      Console.ResetColor();
      bool validName = false;

        while(!validName) 
        {
          Console.ForegroundColor = ConsoleColor.Yellow;
          Console.WriteLine("To start playing please enter your player name.");
          Console.ResetColor(); 
          string? playerName = Console.ReadLine();
        if (!string.IsNullOrEmpty(playerName))
        {
          playerName = playerName.Trim();
          validName = true;
          Console.ForegroundColor = ConsoleColor.Yellow;
          Console.WriteLine($"{Environment.NewLine}Hello, {playerName}.");
          Console.WriteLine("You must guess the secret number to win the game!.");
          Console.WriteLine("Enter a number between 0 to 100.");
          Console.ResetColor();
          Game game = new Game(playerName);
          game.start();
        }
        else
        {
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("Invalid player name.");
          Console.ResetColor();
        }
        }
        
    }
}
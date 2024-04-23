namespace GameLibrary;

public class Game
{
  private Random random = new Random();
  private int RandomNumber { get; set; } // Propiedad private
  private Player _humanPlayer { get; set; } // Propiedad private que almacena una instancia de _humanPlayer
  private Player _AIPlayer { get; set; } // Propiedad private que almacena una instancia de _AIPlayer

  public Game(string playerName)
  {
    _humanPlayer = new HumanPlayer(playerName);
    _AIPlayer = new AIPlayer("Computer");
    RandomNumberGenerator();
  }
  public void start() {
   int LastNumber = _humanPlayer.GetLastGuess();
    CheckGuess(LastNumber, RandomNumber);  
  }

  private void RandomNumberGenerator() {
    int randomNumber = random.Next(101);
    RandomNumber = randomNumber;
    //return;
  }
private void CheckGuess(int guess, int targetNumber)
{
  string winner = "";
  
  while (guess != targetNumber)
  {
    bool playerTurn = true;
    bool ComputerTurn = false;
    
    while (playerTurn) {
      Console.WriteLine( $"{Environment.NewLine}");
      _humanPlayer.MakeGuess(); // Pedir al jugador que haga otra conjetura
      guess = _humanPlayer.GetLastGuess(); // Actualizar la conjetura del jugador
      if (guess > targetNumber)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Too long");
            Console.ResetColor();
            ComputerTurn = true;
            playerTurn = false;
        }
      else if (guess < targetNumber)
        {
          Console.ForegroundColor = ConsoleColor.DarkYellow;
          Console.WriteLine("Too short");
          Console.ResetColor();
          ComputerTurn = true;
          playerTurn = false;
        }
      else if (guess == targetNumber)
        {
          winner = _humanPlayer.Name;
          ComputerTurn = false;
          playerTurn = false;
        }
       
    }
    while (ComputerTurn) {
      Console.WriteLine( $"{Environment.NewLine}");
      _AIPlayer.MakeGuess();
      guess = _AIPlayer.GetLastGuess();
      if (guess > targetNumber)
        {
          Console.ForegroundColor = ConsoleColor.DarkYellow;
          Console.WriteLine("Too long");
          Console.ResetColor();
          ComputerTurn = false;
          playerTurn = true;
        }
      else if (guess < targetNumber)
        {
          Console.ForegroundColor = ConsoleColor.DarkYellow;
          Console.WriteLine("Too short");
          Console.ResetColor();
          ComputerTurn = false;
          playerTurn = true;
        }
          else if (guess == targetNumber)
        {
          winner = _AIPlayer.Name;
          ComputerTurn = false;
          playerTurn = false;
        }    
    }
  
  }
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Congratulations, {winner}! You guessed the winner number!: {targetNumber}");
    Console.ResetColor();
 
}

public int GetRandomNumber()
    {
      return RandomNumber;
    }

public string GetPlayerName()
    {
      return _humanPlayer.Name;
    }


}
public class HumanPlayer : Player {

  public HumanPlayer(string name) : base(name)
  {
  }

  public override void MakeGuess()
  {  
    bool validInput = false;
    while (!validInput)
    {
      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.WriteLine($"--- Round: {Name} Player ---"); 
      Console.WriteLine($"{Name}, enter your guess:");
      Console.ResetColor();

      var input = Console.ReadLine();
      if (int.TryParse(input, out int guess))
      {
        LastAttempt = guess;
        validInput = true;
      }
      else
      {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Invalid input. Please enter a valid number.");
        Console.ResetColor();
        
      }
    }
    }
}
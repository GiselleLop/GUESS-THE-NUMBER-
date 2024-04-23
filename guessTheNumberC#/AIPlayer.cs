public class AIPlayer : Player {
  private Random random = new Random();

   public AIPlayer(string name) : base(name)
    {
    }

    public override void MakeGuess()
    {
    int randomNumber = random.Next(101);
    LastAttempt = randomNumber;
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine("--- Round: Computer Player ---"); 
    Console.WriteLine("Computer guess:");
    Console.ResetColor();
    Console.WriteLine( $"{LastAttempt}");
    }
    
}
public abstract class Player
{
  public string Name { get; private set; }
  public int LastAttempt { get; set; }
  
  public List<string> List;


  protected Player(string name)
  {
    Name = name;
    LastAttempt = 0;
    List = new List<string>();
  }

public int GetLastGuess()
{
  return LastAttempt;
} 
  public abstract void MakeGuess();
}
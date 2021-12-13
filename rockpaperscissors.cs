

using System;
using System.Collections.Generic;
namespace csharprps
{
 public class Game{
    public bool Playing { get; private set; } = true;
    public List<string> CompChoices {get; private set;} = new List<string>(){"rock", "paper", "scissors"};
    private string CompChoice {get; set;}
    
  public Game()
  {
     unknownCompChoice();
  }
  public void unknownCompChoice(){
    Console.WriteLine("\nChoose your weapon... rock paper or scissors");
    string input = Console.ReadLine();
    Random rand = new Random();
    int computerChoice = rand.Next(0, 2);
    CompChoice = CompChoices[computerChoice];
    Console.WriteLine(CompChoices[computerChoice]);
    action(input, CompChoice);
  }
  public void action(string input, string CompChoice){
    switch (input + CompChoice)
    {
      case "rockscissors":
      case "paperrock":
      case "scissorspaper":
      Console.WriteLine($" you chose {input} computer chose {CompChoice} you win!");
      break;
      case "scissorsrock":
      case "rockpaper":
      case "paperscissors":
      Console.WriteLine($" you chose {input} computer chose {CompChoice} you loser!!");
      break;
      case "rockrock":
      case "paperpaper":
      case "scissorsscissors":
      Console.WriteLine($" you chose {input} computer chose {CompChoice} its a draw...");
      break;

    }
    Replay();
  }
  
  public void Replay(){
    unknownCompChoice();
    // Console.WriteLine("play again?");
    // string input = Console.ReadLine();
    // if(input == "yes")
    // {
    //   unknownCompChoice();
    // }
  }

  }
}
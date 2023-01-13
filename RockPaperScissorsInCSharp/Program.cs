int computerWins = 0;
int playersWins = 0;
string[] moves = { "rock", "paper", "scissors" };
while (computerWins != 3 && playersWins !=3)
{
    Console.Write("Please enter the character you want from('r','s','p'): ");
    string playersInput = Console.ReadLine();
    if (playersInput != "r" && playersInput != "s" && playersInput != "p")
    {
        Console.WriteLine("wrong input! please enter the correct character! ");
        continue;
    }
    string playerMove = moves[0];
    Console.WriteLine($"Player's move is: {playerMove}");
    var random = new Random();
    int randomNumber = random.Next(0, 3);
    string computersMove = moves[randomNumber];
    Console.WriteLine($"computer's move: {computersMove}");
    if (playersInput == "r" && computersMove == "scissors" || playersInput == "r" && computersMove == "paper" || playersInput == "r" && computersMove == "rock") 
    {
        Console.WriteLine("player wins!");
        playersWins++;
    }
    else if(playersInput == computersMove )
    {
        Console.WriteLine("It's a tie!");
    }
    else
    {
        Console.WriteLine("computer wins!");
        computerWins++;
    }
    Console.WriteLine($"computer's score: {computerWins}");
    Console.WriteLine($"player's score: {playersWins}");
}
Console.WriteLine(playersWins == 3 ? "player wins!" : "Computer wins!");


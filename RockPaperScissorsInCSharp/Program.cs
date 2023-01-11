int computerWins = 0;
int playersWins = 0;
string[] moves = { "rock", "paper", "scissors" };
while (true)
{
    Console.Write("Please enter the character you want from('r','s','p'): ");
    char playersInput = Convert.ToChar(Console.ReadLine());
    if (playersInput != 'r' && playersInput != 's' && playersInput != 'p')
    {
        Console.WriteLine("wrong input! please enter the correct character! ");
        continue;
    }
    string playerMove = moves[playersInput - 'r'];
    Console.WriteLine($"Player's move is: {playerMove}");
    // generate random numbers to show computer's move
    var random = new Random();
    int randomNumber = random.Next(0, 3);
    string computersMove = moves[randomNumber];
    Console.WriteLine($"computer's move: {computersMove}");
    if (playersInput == 'r' && computersMove == "scissors" || playersInput == 's' && computersMove == "paper" || playersInput == 'p' && computersMove == "rock") 
    {
        Console.WriteLine("player wins!");
        playersWins++;
    }
    else if(playersInput == 'r' && computersMove == "rock" || playersInput == 's' && computersMove == "scissors" || playersInput == 'p' && computersMove == "paper")
    {
        Console.WriteLine("It's a tie!");
    }
    else
    {
        Console.WriteLine("computer wins!");
        computerWins++;
    }
    Console.WriteLine($"computer's score: {computerWins}");
    Console.WriteLine($"player's's score: {playersWins}");
    if (computerWins == 3)
    {
        Console.WriteLine("computer wins the game!!!");
        break;
    }
    else if(playersWins == 3)
    {
        Console.WriteLine("player wins the game!!!");
        break;
    }
}
    // check the winner
//    if (playersInput == 'r' && computersMove == "rock")
//    {
//        Console.WriteLine("It's a tie!");
//    }
//    else if (playersInput == 'r' && computersMove == "paper")
//    {
//        Console.WriteLine("Computer wins!");
//        computerWins++;
//    }
//    else if (playersInput == 'r' && computersMove == "scissors")
//    {
//        Console.WriteLine("player wins!");
//        playersWins++;
//    }
//    else if (playersInput == 's' && computersMove == "scissors")
//    {
//        Console.WriteLine("It's a tie!");
//    }
//    else if (playersInput == 's' && computersMove == "paper")
//    {
//        Console.WriteLine("player wins!");
//        playersWins++;
//    }
//    else if (playersInput == 's' && computersMove == "rock")
//    {
//        Console.WriteLine("computer wins!");
//        computerWins++;
//    }
//    else if (playersInput == 'p' && computersMove == "paper")
//    {
//        Console.WriteLine("It's a tie!");
//    }
//    else if (playersInput == 'p' && computersMove == "rock")
//    {
//        Console.WriteLine("player wins!");
//        playersWins++;
//    }
//    else if (playersInput == 'p' && computersMove == "scissors")
//    {
//        Console.WriteLine("computer wins!");
//        computerWins++;
//    }
//    Console.WriteLine($"computer's score: {computerWins}");
//    Console.WriteLine($"player's score: {playersWins}");
//    if (computerWins == 3)
//    {
//        Console.WriteLine("computer won this game.");
//    }
//    else if (playersWins == 3)
//    {
//        Console.WriteLine("player won this game.");
//    }
//    if (computerWins == 3 || playersWins == 3)
//    {
//        break;
//    }
//}

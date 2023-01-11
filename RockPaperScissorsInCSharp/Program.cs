int computerWins = 0;
int playersWins = 0;
while(true)
{
    Console.Write("Please enter the character you want from('r','s','p'): ");
    char playersInput = Convert.ToChar(Console.ReadLine());
    if (playersInput == 'r')
    {
        Console.WriteLine($"Player's input is rock");
    }
    else if (playersInput == 's')
    {
        Console.WriteLine($"Player's input is scissors");
    }
    else if (playersInput == 'p')
    {
        Console.WriteLine($"Player's input is paper");
    }
    else
    {
        Console.WriteLine("Invalid input! please enter the correct character.");
    }
    // generate random numbers to show computer's move
    var random = new Random();
    int randomNumber = random.Next(1, 3);
    string computersMove;
    if (randomNumber == 1)
    {
        computersMove = "rock";
        Console.WriteLine($"Computer's input is: {computersMove}");
    }
    else if (randomNumber == 2)
    {
        computersMove = "paper";
        Console.WriteLine($"Computer's input is: {computersMove}");
    }
    else
    {
        computersMove = "scissors";
        Console.WriteLine($"Computer's input is: {computersMove}");
    }

    // check the winner
    if (playersInput == 'r' && computersMove == "rock")
    {
        Console.WriteLine("It's a tie!");
    }
    else if (playersInput == 'r' && computersMove == "paper")
    {
        Console.WriteLine("Computer wins!");
        computerWins++;
    }
    else if (playersInput == 'r' && computersMove == "scissors")
    {
        Console.WriteLine("player wins!");
        playersWins++;
    }
    else if (playersInput == 's' && computersMove == "scissors")
    {
        Console.WriteLine("It's a tie!");
    }
    else if (playersInput == 's' && computersMove == "paper")
    {
        Console.WriteLine("player wins!");
        playersWins++;
    }
    else if (playersInput == 's' && computersMove == "rock")
    {
        Console.WriteLine("computer wins!");
        computerWins++;
    }
    else if (playersInput == 'p' && computersMove == "paper")
    {
        Console.WriteLine("It's a tie!");
    }
    else if (playersInput == 'p' && computersMove == "rock")
    {
        Console.WriteLine("player wins!");
        playersWins++;
    }
    else if (playersInput == 'p' && computersMove == "scissors")
    {
        Console.WriteLine("computer wins!");
        computerWins++;
    }
    Console.WriteLine($"computer's score: {computerWins}");
    Console.WriteLine($"player's score: {playersWins}");
    if (computerWins == 3)
    {
        Console.WriteLine("computer won this game.");
    }
    else if (playersWins == 3)
    {
        Console.WriteLine("player won this game.");
    }
    if (computerWins == 3 || playersWins == 3)
    {
        break;
    }
    
}

Console.WriteLine("                       _______________________________________________");
Console.WriteLine("                                   NUMBER GUESSING GAME               ");
Console.WriteLine("                           please select the difficulty level!");
Console.WriteLine("1. easy  -- in this level you have to guess numbers between 0 to 30, in 10 guesses");
Console.WriteLine("2. medium -- in this level you have to guess numbers between 0 to 50, in 7 guesses");
Console.WriteLine("3. hard -- in this level you have to guess numbers between 0 to 70, in 6 guesses");
Console.WriteLine("4. impossible -- in this level you have to guess numbers between 0 to 100, in 3 guesses");
Random randNum = new Random();
int randomNumber = randNum.Next();
int playerInput = Convert.ToInt32(Console.ReadLine());
int playerGuesses;
if (playerInput == 1)
{
    Console.WriteLine("You chose easy level.");
    Console.WriteLine("you have 10 guesses.");
    Console.WriteLine("GOOD LUCK!!!");
    randomNumber = randNum.Next(0, 30);
    Console.WriteLine("1. Please enter the number u want.");
    playerGuesses = Convert.ToInt32(Console.ReadLine());
    if (playerGuesses != randomNumber)
    {
        Console.WriteLine("wrong answer. try again.");
        if (playerGuesses > randomNumber)
        {
            Console.WriteLine("generated number is smaller.");
        }
        else
        {
            Console.WriteLine("generated number is higher.");
        }
        Console.WriteLine();
        for (int i = 2; i <= 10; i++)
        {
            Console.WriteLine($"{i}. try another input: ");
            playerGuesses = Convert.ToInt32(Console.ReadLine());
            if (playerGuesses == randomNumber)
            {
                Console.WriteLine("Congratulations you won!");
                break;
            }
            else
            {
                Console.WriteLine("wrong answer. try again.");
                Console.WriteLine();
            }
            if (playerGuesses > randomNumber)
            {
                Console.WriteLine("generated number is smaller.");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("generated number is higher.");
                Console.WriteLine();
            }
        }
        Console.WriteLine($"generated number was: {randomNumber}");
    }
    else
    {
        Console.WriteLine("Congratulations you won!");
    }
    Console.WriteLine("You lose this game");
}
else if (playerInput == 2)
{
    Console.WriteLine("You chose medium level.");
    Console.WriteLine("you have 7 guesses.");
    Console.WriteLine("GOOD LUCK!!!");
    randomNumber = randNum.Next(0, 50);
    Console.WriteLine("1. Please enter the number u want.");
    playerGuesses = Convert.ToInt32(Console.ReadLine());
    if (playerGuesses != randomNumber)
    {
        Console.WriteLine("wrong answer. try again.");
        if (playerGuesses > randomNumber)
        {
            Console.WriteLine("generated number is smaller.");
        }
        else
        {
            Console.WriteLine("generated number is higher.");
        }
        Console.WriteLine();
        for (int i = 2; i <= 7; i++)
        {
            Console.WriteLine($"{i}. try another input: ");
            playerGuesses = Convert.ToInt32(Console.ReadLine());
            if (playerGuesses == randomNumber)
            {
                Console.WriteLine("Congratulations you won!");
                break;
            }
            else
            {
                Console.WriteLine("wrong answer. try again.");
                Console.WriteLine();
            }
            if (playerGuesses > randomNumber)
            {
                Console.WriteLine("generated number is smaller.");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("generated number is higher.");
                Console.WriteLine();
            }
        }
        Console.WriteLine($"generated number was: {randomNumber}");
    }
    else if (playerGuesses == randomNumber)
    {
        Console.WriteLine("Congratulations you won!");
    }
    else
    {
        Console.WriteLine("You lose this game");
    }
}
else if (playerInput == 3)
{
    Console.WriteLine("You chose hard level.");
    Console.WriteLine("you have 6 guesses.");
    Console.WriteLine("GOOD LUCK!!!");
    randomNumber = randNum.Next(0, 70);
    Console.WriteLine("1. Please enter the number u want.");
    playerGuesses = Convert.ToInt32(Console.ReadLine());
    if (playerGuesses != randomNumber)
    {
        Console.WriteLine("wrong answer. try again.");
        if (playerGuesses > randomNumber)
        {
            Console.WriteLine("generated number is smaller.");
        }
        else
        {
            Console.WriteLine("generated number is higher.");
        }
        Console.WriteLine();
        for (int i = 2; i <= 6; i++)
        {
            Console.WriteLine($"{i}. try another input: ");
            playerGuesses = Convert.ToInt32(Console.ReadLine());
            if (playerGuesses == randomNumber)
            {
                Console.WriteLine("Congratulations you won!");
                break;
            }
            else
            {
                Console.WriteLine("wrong answer. try again.");
                Console.WriteLine();
            }
            if (playerGuesses > randomNumber)
            {
                Console.WriteLine("generated number is smaller.");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("generated number is higher.");
                Console.WriteLine();
            }
        }
        Console.WriteLine($"generated number was: {randomNumber}");
    }
    else if (playerGuesses == randomNumber)
    {
        Console.WriteLine("Congratulations you won!");
    }
    else
    {
        Console.WriteLine("You lose this game");
    }
}
else if (playerInput == 4)
{
    Console.WriteLine("You chose impossible level.");
    Console.WriteLine("You chose easy level.");
    Console.WriteLine("you have 3 guesses.");
    Console.WriteLine("GOOD LUCK!!!");
    randomNumber = randNum.Next(0, 100);
    Console.WriteLine("1. Please enter the number u want.");
    playerGuesses = Convert.ToInt32(Console.ReadLine());
    if (playerGuesses != randomNumber)
    {
        Console.WriteLine("wrong answer. try again.");
        if (playerGuesses > randomNumber)
        {
            Console.WriteLine("generated number is smaller.");
        }
        else
        {
            Console.WriteLine("generated number is higher.");
        }
        Console.WriteLine();
        for (int i = 2; i <= 3; i++)
        {
            Console.WriteLine($"{i}. try another input: ");
            playerGuesses = Convert.ToInt32(Console.ReadLine());
            if (playerGuesses == randomNumber)
            {
                Console.WriteLine("Congratulations you won!");
                break;
            }
            else
            {
                Console.WriteLine("wrong answer. try again.");
                Console.WriteLine();
            }
            if (playerGuesses > randomNumber)
            {
                Console.WriteLine("generated number is smaller.");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("generated number is higher.");
                Console.WriteLine();
            }
        }
        Console.WriteLine($"generated number was: {randomNumber}");
    }
    else if (playerGuesses == randomNumber)
    {
        Console.WriteLine("Congratulations you won!");
    }
    else
    {
        Console.WriteLine("You lose this game");
    }
}
else
{
    Console.WriteLine("Wrong input! Please enter the number between (1-4).");
}

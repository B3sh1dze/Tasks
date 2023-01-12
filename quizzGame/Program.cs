string[] questions = { "1. In which year designed c# language?", "2. Who is the founder of c#?", "3. What's c#'s ranking in 2023?"};
string[] answerOfFirst = { "A. 2000", "B. 2001", "C. 2003", "D. 1999" };
string correctAnswerOfFirst = answerOfFirst[0];
string[] answerOfSecond = { "A.  Anders Hejlsberg", "B.  Bjarne Stroustrup", "C.  Richard Stallman", "D.Andrew S. Tanenbaum " };
string correctAnswerOfSecond = answerOfSecond[0];
string[] answerOfThird = { "A. 6 ",  "B. 4",  "C. 5", "D. 2" };
string correctAnswerOfThird = answerOfThird[0];
int correctAnswers = 0;
Console.WriteLine(questions[0]);
foreach (string answer in answerOfFirst)
{
    Console.WriteLine(answer);
}
char playerInput = Convert.ToChar(Console.ReadLine());
if(playerInput == correctAnswerOfFirst[0])
{
    Console.WriteLine("Correct answer");
    correctAnswers++;
}
else
{
    Console.WriteLine("wrong answer");
    Console.WriteLine($"correct is: {answerOfFirst[0]}");
}
Console.WriteLine(questions[1]);
foreach (string answer in answerOfSecond)
{
    Console.WriteLine(answer);
}
char playerInput2 = Convert.ToChar(Console.ReadLine());
if (playerInput2 == correctAnswerOfSecond[0])
{
    Console.WriteLine("Correct answer");
    correctAnswers++;
}
else
{
    Console.WriteLine("wrong answer");
    Console.WriteLine($"correct is: {answerOfSecond[0]}");
}
Console.WriteLine(questions[2]);
foreach (string answer in answerOfThird)
{
    Console.WriteLine(answer);
}
char playerInput3 = Convert.ToChar(Console.ReadLine());
if (playerInput3 == correctAnswerOfThird[0])
{
    Console.WriteLine("Correct answer");
    correctAnswers++;
}
else
{
    Console.WriteLine("wrong answer");
    Console.WriteLine($"correct is: {answerOfThird[0]}");
}
Console.WriteLine($"Final score: {correctAnswers} from 3");

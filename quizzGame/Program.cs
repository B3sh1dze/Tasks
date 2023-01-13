string[] questions = { "1. In which year designed c# language?", "2. Who is the founder of c#?", "3. What's c#'s ranking in 2023?"};
string[,] answers = new string[3, 4] { {"A. 2000", "B. 2001", "C. 2003", "D. 1999"},
                                        { "A.  Anders Hejlsberg", "B.  Bjarne Stroustrup", "C.  Richard Stallman", "D.Andrew S. Tanenbaum " },
                                        { "A. 6 ",  "B. 4",  "C. 5", "D. 2" }};
char[] correctAnsswers = { 'A', 'A', 'A' };
int counter = 0;
for(int i = 0; i < questions.Length; i++)
{
    Console.WriteLine(questions[i]);
    for(int j = 0; j < 4; j++)
    {
        Console.WriteLine(answers[i, j]);
    }
    char userInput = Convert.ToChar(Console.ReadLine().ToUpper());
    if (userInput == correctAnsswers[i])
    {
        Console.WriteLine("correct answer.");
        counter++;
    }
    else
    {
        Console.WriteLine("wrong answer. ");
        Console.WriteLine($"correct answer is: {correctAnsswers[i]}");
    }
    Console.WriteLine($"score is: {counter} out of {questions.Length}");
}
Console.WriteLine($"Final score is: {counter} out of {questions.Length}");



//Console.WriteLine(questions[0]);
//foreach (string answer in answerOfFirst)
//{
//    Console.WriteLine(answer);
//}
//char playerInput = Convert.ToChar(Console.ReadLine());
//if(playerInput == correctAnswerOfFirst[0])
//{
//    Console.WriteLine("Correct answer");
//    correctAnswers++;
//}
//else
//{
//    Console.WriteLine("wrong answer");
//    Console.WriteLine($"correct is: {answerOfFirst[0]}");
//}
//Console.WriteLine(questions[1]);
//foreach (string answer in answerOfSecond)
//{
//    Console.WriteLine(answer);
//}
//char playerInput2 = Convert.ToChar(Console.ReadLine());
//if (playerInput2 == correctAnswerOfSecond[0])
//{
//    Console.WriteLine("Correct answer");
//    correctAnswers++;
//}
//else
//{
//    Console.WriteLine("wrong answer");
//    Console.WriteLine($"correct is: {answerOfSecond[0]}");
//}
//Console.WriteLine(questions[2]);
//foreach (string answer in answerOfThird)
//{
//    Console.WriteLine(answer);
//}
//char playerInput3 = Convert.ToChar(Console.ReadLine());
//if (playerInput3 == correctAnswerOfThird[0])
//{
//    Console.WriteLine("Correct answer");
//    correctAnswers++;
//}
//else
//{
//    Console.WriteLine("wrong answer");
//    Console.WriteLine($"correct is: {answerOfThird[0]}");
//}
//Console.WriteLine($"Final score: {correctAnswers} from 3");

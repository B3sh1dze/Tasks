// task 2.1
int FirstNumber = 5;
int SecondNumber = 6;
char operation = '+';
if (operation == '-')
{
    Console.WriteLine(FirstNumber - SecondNumber);
}
else if (operation == '+')
{
    Console.WriteLine(FirstNumber + SecondNumber);
}
if (operation == '/')
{
    Console.WriteLine(FirstNumber / SecondNumber);
}
else if (operation == '*')
{
    Console.WriteLine(FirstNumber * SecondNumber);
}

Console.WriteLine();
Console.WriteLine();

// task 2.2

int fingers = 5;
bool IsFromChernobyl = fingers == 5 ? true : false;
Console.WriteLine(IsFromChernobyl);

Console.WriteLine();
Console.WriteLine();

int age = 21;
bool IsAdult = age >= 18 ? true : false;
Console.WriteLine(IsAdult);

Console.WriteLine();
Console.WriteLine();

string FirstName = "Guro";
string FullName = "Guro Beshidze";
string empty = "";
string result = FirstName == FullName ? FullName : empty;
Console.WriteLine(result);

Console.WriteLine();
Console.WriteLine();

// task 2.3
string strDate = "08 / 02 / 2023";
DateTime date = DateTime.Parse(strDate);
Console.WriteLine(date.DayOfWeek);
Console.WriteLine(date.AddDays(25));
Console.WriteLine(date.AddMonths(2));
Console.WriteLine(date.AddYears(2));
Console.WriteLine(date.DayOfWeek);
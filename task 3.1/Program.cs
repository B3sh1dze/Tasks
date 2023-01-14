//swaping 2 numbers
//int num1 = 56;
//int num2 = 45;
//(num1, num2) = (num2, num1);
//Console.WriteLine(num1);
//Console.WriteLine(num2);

//// program to convert feet to meters
//double feet = 1;
//double met = feet / 3.28;
//Console.WriteLine(met);

//// ASCII value
//Console.Write("Enter the character: ");
//char c = Convert.ToChar(Console.ReadLine());
//Console.WriteLine($"The ASCII value of {c} is {Convert.ToInt32(c)}");

////area of a circle
//int radius;
//const double PI = 3.14;
//Console.Write("Enter the radius: ");
//radius = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"Area of circle is: {radius * PI}");

//// program to convert days to years, weeks and days
//int years, weeks, days;
//Console.Write("Enter days: ");
//days = Convert.ToInt32(Console.ReadLine());

//years = (days / 365);
//weeks = (days % 365) / 7;
//days = days - ((years * 365) + (weeks * 7));

//Console.WriteLine($"days: {days}");
//Console.WriteLine($"weeks: {weeks}");
//Console.WriteLine($"years: {years}");

//check number odd or even
//Console.Write("Enter the number to check: ");
//int num = Convert.ToInt32(Console.ReadLine());
//if(num % 2 == 0)
//{
//    Console.WriteLine("Entered number is even.");
//}
//else
//{
//    Console.WriteLine("Entered number is odd");
//}

////checking the largest number
//int a, b, c;
//Console.Write("Enter the first number: ");
//a = Convert.ToInt32(Console.ReadLine());
//Console.Write("Enter the second number: ");
//b = Convert.ToInt32(Console.ReadLine());
//Console.Write("Enter the third number: ");
//c = Convert.ToInt32(Console.ReadLine());

//int larger = Math.Max(Math.Max(a, b),c);
//if (larger == a)
//{
//    Console.WriteLine($"The largest number is {a}");
//}
//if (larger == b)
//{
//    Console.WriteLine($"The largest number is {b}");
//}
//else
//{
//    Console.WriteLine($"The largest number is {c}");
//}

////printing alphabet
//for (char c = 'A'; c <= 'Z'; c++)
//{
//    Console.Write(c + " ");
//}

//// w3resources string exercises task 1
//Console.Write("Please input string you want: ");
//string str = Console.ReadLine();
//Console.WriteLine($"Your entered string is: {str}");

//// task 2
//Console.Write("Please input string you want: ");
//string str = Console.ReadLine();
//Console.WriteLine($"Your entered string's length is: {str.Length}");

//// task 3
//Console.Write("Please input string you want: ");
//string str = Console.ReadLine();
//char[] characters = str.ToCharArray();
//Console.Write($"The characters of entered string are: ");
//foreach(char c in characters )
//{
//    Console.Write($"{c} ");
//}

//// task 4   printing reversed array
//Console.Write("Please input string you want: ");
//string str = Console.ReadLine();
//char[] characters = str.ToCharArray();
//Array.Reverse(characters);
//Console.Write($"The entered strings reverse characters are: ");
//for(int i = 0; i < characters.Length; i++)
//{
//    Console.Write($"{characters[i]} ");
//}

//// task 5    counting the words in string
//Console.Write("Please input string you want: ");
//string str = Console.ReadLine();
//string[] words = str.Split(' ');
//int wordCount = words.Length;
//Console.WriteLine($"The total number of words in the string is: {wordCount}");

//// task 6
//Console.Write("Please input first string: ");
//string str = Console.ReadLine();
//Console.Write("Please input second string: ");
//string str2 = Console.ReadLine();
//int a = str.Length;
//int b = str2.Length;
//if(a == b && str == str2)
//{
//    Console.WriteLine("The length of both strings are equal and \r\nalso, both strings are equal.");
//}
//else if (a == b)
//{
//    Console.WriteLine("The length of these strings is equal");
//}
//else
//{
//    Console.WriteLine("The length of these strings aren't equal.");
//}

//// string concatenation
//string firstName = "Guro";
//string lastName = " Beshidze";
//string fullName = string.Concat(firstName, lastName);
//Console.WriteLine(fullName);

//// substring function
//string name = "Guro beshidze";
//int index = name.IndexOf('b');
//string lastName = name.Substring(index, 3);
//string lastName1 = name.Substring(3, index);
//string lastName2 = name.Substring(index);
//Console.WriteLine(lastName);
//Console.WriteLine(lastName1);
//Console.WriteLine(lastName2);
////task 1
//Console.Write("Input first number: ");
//int num1 = Convert.ToInt32(Console.ReadLine());
//Console.Write("Input second number: ");
//int num2 = Convert.ToInt32(Console.ReadLine());

//if(num1 == num2)
//{
//    Console.WriteLine("they are equal!");
//}
//else
//{
//    Console.WriteLine("they aren't equal");
//}

//// Task 2
//Console.Write("Enter the number: ");
//int num = Convert.ToInt32(Console.ReadLine());

//if(num % 2 == 0)
//{
//    Console.WriteLine("This number is even. ");
//}
//else
//{
//    Console.WriteLine("This number is odd.");
//}

////task 3
//Console.Write("Enter the number: ");
//int num = Convert.ToInt32(Console.ReadLine());

//if(num > 0)
//{
//    Console.WriteLine("This number is positive.");
//}
//else if(num < 0)
//{
//    Console.WriteLine("This number is negative.");
//}
//else
//{
//    Console.WriteLine("This number equals to 0.");
//}

//// task 13
//Console.Write("Enter the number: ");
//int a = Convert.ToInt32(Console.ReadLine());

//for (int i = 0; i < 5; i++)
//{
//    for (int j = 0; j < 3; j++)
//    {
//            Console.Write(a); 
//    }
//    Console.WriteLine();
//}

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


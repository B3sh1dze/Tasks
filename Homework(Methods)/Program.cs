//// task 1
//void DefineFunc()
//{
//    Console.WriteLine("Welcome friends!");
//    Console.WriteLine("Have a nice day!");
//}
//DefineFunc();


//// task 2
//void Func(string name)
//{
//    Console.WriteLine($"Welcome {name}!");
//    Console.WriteLine("Have a nice day!");
//}
//Console.Write("Enter your name: ");
//string name = Console.ReadLine();
//Func(name);

//// task 3
//int Sum(int a, int b)
//{
//    return a + b;
//}
//Console.Write("Enter firts num: ");
//int num1 = Convert.ToInt32(Console.ReadLine());
//Console.Write("Enter second num: ");
//int num2 = Convert.ToInt32(Console.ReadLine());
//int sum = Sum(num1, num2);
//Console.WriteLine("Sum is: " + sum);

//// task 4
//int SpacesCount(string str)
//{
//    int count = 0;
//    for (int i = 0; i < str.Length; i++) 
//    {
//        if (str[i]  == ' ')
//        {
//            count++;
//        }
//    }
//    return count;
//}
//Console.WriteLine("Enter the sentence: ");
//string str = Console.ReadLine();
//int count = SpacesCount(str);
//Console.WriteLine("spaces count is: " + count);

//// task 5
//using System.Globalization;

//int SumOfArray(int[] nums)
//{
//    int sum = 0;
//    for(int i = 0; i < nums.Length; i++)
//    {
//        sum += nums[i];
//    }
//    return sum;
//}

//var nums = new int[5];
//Console.WriteLine("Enter 5 numbers: ");
//for (int i = 0;i < nums.Length; i++)
//{
//    int num = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine($"element - {i} = {num}");
//    nums[i] = num;
//}
//int sum = SumOfArray(nums);
//Console.WriteLine("Sum is: " + sum);

//// task 6
//void SwapNums(int num1, int num2)
//{
//    int num3 = 0;
//    num3 = num1;
//    num1 = num2;
//    num2= num3;
//    Console.WriteLine($"After swappig: num1 = {num1}, num2 = {num2}");


//}
//Console.Write("Enter numbers: ");
//int num1 = Convert.ToInt32(Console.ReadLine());
//Console.Write("Enter second number: ");
//int num2 = Convert.ToInt32(Console.ReadLine());
//SwapNums(num1, num2);


//// task 7
//void PowFunc(int num1, int num2)
//{
//    int pow = 1;
//    for(int i = 0; i < num2; i++)
//    {
//        pow *= num1;
//    }
//    Console.WriteLine("power function is: " + pow);
//}
//Console.Write("Enter the first num: ");
//int num1 = Convert.ToInt32(Console.ReadLine());
//Console.Write("Enter the second num: ");
//int num2 = Convert.ToInt32(Console.ReadLine());
//PowFunc(num1, num2);

//// task 8
//void FibonacciNums(int nums)
//{
//    int num1 = 0;
//    int num2 = 1;
//    int num3;
//    Console.WriteLine(1);
//    for(int i = 0; i < nums - 1; i++)
//    {
//        num3 = num1;
//        num1 = num2;
//        num2 = num3 + num1;
//        Console.WriteLine(num2);
//    }
//}
//Console.Write("Enter the amount of Fib nums: ");
//int num = Convert.ToInt32(Console.ReadLine());
//FibonacciNums(num);

//// task 9
//void IsPrime(int num)
//{
//    int divisorCount = 0;
//    Console.Write("Divisors: ");
//    for(int i = 1; i <= num; i++)
//    {
//        if(num % i == 0)
//        {
//            divisorCount++;
//            Console.Write(i + ", ");
//        }
//    }
//    Console.WriteLine();
//    if (divisorCount <= 2)
//    {
//        if(num == 1 || num == 0)
//        {
//            Console.WriteLine("this number is neither prime nor nonprime.");
//        }
//        Console.WriteLine("This number is prime.");
//    }
//    else
//    {
//        Console.WriteLine("This number isn't prime.");
//    }
//}
//Console.Write("Enter the number to check: ");
//int num = Convert.ToInt32(Console.ReadLine());
//IsPrime(num);

//// task 10
//void DigitsCount(int num)
//{
//    int digitsSum = 0;
//    while(num > 0)
//    {
//        digitsSum += num % 10;
//        num /= 10;
//    }
//    Console.WriteLine(digitsSum);
//}
//Console.Write("Enter the number: ");
//int num = Convert.ToInt32(Console.ReadLine());
//DigitsCount(num);

// task 11
void Factorial(int num)
{
    int factorial = 1;
    for(int i = 1; i <= num; i++)
    {
        factorial *= i;
    }
    Console.WriteLine(factorial);
}
Console.Write("Enter the number: ");
int num = Convert.ToInt32(Console.ReadLine());
Factorial(num);



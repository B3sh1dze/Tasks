////for looops
//// task 1
//for(int i = 0; i <= 10; i++)
//{
//    Console.Write($"{i} ");
//}

//// task 2
//var sum = 0;
//for(int i = 0; i <= 10; i++)
//{
//    sum += i;
//}
//Console.WriteLine(sum); 

//// task 3
//Console.Write("Enter the number: ");
//int userInput = Convert.ToInt32(Console.ReadLine());
//var sum = 0;
//for (int i = 0; i <= userInput; i++)
//{
//    Console.Write($"{i} ");
//    sum += i;
//}
//Console.WriteLine();
//Console.WriteLine($"Sum: {sum}");


//// task 4
//Console.Write("Enter amount of numbers you want to input: ");
//int num = Convert.ToInt32(Console.ReadLine());
//int num1;
//var sum = 0;

//for(int i = 0; i <= num; i++)
//{
//   num1 = Convert.ToInt32(Console.ReadLine());
//    sum += i;
//}
//var avg = sum / num;
//Console.WriteLine($"Sum is: {sum}");
//Console.WriteLine($"average is: {avg}"); 


//// task 5
//Console.Write("Enter the number: ");
//int num = Convert.ToInt32(Console.ReadLine());
//var cube = 1;
//for(int i = 0; i < 3; i++)
//{
//    cube *= num;
//}

//Console.WriteLine($"Number is: {num} and cube of the 1 is: {cube}");


//// task 6 
//Console.Write("Enter the number: ");
//int num = Convert.ToInt32(Console.ReadLine());

//for ( int i = 1; i <= 10; i++ )
//{
//    Console.WriteLine($"{num} * {i} = {num * i}");
//}


//// task 7
//Console.Write("Enter the number: ");
//int num = Convert.ToInt32(Console.ReadLine());
//Console.Write("Enter the range: ");
//int num1 = Convert.ToInt32(Console.ReadLine());
//for (int i = 1; i <= 10; i++) 
//{
//    for (int j = 1; j <= num1; j++)
//    {
//        Console.Write($"{j} * {num} = {j * num}  ");
//    }
//    num++;
//    Console.WriteLine();
//}


//// task 8
//Console.Write("Enter number: ");
//int num = Convert.ToInt32(Console.ReadLine());
//var sum = 0;
//var countNum = 0;
//for (int i = 1; ; i++)
//{
//    if( i % 2 != 0)
//    {
//        Console.Write($"{i}, ");
//        countNum++;
//        sum += i;
//    }
//    if(countNum == num)
//    {
//        break;
//    }

//}


//// task 9
//Console.Write("Enter size: ");
//int a = Convert.ToInt32(Console.ReadLine());


//for (int i = 0; i <= a; i++)
//{
//    for(int j = 0; j <= i; j++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//}


//// task 10
//Console.Write("enter size: ");
//int num = Convert.ToInt32(Console.ReadLine());


//for (int i = 1; i <= num; i++)
//{
//    for (int j = 1; j <= i; j++)
//    {
//        Console.Write(j + " ");
//    }
//    Console.WriteLine();
//}


// task 11
Console.Write("enter size: ");
int num1 = Convert.ToInt32(Console.ReadLine());


for (int i = 1; i <= num1; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
}


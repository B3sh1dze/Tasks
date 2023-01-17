Console.Write("Enter the number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("divisors: ");
int sum = 0;
for(int i = 1; i <= num; i++)
{
    if(num % i == 0)
    {
        Console.Write($"{i}, ");
        sum += i;
    }
    
}
Console.WriteLine();
Console.WriteLine(sum);
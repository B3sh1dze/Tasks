Console.Write("Enter the number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("divisors: ");
for(int i = 1; i < num; i++)
{
    if(num % i == 0)
    {
        Console.WriteLine($"{i} ");
    }
}
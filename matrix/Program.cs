int[,] matrix = new int[4, 4] { { 1, 2, 3, 4 },
                                 { 5, 6, 4, 8 },
                                 { 7, 3, 8, 7 },
                                 { 4, 8, 9, 3 } };
for (int i = 0; i < matrix.GetLength(0); i++) 
{
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine("Transpose matrix: ");
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[j, i]} ");
    }
    Console.WriteLine();
}
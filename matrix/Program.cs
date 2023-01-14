//int[,] matrix = new int[4, 4] { { 1, 2, 3, 4 },
//                                 { 5, 6, 4, 8 },
//                                 { 7, 3, 8, 7 },
//                                 { 4, 8, 9, 3 } };
//for (int i = 0; i < matrix.GetLength(0); i++) 
//{
//    for(int j = 0; j < matrix.GetLength(1); j++)
//    {
//        Console.Write($"{matrix[i, j]} ");
//    }
//    Console.WriteLine();
//}
//Console.WriteLine("Transpose matrix: ");
//for (int i = 0; i < matrix.GetLength(0); i++)
//{
//    for (int j = 0; j < matrix.GetLength(1); j++)
//    {
//        Console.Write($"{matrix[j, i]} ");
//    }
//    Console.WriteLine();
//}
int[,] array = new int[4, 4] { { 11, 45, 36, 38 },
                                 { 54, 54, 46, 84 },
                                 { 77, 33, 84, 72 },
                                 { 46, 85, 93, 39 } };
array[3, 3] = 124;
int[,] array2 = new int[array.Length + 1, array.Length +1];
int[,] array3 = new int[array.GetLength(0) + 1, array.GetLength(0) + 1];
for (int i = 0; i < array.GetLength(0); i++)
{
    for(int j = 0; j < array.GetLength(0); j++)
    {
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine("new array size using length func: ");
for (int i = 0; i < array2.GetLength(0); i++)
{
    for (int j = 0; j < array2.GetLength(0); j++)
    {
        Console.Write($"{array2[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine("new array size using getlength() func: ");
for (int i = 0; i < array3.GetLength(0); i++)
{
    for (int j = 0; j < array3.GetLength(0); j++)
    {
        Console.Write($"{array3[i, j]} ");
    }
    Console.WriteLine();
}

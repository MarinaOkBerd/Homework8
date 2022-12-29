// 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц


int [,] array1 = {
    {2, 4},
    {3, 2}
    };

int [,] array2 = {
    {3, 4},
    {3, 3}
    };
 
int[,] result = new int[array1.GetLength(0), array2.GetLength(1)];
 
for (int i = 0; i < array1.GetLength(0); i++)
{
    for (int j = 0; j < array2.GetLength(1); j++)
    {
        
        result[i, j] = 0;
        for (int k = 0; k < array1.GetLength(1); k++)
        {
            result[i, j] += array1[i, k] * array2[k, j];
           
        }
            
    }
}
Console.Write(result[0,0] + " ");
Console.WriteLine(result[0,1]);
Console.Write(result[1,0] + " ");
Console.WriteLine(result[1,1]);
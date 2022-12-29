// 54: упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] numbers = {
    {1, 2, 3 ,4},
    {5, 9, 2, 3},
    {8, 4, 2, 4}
    };

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        for (int k = 0; k < numbers.GetLength(1) - 1; k++)
        {
            if (numbers[i, k] < numbers[i, k + 1])
                    {
                        int sort = numbers[i, k + 1];
                        numbers[i, k + 1] = numbers[i, k];
                        numbers[i, k] = sort;
                        
                    }
            
        }
    Console.Write(numbers[i, j] + " ");
          
    }

Console.WriteLine();          
}


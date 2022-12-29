//  56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
int[,] numbers = {
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4},
    {5, 2, 6, 7}
    };
int result = 0;
int min = 0;
int sum = 0;
for (int i = 0; i < numbers.GetLength(1); i++)
    {
        min += numbers[0,i];   
    }
for (int i = 0; i < numbers.GetLength(0); i++)
    {
        
        for (int j = 0; j < numbers.GetLength(1); j++)
            
            sum += numbers[i, j];
                
        if (sum < min)
        {
            min = sum;
            result = i;                   
        }        
        sum = 0;
    }
Console.WriteLine($"{result + 1} строка с наименьшей суммой элементов.");

           
      
    
      
    
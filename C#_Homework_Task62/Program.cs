// 62. Напишите программу, которая заполнит спирально массив 4 на 4.

int [,] result = new int[4, 4];

int x = 0;
int y = 0;
int num = 1;

while (num <= 4 * 4)
{
    result[x, y] = num;
    if(x <= y + 1 && x + y < 3)
    {
        y ++;
    }
    else if(x < y && x + y >= 3)
    {
        x ++;
    }
    else if(x >= y && x + y > 3)
    {
        y --;
    } 
    else
    {
        x --;
    }
    num  ++;  
}

for (int i = 0; i < result.GetLength(0); i++)
{
    for (int j = 0; j < result.GetLength(1); j++)
    {
        Console.Write(result[i,j] + " ");
    }
    Console.WriteLine(" ");
}

int InputNum(string message)
{
Console.WriteLine(message);
return int.Parse(Console.ReadLine()!);
}

int[,] Create2DArray(int rows, int columns)
{
return new int[rows, columns];
}

void Fill2DArray(int[,] array, int min, int max)
{
Random rnd = new Random();
for (int i = 0; i < array.GetLength(0); i++)
for (int j = 0; j < array.GetLength(1); j++)
array[i, j] = rnd.Next(min, max + 1);
}
void SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

void Print2DArray(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
Console.Write($"{array[i, j]}\t");
Console.WriteLine();
}
}

int rows = InputNum("Введите количество строк: ");
int cols = InputNum("Введите количество столбцов: ");
int minValue = InputNum("Введите минимальное значение элемента: ");
int maxValue = InputNum("Введите максимальное значение элемента: ");

int[,] myArray = Create2DArray(rows, cols);
Fill2DArray(myArray, minValue, maxValue);
Print2DArray(myArray);
Console.WriteLine();
SortArray(myArray);
Print2DArray(myArray);

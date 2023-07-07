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

void MultiplyArray(int[,] firstArray, int[,] secondArray, int[,] resultArray)
{
  for (int i = 0; i < resultArray.GetLength(0); i++)
  {
    for (int j = 0; j < resultArray.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstArray.GetLength(1); k++)
      {
        sum += firstArray[i,k] * secondArray[k,j];
      }
      resultArray[i,j] = sum;
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

int rows = InputNum("Введите количество строк первой матрицы: ");
int colsRows = InputNum("Введите количество столбцов первой матрицы/ количество строк второй матрицы: ");
int cols = InputNum("Введите количество столбцов второй матрицы: ");
int minValue = InputNum("Введите минимальное значение элемента: ");
int maxValue = InputNum("Введите максимальное значение элемента: ");

int[,] firstArray = Create2DArray(rows, colsRows);
Fill2DArray(firstArray, minValue, maxValue);
Print2DArray(firstArray);
Console.WriteLine();
int[,] secondArray = Create2DArray(colsRows, cols);
Fill2DArray(secondArray, minValue, maxValue);
Print2DArray(secondArray);
Console.WriteLine();
int[,] resultArray = Create2DArray(rows, cols);

MultiplyArray(firstArray, secondArray, resultArray);
Console.WriteLine($"Произведение первой и второй матриц:");
Print2DArray(resultArray);
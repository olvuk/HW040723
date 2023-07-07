int InputNum(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

int[,,] Create3DArray(int x, int y, int z)
{
    return new int[x, y, z];
}

void Fill3DArray(int[,,] array, int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
                {
                array[i, j, k] = rnd.Next(min, max + 1);
                }
}

void Print3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}




Console.WriteLine($"Введите размер массива X x Y x Z: ");
int x = InputNum("Введите X: ");
int y = InputNum("Введите Y: ");
int z = InputNum("Введите Z: ");

int minValue = InputNum("Введите минимальное значение элемента: ");
int maxValue = InputNum("Введите максимальное значение элемента: ");
Console.WriteLine();

int[,,] array3D = new int[x, y, z];
Create3DArray(x, y, z);
Fill3DArray(array3D, minValue, maxValue);
Print3DArray(array3D);
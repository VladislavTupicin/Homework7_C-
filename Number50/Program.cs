Console.Clear();

Console.Write("Введите номер строки: ");
int n = int.Parse(Console.ReadLine());

Console.Write("Введите номер столбца: ");
int m = int.Parse(Console.ReadLine());

int[,] numbers = new int[3, 4];

FillArrayRandomNumbers(numbers);

PrintArray(numbers);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-100, 100) / 10;
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "  ");
        }
        Console.WriteLine("");
    }
}

if (n > numbers.GetLength(0) || m > numbers.GetLength(1)){
Console.WriteLine("Такого числа в массиве нет!");
}
else
Console.WriteLine($"Значение элемента ({n} строки) и ({m} столбца) = {numbers[n - 1, m - 1]}");
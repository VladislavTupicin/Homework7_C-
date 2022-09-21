Console.Clear();

Console.Write("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[n, m];

FillArrayRandomNumbers(numbers);


PrintArray(numbers);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
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

for (int j = 0; j < numbers.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        avarage = (avarage + numbers[i, j]);
    }
    avarage = avarage / n;
    Console.WriteLine($"Среднее арифметическое значение {j + 1} столбца:");
    Console.WriteLine(avarage);
}

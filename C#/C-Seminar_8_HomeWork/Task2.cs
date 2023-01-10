Console.Clear();
Console.WriteLine("Задайте размеры массива");
Console.Write("m = ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("n = ");
int n = int.Parse(Console.ReadLine()!);

int[,] array = CreateRandom2DArray(m, n);
Print2DArray(array);
Console.WriteLine($"Номер строки с минимальной суммой: {FindMinSumRowIndex(array)}");
int[,] CreateRandom2DArray(int m, int n)
{
	Random rnd = new Random();
	int[,] array = new int[m, n];
	for (int i = 0; i < m; i++)
	{
		for (int j = 0; j < n; j++)
			array[i, j] = rnd.Next();
	}
	return array;
}

int[] Get2DArraySizes(int[,] array)
{
	return new int[2] { array.GetLength(0), array.GetLength(1) };
}

void Print2DArray(int[,] array)
{
	int[] sizes = Get2DArraySizes(array);
	for (int i = 0; i < sizes[0]; i++)
	{
		for (int j = 0; j < sizes[1]; j++)
		{
			Console.Write($"{array[i, j]} ");
		}
		Console.WriteLine("");
	}
}

int FindMinSumRowIndex(int[,] array)
{
	int[] sizes = Get2DArraySizes(array);
	int minSum = 0;
	int minSumRowIndex = -1;
	for (int i = 0; i < sizes[0]; i++)
	{
		int sum = 0;
		for (int j = 0; j < sizes[1]; j++)
		{
			sum += array[i, j];
		}
		if (minSumRowIndex < 0 || sum < minSum)
		{
			minSumRowIndex = i;
			minSum = sum;
		}
	}
	return minSumRowIndex + 1;
}
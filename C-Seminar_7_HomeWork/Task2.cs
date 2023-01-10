Console.WriteLine("Введите позицию искомого элемнта");
Console.Write("Строка: ");
int rowIndex = int.Parse(Console.ReadLine()!);

Console.Write("Столбец: ");
int columnIndex = int.Parse(Console.ReadLine()!);

int[,] array = CreateRandom2DArray(7, 6);
int[] arraySizes = Get2DArraySizes(array);

if (rowIndex > arraySizes[0] || columnIndex > arraySizes[1])
{
	Console.WriteLine("Такого элемента нет");
}
else
{
	Console.WriteLine($"Значение искомого элемнта: {array[rowIndex - 1, columnIndex - 1]}");
}

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
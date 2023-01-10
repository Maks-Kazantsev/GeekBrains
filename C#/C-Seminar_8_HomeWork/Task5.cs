Console.Clear();
Console.WriteLine("Задайте размер массива:");
Console.Write("m = ");
int m = int.Parse(Console.ReadLine()!);

int[,] array = new int[m, m];
FillArraiSpiral(array, new int[] { 0, 0 }, m, 1);
Print2DArray(array);

int[] Get2DArraySizes(int[,] array)
{
	return new int[2] { array.GetLength(0), array.GetLength(1)
};
}

void Print2DArray(int[,] array)
{
	int[] sizes = Get2DArraySizes(array);
	for (int i = 0; i < sizes[0]; i++)
	{
		for (int j = 0; j < sizes[1]; j++)
		{
			Console.Write(array[i, j].ToString("D3"));
			Console.Write(" ");
		}
		Console.WriteLine("");
	}
}

void FillArraiSpiral(int[,] array, int[] startCell, int size, int
startNumber)
{
	int xStart = startCell[0];
	int yStart = startCell[1];
	int currentNumber = startNumber;
	if (size > 0)
	{
		array[xStart, yStart] = currentNumber;
		if (size > 1)
		{
			int i = xStart;
			int j = yStart;
			while (j < xStart + size - 1)
			{
				array[i, ++j] = ++currentNumber;
			}


			while (i < yStart + size - 1)
			{
				array[++i, j] = ++currentNumber;
			}

			while (j > xStart)
			{
				array[i, --j] = ++currentNumber;
			}

			while (i > yStart + 1)
			{
				array[--i, j] = ++currentNumber;
			}

			startCell[0]++;
			startCell[1]++;
			currentNumber++;
			FillArraiSpiral(array, startCell, size - 2,
currentNumber);
		}
	}
}
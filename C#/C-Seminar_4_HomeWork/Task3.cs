Console.WriteLine("Введите 8 чисел:");
int[] array = ReadArray();

PrintArray(array);

int[] ReadArray()
{
	int[] array = new int[8];
	for (int i = 0; i < 8; i++)
	{
		array[i] = int.Parse(Console.ReadLine()!);
	}
	return array;
}

void PrintArray(int[] array)
{
	Console.Write("[");
	for (int i = 0; i < array.Length; i++)
	{
		Console.Write(array[i]);
		if (i < array.Length - 1)
		{
			Console.Write(", ");
		}
	}
	Console.Write("]");
}
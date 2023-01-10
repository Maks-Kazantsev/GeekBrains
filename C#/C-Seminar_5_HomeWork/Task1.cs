Console.Clear();

int[] array = CreateRandomArray();
int count = EvenNumberCount(array);
Console.WriteLine($"Количество чётных чисел в массиве: {count}");

int[] CreateRandomArray()
{
	Random rnd = new Random();
	int size = rnd.Next(1);
	int[] array = new int[size];
	for (int i = 0; i < size; i++)
	{
		array[i] = rnd.Next(100, 1000);
	}
	return array;
}

int EvenNumberCount(int[] array)
{
	int count = 0;
	foreach (int number in array)
	{
		if (number % 2 == 0)
		{
			count++;
		}
	}
	return count;
}
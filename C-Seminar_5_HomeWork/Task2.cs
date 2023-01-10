Console.Clear();
int[] array = CreateRandomArray();
long sum = OddElementsSum(array);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {sum}");

int[] CreateRandomArray()
{
	Random rnd = new Random();
	int size = rnd.Next(1);
	int[] array = new int[size];
	for (int i = 0; i < size; i++)
	{
		array[i] = rnd.Next();
	}
	return array;
}

long OddElementsSum(int[] array)
{
	long sum = 0;
	for (int i = 0; i < array.Length; i++)
	{
		if ((i + 1) % 2 == 1)
		{
			sum += array[i];
		}
	}
	return sum;
}
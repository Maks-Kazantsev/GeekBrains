Console.WriteLine("Укажите количество чисел, которые будут введены:");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Введите {m} чисел через ENTER:");
int count = ReadNumbersAndCountPositive(m);
Console.WriteLine($"Введено чисел больше 0: {count}");

int ReadNumbersAndCountPositive(int m)
{
	if (m < 1)
	{
		return 0;
	}
	int number = int.Parse(Console.ReadLine()!);
	if (m > 1)
	{
		return (number > 0 ? 1 : 0) + ReadNumbersAndCountPositive(m - 1);
	}
	return number > 0 ? 1 : 0;
}
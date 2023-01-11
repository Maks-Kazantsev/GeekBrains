Console.WriteLine("Введите число a:");
int a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите степень b:");
int b = int.Parse(Console.ReadLine()!);

Console.WriteLine($"a в степени b равно: {Power(a, b)}");

int Power(int a, int b)
{
	int result = 1;
	for (int i = 1; i <= b; i++)
	{
		result *= a;
	}
	return result;
}
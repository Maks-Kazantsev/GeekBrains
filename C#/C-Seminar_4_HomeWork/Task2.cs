Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Сумма цифр числа: {CalcDigitsSum(number)}");

int CalcDigitsSum(int number)
{
	int sum = 0;
	while (number >= 1)
	{
		sum += number % 10;
		number /= 10;
	}
	return sum;
}
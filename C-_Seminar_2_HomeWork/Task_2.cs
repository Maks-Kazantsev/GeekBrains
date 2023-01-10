Console.Clear();
Console.WriteLine("Введите число");
string input = Console.ReadLine();
long number = long.Parse(input);
if (number < 100)
{
	Console.WriteLine("Третьей цифры нет");
}
else
{
	while (number > 999)
	{
		number /= 10;
	}
	long thirdDigit = number % 10;
	Console.WriteLine($"Третья цифра числа: {thirdDigit}");
}
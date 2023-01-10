Console.Clear();

Console.Write("Введите число: ");
string input = Console.ReadLine();
int number = int.Parse(input);

if (number % 2 == 0)
{
	Console.WriteLine("Чётное");
}
else
{
	Console.WriteLine("Нечётное");
}

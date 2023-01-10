Console.Clear();

Console.Write("Введите число: ");
string input = Console.ReadLine();
int number = int.Parse(input);
for (int i = 2; i <= number; i += 2)
{
	Console.Write(i);
}

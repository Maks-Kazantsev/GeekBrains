//На вход принимает2 числа и проверяет является ли первое число квадратом второго

Console.Clear();

Console.WriteLine("Введите число 1 ");
string input1 = Console.ReadLine();
int number1 = int.Parse(input1);

Console.WriteLine("Введите число 2 ");
string input2 = Console.ReadLine();
int number2 = int.Parse(input2);


if (number2 * number2 == number1)
{
	Console.WriteLine("ДА");
}
else
{
	Console.WriteLine("Нет");
}







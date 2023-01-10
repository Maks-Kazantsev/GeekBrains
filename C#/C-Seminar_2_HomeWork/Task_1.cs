Console.Clear();
Console.WriteLine("Введите трехзначное число");
string input = Console.ReadLine();
int number = int.Parse(input);
int secondDigit = number % 100 / 10;
Console.WriteLine($"Вторая цифра числа: {secondDigit}");
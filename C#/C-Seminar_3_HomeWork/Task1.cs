Console.Clear();
Console.WriteLine("Введите число:");
string input = Console.ReadLine();
int number = int.Parse(input);
int firstDigit = number / 10000 % 10;
int secondDigit = number / 1000 % 10;
int fourthDigit = number / 10 % 10;
int fifthDigit = number % 10;
if(firstDigit == fifthDigit && secondDigit == fourthDigit) {
    Console.WriteLine("Да");
} else {
    Console.WriteLine("Нет");
}

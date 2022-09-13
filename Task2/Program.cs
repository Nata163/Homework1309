// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int SumDigit(int num)
{
    int sum = 0;

    while (num > 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}

Console.WriteLine("Введите число: ");

try
{
    int number = int.Parse(Console.ReadLine());
    int numberModule = Math.Abs(number);

    int result = SumDigit(numberModule);
    Console.WriteLine($"Сумма цифр в числе {number} равна {result}");
}

catch
{
    Console.WriteLine("Введен неверный формат, попробуйте еще раз.");
}



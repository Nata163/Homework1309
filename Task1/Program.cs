// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int GetPower(int number1, int number2 )
{
    int power = 1;
    for(int i =1; i<=number2; i++)
    {
        power = power*number1;
    }
    return power;
}

Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

int result= GetPower(a,b);
Console.WriteLine($"Число {a} в степени {b} равно {result}");

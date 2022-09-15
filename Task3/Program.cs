// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Элементы массива вводятся пользователем.

int[] FillArray()
{
    int[] myArray = new int[8];
    for (int i = 0; i < 8; i++)
    {
        Console.Write($"Введите элемент массива под индексом {i}: ");
        myArray[i] = int.Parse(Console.ReadLine());
    }
    return myArray;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i]);
    }
}

int[] array = FillArray();
Console.WriteLine("Вывод массива: ");
PrintArray(array);

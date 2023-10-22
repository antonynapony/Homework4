Console.Write("Введите размер массива: ");

while (true)
{
    bool isParseSuccess = int.TryParse(Console.ReadLine(), out int arrayLength);
    if (isParseSuccess && arrayLength >= 2)
    {
        int[] numbers = new int[arrayLength];
        for (int i = 0; i < arrayLength; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int min = numbers[0];
        int max = numbers[0];
        int difference = 0;
        for (int i = 1; i < arrayLength; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
            difference = max - min;
        }

        Console.WriteLine($"Минимальный элемент массива равен: {min}");
        Console.WriteLine($"Максимальный элемент массива равен: {max}");
        Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна: {difference}");
    }
    else
    {
        Console.WriteLine("Неверно введено число! Размер массива должен быть целочисленным значением >= 2!");
    }
}

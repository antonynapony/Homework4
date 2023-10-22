Console.Write("Введите размер массива: ");

while (true)
{
    bool isParseSuccess = int.TryParse(Console.ReadLine(), out int arrayLength);
    if (isParseSuccess && arrayLength > 2)
    {
        int[] numbers = new int[arrayLength];
        int sum = 0;
        for (int i = 0; i < arrayLength; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < arrayLength; i++)
        {
            sum += numbers[i];
        }

        Console.Write($"Сумма элементов массива равна: {sum}");
    }
    else
    {
        Console.WriteLine("Неверно введено число! Размер массива должен быть целочисленным значением > 2!");
    }
}

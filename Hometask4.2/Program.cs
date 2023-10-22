Console.Write("Введите размер массива: ");

while (true)
{
    bool isParseSuccess = int.TryParse(Console.ReadLine(), out int arrayLength);
    if (isParseSuccess && arrayLength >= 2)
    {
        int[] numbers = new int[arrayLength];
        int min = numbers[0];
        int max = numbers[0];
        int diff = 0;
        for (int i = 0; i < arrayLength; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
            else if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }

        diff = max - min;
        Console.Write($"Разница между максимальным и минимальным значениями элементов массива равно: {diff}");
    }
    else
    {
        Console.WriteLine("Неверно введено число! Размер массива должен быть целочисленным значением >= 2!");
    }
}

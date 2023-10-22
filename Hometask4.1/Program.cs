Console.Write("Введите размер массива: ");

while (true)
{
    bool isParseSuccess = int.TryParse(Console.ReadLine(), out int arrayLength);
    if (isParseSuccess)
    {
        int[] numbers = new int[arrayLength];
        int sum = 0;
        for (int i = 0; i < arrayLength; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
            sum += numbers[i];
        }

        Console.Write($"Сумма элементов массива равна: {sum}");
    }
    else
    {
        Console.WriteLine("Неверно введено число!");
    }
}

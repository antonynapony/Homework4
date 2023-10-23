Console.Write("Введите размер массива: ");

while (true)
{
    bool isParseSuccess = int.TryParse(Console.ReadLine(), out int arrayLength);
    if (isParseSuccess && arrayLength >= 2)
    {
        int[] numbers = new int[arrayLength];
        int newValue = numbers[0];
        int duplicatesNumber = 0;
        for (int i = 0; i < arrayLength; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < arrayLength; i++)
        {
            if (numbers[i] > newValue)
            {
                newValue = numbers[i];
            }
        }

        for (int i = 0; i < arrayLength; i++)
        {
            for (int j = i + 1; j < arrayLength; j++)
            {
                if (numbers[i] == numbers[j])
                {
                    Console.WriteLine($"Для элемента № {i}: {numbers[i]} найден повторный элемент № {j}: {numbers[j]}");
                    duplicatesNumber++;
                    newValue++;
                    numbers[j] = newValue;
                }
            }

        }

        if (duplicatesNumber > 0)
        {
            Console.WriteLine($"Количество повторных элементов в массиве = {duplicatesNumber}");
        }
        else
        {
            Console.WriteLine("В массиве нет повторных элементов!");
        }
        break;
    }
    else
    {
        Console.WriteLine("Неверно введено число! Размер массива должен быть целочисленным значением >= 2!");
    }
}
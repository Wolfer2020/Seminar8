//Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
// находить строку с наименьшей суммой элементов
// Заданный массив
        int[,] array = new int[,]
        {
            { 5, 2, 7 },
            { 3, 8, 4 },
            { 9, 6, 1 }
        };

        int minSumRow = 0; // Индекс строки с наименьшей суммой элементов
        int minSum = int.MaxValue; // Начальное значение для суммы элементов

        // Поиск строки с наименьшей суммой элементов
        for (int i = 0; i < array.GetLength(0); i++)
        {
            int sum = 0; // Сумма элементов текущей строки

            for (int j = 0; j < array.GetLength(1); j++)
            {
                sum += array[i, j];
            }

            if (sum < minSum)
            {
                minSum = sum;
                minSumRow = i;
            }
        }

        // Вывод строки с наименьшей суммой элементов
        Console.WriteLine("Строка с наименьшей суммой элементов: ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[minSumRow, j] + " ");
        }

        Console.WriteLine();
    
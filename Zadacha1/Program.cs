//Задайте двумерный массив. Напишите программу, которая 
//упорядочивает по убыванию элементы каждой строки двумерного массива.


        // Заданный массив
        int[,] array = new int[,]
        {
            { 5, 2, 7, 1, 9 },
            { 3, 8, 4, 6, 2 },
            { 9, 6, 1, 3, 5 }
        };

        // Упорядочивание по убыванию для каждой строки
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1) - 1; j++)
            {
                for (int k = j + 1; k < array.GetLength(1); k++)
                {
                    if (array[i, j] < array[i, k])
                    {
                        int temp = array[i, j];
                        array[i, j] = array[i, k];
                        array[i, k] = temp;
                    }
                }
            }
        }

        // Вывод упорядоченного массива
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    
    
//Задайте две матрицы. Напишите программу, которая будет находить 
//произведение двух матриц.

 // Заданные матрицы
        int[,] matrix1 = new int[,]
        {
            { 1, 2, 3 },
            { 4, 5, 6 }
        };

        int[,] matrix2 = new int[,]
        {
            { 7, 8 },
            { 9, 10 },
            { 11, 12 }
        };

        // Размеры матриц
        int n = matrix1.GetLength(0);
        int m = matrix1.GetLength(1);
        int p = matrix2.GetLength(1);

        // Проверка возможности умножения матриц
        if (m != matrix2.GetLength(0))
        {
            Console.WriteLine("Умножение матриц невозможно");
            return;
        }

        // Вычисление произведения матриц
        int[,] result = new int[n, p];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < p; j++)
            {
                for (int k = 0; k < m; k++)
                {
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }

        // Вывод произведения матриц
        Console.WriteLine("Произведение матриц:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < p; j++)
            {
                Console.Write(result[i, j] + " ");
            }
            Console.WriteLine();
        }
    

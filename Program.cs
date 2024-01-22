// Задача 1

using System;

class Program
{
    static void Main()
    {
        int[,] numbers = new int[,] {
            {1, 2, 3, 4},
            {5, 6, 7, 8},
            {9, 10, 11, 12}
        };

        int x = 2;
        int y = 2;

         //Передаем позиции элемента для поиска
        int result = GetElementValue(numbers, x, y);

        if (result != int.MinValue)
        {
            Console.WriteLine($"Значение элемента на позиции ({x}, {y}): {result}");
        }
    }

    static int GetElementValue(int[,] array, int x, int y)
    {
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        // Проверяем, выходит ли позиция по рядам за пределы массива
        if (x < 1 || x > rows)
        {
            Console.WriteLine("Позиция по рядам выходит за пределы массива");
            return int.MinValue;
        }

         //Проверяем, выходит ли позиция по колонкам за пределы массива
        if (y < 1 || y > columns)
        {
            Console.WriteLine("Позиция по колонкам выходит за пределы массива");
            return int.MinValue;
        }

         //Возвращаем значение элемента
        return array[x - 1, y - 1];
    }
}

// Задача 2

using System;

class Program
{
    static void Main()
    {
        int[,] numbers = new int[,] {
            {1, 2, 3, 4},
            {5, 6, 7, 8},
            {9, 10, 11, 12}
        };

        // Вывод исходного массива
        Console.WriteLine("Исходный массив:");
        PrintArray(numbers);

        // Меняем местами первую и последнюю строки
        SwapRows(numbers, 0, numbers.GetLength(0) - 1);

        // Вывод измененного массива
        Console.WriteLine("\nМассив после обмена:");
        PrintArray(numbers);
    }

    static void SwapRows(int[,] array, int row1, int row2)
    {
        int columns = array.GetLength(1);

        for (int j = 0; j < columns; j++)
        {
            int temp = array[row1, j];
            array[row1, j] = array[row2, j];
            array[row2, j] = temp;
        }
    }

    static void PrintArray(int[,] array)
    {
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}


// Задача 3
using System;

class Program
{
    static void Main()
    {
        int[,] numbers = new int[,] {
            {1, 2, 3},
            {1, 1, 0},
            {7, 8, 2},
            {9, 10, 11}
        };

        // Вывод исходного массива
        Console.WriteLine("Исходный массив:");
        PrintArray(numbers);

        // Находим строку с наименьшей суммой элементов
        int minSumRowIndex = FindMinSumRow(numbers);

        // Вывод результата
        Console.WriteLine($"\nСтрока с наименьшей суммой элементов: {minSumRowIndex + 1}");
    }

    static int FindMinSumRow(int[,] array)
    {
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        int minSum = int.MaxValue;
        int minSumRowIndex = -1;

        for (int i = 0; i < rows; i++)
        {
            int rowSum = 0;
            for (int j = 0; j < columns; j++)
            {
                rowSum += array[i, j];
            }

            if (rowSum < minSum)
            {
                minSum = rowSum;
                minSumRowIndex = i;
            }
        }

        return minSumRowIndex;
    }

    static void PrintArray(int[,] array)
    {
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

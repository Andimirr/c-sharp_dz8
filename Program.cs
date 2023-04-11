// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] randomArray = new int[rows, columns];

void mas(int rows, int columns)
{
    int i,
        j;
    Random rand = new Random();
    for (i = 0; i < rows; i++)
    {
        for (j = 0; j < columns; j++)
        {
            randomArray[i, j] = rand.Next(1, 9);
        }
    }
}

void printm(int[,] array)
{
    int i,
        j;
    for (i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
    }
}

mas(rows, columns);
Console.WriteLine();
Console.WriteLine("Исходный массив: ");
printm(randomArray);

// Процедура сортировки элементов в строке двумерного массива по убыванию
void uporyadok(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}
Console.WriteLine();
uporyadok(randomArray);
Console.WriteLine();
Console.WriteLine("Отсортированный массив: ");

printm(randomArray);

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить
//  строку с наименьшей суммой элементов. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой
// элементов: 1 строка



Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] randomArray = new int[rows, columns];

void mas(int rows, int columns)
{
    int i,
        j;
    Random rand = new Random();
    for (i = 0; i < rows; i++)
    {
        for (j = 0; j < columns; j++)
        {
            randomArray[i, j] = rand.Next(1, 9);
        }
    }
}

void printm(int[,] array)
{
    int i,
        j;
    for (i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
    }
}

mas(rows, columns);

printm(randomArray);

// Функция, считающая сумму элементов в строке
int SumLine(int[,] array, int i)
{
    int sum = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sum += array[i, j];
    }
    return sum;
}

int minSum = 1;
int sum = SumLine(randomArray, 0);
for (int i = 1; i < randomArray.GetLength(0); i++)
{
    if (sum > SumLine(randomArray, i))
    {
        sum = SumLine(randomArray, i);
        minSum = i + 1;
    }
}
Console.WriteLine();
Console.WriteLine($"\nСтрока c наименьшей суммой элементов: {minSum}");

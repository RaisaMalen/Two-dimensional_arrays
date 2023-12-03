// Задача 2: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку массива.

int [,] Fill2dArray (int row, int col, int min, int max){
    int [,] array = new int [row, col];
    for (int i = 0; i < row; i ++){
        for (int j = 0; j < col; j ++){
            array [i, j] = new Random (). Next (min, max+1);
        }
    }
    return array;
}

void Show2dArray (int [,] array){
    for (int i = 0; i < array.GetLength (0); i ++){
        for (int j = 0; j < array.GetLength (1); j ++){
            Console.Write (array [i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Enter row numbers: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter col numbers: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter min value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter max value: ");
int max = Convert.ToInt32(Console.ReadLine());

int [,] array = Fill2dArray (row, col, min, max);
Show2dArray (array);
Console.WriteLine();
ChangeRows (array);

void ChangeRows (int [,] array){
    for (int i = 0; i < array.GetLength(1); i ++){
        int lastRowIndex = array.GetLength(0)-1;
        int firstRow = array [0, i];
        array [0, i] = array [lastRowIndex, i];
        array [lastRowIndex, i] = firstRow;
    }
    for (int i = 0; i < array.GetLength (0); i ++){
        for (int j = 0; j < array.GetLength (1); j ++){
            Console.Write (array [i, j] + " ");
            }
            Console.WriteLine();
            }
}
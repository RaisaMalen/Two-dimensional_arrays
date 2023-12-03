// Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

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

Console.WriteLine ("Enter element position (row): ");
int rowIndex = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Enter element position (col): ");
int colIndex = Convert.ToInt32 (Console.ReadLine());

if (array.GetLength (0) <= rowIndex || array.GetLength (1) <= colIndex){
    Console.WriteLine ("There is no such element");
    }
    if (rowIndex < 0 || colIndex < 0){
        Console.WriteLine ("There is no such element");
    }
        else {
            int i = rowIndex;
            int j = colIndex;
            Console.WriteLine (array [i, j]);
}

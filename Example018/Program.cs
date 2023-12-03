// Задача 3: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.


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

int minSumLine = 0;
int sumLine = SumLineElements (array, 0);

int SumLineElements (int [,] array, int i){
  int sumLine = array [i, 0];
  for (int j = 1; j < array.GetLength (1); j++){
    sumLine += array[i, j];
    }
    return sumLine;
    }

for (int i = 1; i < array.GetLength (0); i++){
  int tempSumLine = SumLineElements (array, i);
  if (sumLine > tempSumLine){
    sumLine = tempSumLine;
    minSumLine = i;
    }
}

Console.WriteLine ($"The row wih the min sum is: {minSumLine}");

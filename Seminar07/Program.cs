Console.Write("Веведите кол-во строк 2D массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Веведите кол-во колонок 2D массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
 Console.Write("Веведите минимальное число массива: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Веведите максимальное число массива: ");
int  maxValue = Convert.ToInt32(Console.ReadLine());


int[,] Create2dRandomArray(int rows, int columns, int minValue, int maxValue) 
{
    int[,]array = new int[ rows, columns];
    for(int i = 0; i < rows; i++) {
     for(int j = 0; j < columns; j++) {
      array[i,j] = new Random().Next(minValue, maxValue + 1);
     }
    }
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i ++) 
    {
        for(int j = 0;  j < array.GetLength(1); j++)
        Console.Write(array[i,j] + " ");

    Console.WriteLine();
    }
Console.WriteLine();
}

int[,] myArray = Create2dRandomArray(rows, columns, minValue, maxValue);
Show2dArray(myArray);


// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


// double[,] CreateDoubleArray(int rows, int columns, int minValue, int maxValue) 
// {
//     double[,]array = new double[rows, columns];
//     for(int i = 0; i < rows; i++) {
//         for(int j = 0; j < columns; j++) 
//         {
//         array[i,j] = new Random().Next(minValue, maxValue + 1) + Math.Round(new Random().NextDouble(), 1);
//         }
//     }
//     return array;
// }

// void Show2dArray(double[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i ++) 
//     {
//         for(int j = 0;  j < array.GetLength(1); j++)
//         Console.Write(array[i,j] + " ");

//     Console.WriteLine();
//     }
// Console.WriteLine();
// }

// double[,] myArray = CreateDoubleArray(rows, columns, minValue,maxValue);
// Show2dArray(myArray);


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.


// Console.Write("Позицию элемента который необходимо найти, строка: ");
// int SearchRows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Позицию элемента который необходимо найти, колонка: ");
// int SearchColumns = Convert.ToInt32(Console.ReadLine());

// void SearchElem(int[,] array) 
// {
//     int yesOrNo = 0;
//     for(int i = 0; i < array.GetLength(0); i ++) 
//     if(i == SearchRows -1)
//     {
//         for(int j = 0;  j < array.GetLength(1); j++)
//          if(j == SearchColumns - 1)
//          {
//           yesOrNo = 1;
//           Console.WriteLine(array[i,j]);
//          }      
//     }

//    if( yesOrNo == 0) {
//     Console.WriteLine("Такого элемента нет!");
//    }
// }

// SearchElem(myArray);



// Задача 52.Задайте двумерный массив из целых чисел.Найдите среднее арифметическое элементов в каждом столбце.

// double[] Average(int[,] array){
//     double[] resultArr = new double[array.GetLength(1)];
//     for(int j = 0;  j < array.GetLength(1); j++)
//     {
//         for(int i = 0; i < array.GetLength(0); i++) {
//             resultArr[j] += array[i,j];
//         }

//     resultArr[j] /= array.GetLength(0);
//     Console.WriteLine($"Среднее арифметическое в столбце с индексом {j} = {Math.Round(resultArr[j], 1)}");
//     }
//      return resultArr;
// }

// Average(myArray);





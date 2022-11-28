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

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// void ArrangeArray(int[ , ] array) 
// {    int temp;
//       for(int i = 0; i < array.GetLength(0); i++)
//       {
//         for(int j = 0; j < array.GetLength(1); j++) 
//         {
//             for(int k = 0; k < array.GetLength(1)-1; k++)
//             {
//                 if(array[i,k] <= array[i, k + 1])
//                  {
//                    temp = array[i, k];
//                    array[i,k] = array[i,k + 1];
//                    array[i,k+1] = temp;
//                  }
//             }
            
//         }
//       }
// }

// ArrangeArray(myArray);

// Show2dArray(myArray);

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов.


// int MinRows(int [,] array) 
// {   
//     int minSumm = 0;
//     int maxSumm = 0;
//     int result = 0;
//     for(int i = 0; i < array.GetLength(0); i++)
//      { 
//       int minRows = 0;
//       for(int j = 0; j < array.GetLength(1); j++)
//        {  
//            minRows += array[i,j];  
//        }      
//             if(maxSumm <= minRows) {
//              maxSumm = minRows;
//              minSumm = minRows;
//              }
//              if(minSumm >= minRows){
//                 minSumm = minRows;
//                 result = i;
//              }
            
//        }
              
//        return result+1;  
// }
     

// int minSumm = MinRows(myArray);
// Console.WriteLine($"Строка с минимальной суммой элементов строка номер {minSumm}");

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:




// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

 

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте,
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// double[] CreateRandomArray(double size, double minValue, double maxValue){
//    double[] array = new double[size];
//    for(double i = 0; i < size; i++)
//    array[i] = new Random().Next(minValue, maxValue +1);
//    return array;
// }

// void ShowArray(double[] array) {
//    Console.Write("Ваш массив : \n \n");
// for(double i = 0; i < array.Length; i++) 
//    Console.WriteLine(array[i] +  " ");
//    Console.Write("\n");
// }

// Console.Write("Веведите кол-во элементов массива: ");
// double size = Convert.Todouble32(Console.ReadLine());
// Console.Write("Веведите минимальное число массива: ");
// double minValue = Convert.Todouble32(Console.ReadLine());
// Console.Write("Веведите максимальное число массива: ");
// double  maxValue = Convert.Todouble32(Console.ReadLine());

// double[] NewArray = CreateRandomArray(size, minValue, maxValue);
// ShowArray(NewArray);

// double GreaterZero(double[] arr) {
//   double count = 0;
//   for(double i = 0; i < size; i++)
//     { if(arr[i]>0)
//         {
//          count += 1;
//         }
//     } 
//   return count; 
// }

// Console.WriteLine($"В массиве {GreaterZero(NewArray)} чисел больше нуля.");

//  Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1,
// y = k2 * x + b2;
// x = (b2-b1) / (k2-k1)

//  значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Console.Write("Веведите координаты b1: ");
// double b1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Веведите координаты k1: ");
// double k1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Веведите координаты b2: ");
// double b2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Веведите координаты k2: ");
// double k2 = Convert.ToDouble(Console.ReadLine());

// void doubleersectionPodouble(double b1, double k1, double b2, double k2)
// {   
//     double x = (b2-b1) / (k2-k1);
//     double y =  (k1 * x + b1) / (k2 * x + b2);
    
//     Console.WriteLine( $"x = {Math.Round(x, 1)} y = {Math.Round(y, 1)}");

// }
// doubleersectionPodouble( b1, k1, b2, k2);




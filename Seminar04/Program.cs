// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
//  и возводит число A в натуральную степень B.

// Console.Write("Введите число которое нужно возвести в степень: ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"В какую степень нужно возвести число {A} ? ");
// int B = Convert.ToInt32(Console.ReadLine());
// int result = A;int Exponentiation(int arg1, int arg2) {
//     int i = 2; 
//     int result = A;
//     while( i <= arg2 ){
//         result = result * arg1;
//         i++;
//     }
//     return result;
// }

// Console.WriteLine($"{A} в {B} степени = {Exponentiation(A,B)}");


// Задача 27: Напишите программу,
// которая принимает на вход число и выдаёт сумму цифр в числе.


// Console.Write("Введите число : ");
// int Number = Convert.ToInt32(Console.ReadLine());


// int SumDigit(int arg1) {

//     int result = arg1 % 10;

//     while(arg1 > 9) {
//     arg1 = arg1 / 10;
//     result += (arg1 % 10);
//     }

//     return result ;

// }

// Console.WriteLine($"Сумма цифр числа {Number} = {SumDigit(Number)}");


// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

// Console.WriteLine("Введите первый элемент массива : ");
// int elem1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второй элемент массива : ");
// int elem2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третий элемент массива : ");
// int elem3 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите четвертый элемент массива : ");
// int elem4 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите пятый элемент массива : ");
// int elem5 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите шестой элемент массива : ");
// int elem6 = Convert.ToInt32(Console.ReadLine());
// int size = 6;

// int [] CreateArray (int arg1, int arg2, int arg3, int arg4,  int arg5, int arg6){
//    int[] array = new int[size];
//    array[0] = arg1 ;
//    array[1] = arg2 ;
//    array[2] = arg3 ;
//    array[3] = arg4 ;
//    array[4] = arg5 ;
//    array[5] = arg6 ;
//    return array;
// }

// void ShowArray(int [] array) 
// {
//  Console.Write("Массив из ваших чисел : ");
//  for(int i = 0; i < array.Length; i++)
//      Console.Write(array[i] + " ");
// }

// int [] MyArray = CreateArray(elem1, elem2, elem3, elem4, elem5, elem6);
// ShowArray(MyArray);


int[] CreateRandomArray(int size, int minValue, int maxValue){
   int[] array = new int[size];
   for(int i = 0; i < size; i++)
   array[i] = new Random().Next(minValue, maxValue +1);
   return array;
}
void ShowArray(int[] array) {
   Console.Write("Array is: \n");
   for(int i = 0; i < array.Length; i++)
   Console.WriteLine(array[i] +  " ");
   Console.Write("\n");
}


Console.Write("Веведите кол-во элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Веведите минимальное значение массива: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Веведите максимальное значение массива: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
int[]NewArray = CreateRandomArray( size, minValue, maxValue);
ShowArray(NewArray);

// Создать и показать массив 

int[] CreateRandomArray(int size, int minValue, int maxValue){
   int[] array = new int[size];
   for(int i = 0; i < size; i++)
   array[i] = new Random().Next(minValue, maxValue +1);
   return array;
}

void ShowArray(int[] array) {
   Console.Write("Ваш массив : \n \n");
for(int i = 0; i < array.Length; i++) 
   Console.WriteLine(array[i] +  " ");
   Console.Write("\n");
}


//  Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.

// Console.Write("Веведите кол-во элементов массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Веведите минимальное трёхзначное число массива: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Веведите максимальное трёхзначное число массива: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] NewArray = CreateRandomArray( size, minValue, maxValue);
// ShowArray(NewArray);


// int CheckedEven(int[] array) {
// int count = 0;
//     for(int i = 0; i < array.Length; i++) 
//        if(array[i] < 99 || array[i] > 1000) {
//          count = -1;
//          break;
//        }
//        else if (array[i] % 2 == 0 )
//        {
//             count = count + 1;     
//        }
//        return count;
// }

//  int EvenNumber = CheckedEven(NewArray);
// Console.WriteLine($" Четных чисел в массиве:  {EvenNumber}");



// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.



// Console.Write("Веведите кол-во элементов массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Веведите минимальное число массива: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Веведите максимальное число массива: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] NewArray = CreateRandomArray( size, minValue, maxValue);
// ShowArray(NewArray);

// int NotEven(int[] array){
//    int resul = 0;
//    for(int i = 1; i < array.Length; i = i + 2) {
//     resul += array[i];
//    }
//  return resul;
// }

// int notEvenNumber = NotEven(NewArray);
// Console.Write($"Сумма нечетных элементов массива = {notEvenNumber} ");

// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.


// Console.Write("Веведите кол-во элементов массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Веведите минимальное число массива: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Веведите максимальное число массива: ");
// int  maxValue = Convert.ToInt32(Console.ReadLine());

// int[] NewArray = CreateRandomArray(size, minValue, maxValue);
// ShowArray(NewArray);

// int MaxMinDigit(int[] arr){
//    int MaxDigit = 0;
//    int MinDigit = arr[0];
//    int result = 0;

//     for(int i = 0; i < arr.Length; i++)
//         {
//        if (MaxDigit <= arr[i]) {
//             MaxDigit = arr[i];
//                  }  
//        if (MinDigit >= arr[i])  {
//             MinDigit = arr[i];
//        }               
// }
//    Console.WriteLine($"Минимальное значение : {MinDigit}");
//    Console.WriteLine($"Максимальное значение : {MaxDigit}");
//    result = MaxDigit - MinDigit;
//    return result;     
// }

// double diference = MaxMinDigit(NewArray);

// Console.WriteLine($"Разница между минимальным и максимальным значением {diference}");

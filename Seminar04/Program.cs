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

Console.Write("Введите кол-во элементов массива: ");
int Size = Convert.ToInt32(Console.ReadLine());
int i = 1;

void CreateRl(int arg) {
while(i <= arg) {

   Console.Write($"Введите {i} элемент массива: ");
   Console.ReadLine() ;
   
   
   i++;
}
}
CreateRl(Size);

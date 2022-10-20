//Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.

Console.WriteLine("enter you three-digit nubers:");
 int threeDigit = Convert.ToInt32(Console.ReadLine());

 int FindNum2(int num)
 {
  int Num2 = (num % 100) / 10;
  return Num2;
 }

int Num2 = FindNum2(threeDigit);
Console.WriteLine($"second number your three-digital numer {Num2}");
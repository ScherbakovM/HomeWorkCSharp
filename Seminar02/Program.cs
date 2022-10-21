//Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.

// Console.WriteLine("enter you three-digit nubers:");
//  int threeDigit = Convert.ToInt32(Console.ReadLine());

//  int FindNum2(int num)
//  {
//   int Num2 = (num % 100) / 10;
//   return Num2;
//  }

// int Num2 = FindNum2(threeDigit);
// Console.WriteLine($"second number your three-digital numer {Num2}");

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.


//  Console.WriteLine("Введите ваше число: ");
//  int userNumber = Convert.ToInt32(Console.ReadLine());
 
//  int ThreeNum(int num)
//  { 
//     if(num > 99) {
//     while(num > 999)
//     num = num/10;
//     return num % 10;
//     }
//     else {
//     num = -1;
//     return num;
//     }       
//  }
// int Resul = ThreeNum(userNumber);

//  Console.Write($"Третья цифра {userNumber} это  {Resul}");


//Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.


// Console.WriteLine("Проверить выходной  ? Введите день недели по его номеру где Пн - 1 Вскр - 7:");
//  int userDay = Convert.ToInt32(Console.ReadLine());

//   bool ItsHoliday(int num)
//  {
//   if(num == 6 || num == 7)
//     return true;
//   else
//     return false;
//  }
 
//  bool CheckedDay = ItsHoliday(userDay);
//  Console.WriteLine(CheckedDay);
// Задача 19
// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.

// Console.Write("Введите ваше число: ");
// int checkPalindrom = Convert.ToInt32(Console.ReadLine());

// bool ItsPolindrome(int arg){
//     if (arg / 10000 == arg % 10 && (arg / 1000) % 10 == (arg % 100) / 10)
//     return true;
//     else return false;
// }

// Console.Write(ItsPolindrome(checkPalindrom));

//Задача 23

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// Math.Pow(Число, стеень)!

// Console.WriteLine("Введите ваше число : ");
// double userNumber = Convert.ToInt32(Console.ReadLine());



// void CubeInterval(double arg1) {
// double resul = 0;
// double N = 1;

// while ( N <= arg1) {
    
//      resul = Math.Pow(N, 3);
//      Console.Write(resul + " ");
//      N++;
        
// }

// }
// CubeInterval(userNumber);

// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// Получаем координаты А


// Console.WriteLine("Чтобы найти расстояние между точками");
// Console.WriteLine("Введите координаты точки A по оси X = : ");
// int pointAx = Convert.ToInt32(Console.ReadLine( ));

// Console.WriteLine("Введите координаты точки A по оси Y = : ");
// int pointAy = Convert.ToInt32(Console.ReadLine( ));

// Console.WriteLine("Введите координаты точки A по оси Z = : ");
// int pointAz = Convert.ToInt32(Console.ReadLine( ));

// //  Получаем координаты Б

// Console.WriteLine("Введите координаты точки B по оси X = : ");
// int pointBx = Convert.ToInt32(Console.ReadLine( ));

// Console.WriteLine("Введите координаты точки B по оси Y = : ");
// int pointBy = Convert.ToInt32(Console.ReadLine( ));
// Console.WriteLine("Введите координаты точки B по оси Z = : ");
// int pointBz = Convert.ToInt32(Console.ReadLine( ));

// Console.WriteLine($"Точка  A ({pointAx}, {pointAy}, {pointAz})");
// Console.WriteLine($"Точка B ({pointBx}, {pointBy}, {pointBz})");


// double Distance()
// {
//  double SquareX = Math.Pow(pointAx - pointBx, 2);
//  double SquareY = Math.Pow(pointAy - pointBy, 2);
//  double SquareZ = Math.Pow(pointAz - pointBz, 2);

//  double result = Math.Sqrt(SquareX + SquareY + SquareZ);
//  return result;

// }
// Console.Write("Расстояние между точками А и B : ");
// Console.Write(Distance());
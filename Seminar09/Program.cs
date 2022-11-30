
// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// int NaturalNumber(int N)
// {  
//     Console.Write(N + " ");

//     if(N > 1)  return NaturalNumber(N-1);
    
//     else return 1;
    
// }

// NaturalNumber(1);


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int SummDigit(int M, int N) 
// {
//     if(M <= N)
//     return M + SummDigit(M + 1, N);
    
//     else return 0;
// }

// Console.Write(SummDigit(1, 15));

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// int A(int m, int n)
// {
//   if (m == 0)
//     return n + 1;
//   else
//     if ((m != 0) && (n == 0))
//       return A(m - 1, 1);
//     else
//       return A(m - 1, A(m, n - 1));
// }

// Console.Write(A(3, 2));
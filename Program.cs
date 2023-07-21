// // Задание №1
// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введите значение N: ");
//         int N = Convert.ToInt32(Console.ReadLine());

//         Console.WriteLine("\nНатуральные числа в промежутке от " + N + " до 1:");
//         PrintNaturalNumbers(N);

//         Console.ReadLine();
//     }

    
//     static void PrintNaturalNumbers(int number)
//     {
//         if (number <= 0)
//         {
//             return; 
//         }

//         Console.Write(number + " "); 
//         PrintNaturalNumbers(number - 1); 
//     }
// }

// Задание №2


// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введите значение M: ");
//         int M = Convert.ToInt32(Console.ReadLine());

//         Console.Write("Введите значение N: ");
//         int N = Convert.ToInt32(Console.ReadLine());

//         int sum = CalculateSumOfNaturalNumbers(M, N);

//         Console.WriteLine("\nСумма натуральных элементов в промежутке от " + M + " до " + N + ": " + sum);
//         Console.ReadLine();
//     }

    
//     static int CalculateSumOfNaturalNumbers(int M, int N)
//     {
//         if (M > N)
//         {
//             return 0; 
//         }

//         if (M == N)
//         {
//             return M; 
//         }

//         return M + CalculateSumOfNaturalNumbers(M + 1, N); 
//     }
// }


// Задание №3


// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введите число m: ");
//         int m = Convert.ToInt32(Console.ReadLine());

//         Console.Write("Введите число n: ");
//         int n = Convert.ToInt32(Console.ReadLine());

//         int result = AckermannFunction(m, n);

//         Console.WriteLine("\nЗначение функции Аккермана для m = " + m + " и n = " + n + ": " + result);
//         Console.ReadLine();
//     }

    
//     static int AckermannFunction(int m, int n)
//     {
//         if (m == 0)
//         {
//             return n + 1;
//         }
//         else if (n == 0)
//         {
//             return AckermannFunction(m - 1, 1);
//         }
//         else
//         {
//             return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
//         }
//     }
// }

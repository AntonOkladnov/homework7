// Задайте значения M и N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

// System.Console.Write("Введите значение m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите значение n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// void F(int m, int n)
// {
//     if (m != n)
//     {
//         if (m > n)
//         {
//             F(m - 1, n);
//             System.Console.Write(m + " ");
//         }
//         else
//         {
//             F(m + 1, n);
//             System.Console.Write(m + " ");
//         }

//     }
//     else
//     {
//         System.Console.Write(m + " ");
//     }
// }

// F(m, n);

// Напишите программу вычисления функции Аккермана с помощью рекурсии.
//  Даны два неотрицательных числа m и n.

// int Ackermann(int m, int n)
// {
// if (m == 0)
//         {
//             return n + 1;
//         }
//         else if (n == 0)
//         {
//             return Ackermann(m - 1, 1);
//         }
//         else
//         {
//             return Ackermann(m - 1, Ackermann(m, n - 1));
//         }
// }
//         int m, n;
//         System.Console.Write("Введите два неотрицательных числа:");
//         m = Convert.ToInt32(Console.ReadLine());
//         n = Convert.ToInt32(Console.ReadLine());

//         int result = Ackermann(m, n);
//         System.Console.WriteLine("Результат функции Аккермана: " + result);


// Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

void PrintArrayReversed(int[] array, int i)
{
    if (i < 0)
    {
        return;
    }

    Console.Write(array[i] + " ");
    PrintArrayReversed(array, i - 1);
}


int[] array = { 1, 2, 3, 4, 5 };
PrintArrayReversed(array, array.Length - 1);

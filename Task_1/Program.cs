// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 6, 7, 8"

using System.Linq.Expressions;

int M = GetNumber("M");
int N = GetNumber("N");
CheckNumbersValidity(M, N);

void CheckNumbersValidity(int M, int N)  //Проверяем числа на валидность условию задачи
{
    if (M <= 0) Console.WriteLine("Числа должны быть натуральными, то есть больше 0");  // Проверяем что числа натуральные
    else if (M > N) Console.WriteLine($"Число M={M} должно быть меньше числа N={N}!");  // Проверяем что число M меньше числа N
    else Console.WriteLine($"Натуральные числа от {M} до {N} -> {PrintNumber(M, N)}");
}

int GetNumber(string name)  // Ввод числа с клавиатуры
{
    Console.Write($"Введите число {name}: ");
    return Convert.ToInt32(Console.ReadLine());
}

string PrintNumber(int M, int N)    //Состовляем список чисел от M до N
{
    if (M == N) return M.ToString();
    return (M + ", " + PrintNumber(M + 1, N));
}
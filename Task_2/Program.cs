// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int M = GetNumber("M");
int N = GetNumber("N");
CheckNumbersValidity(M, N);

void CheckNumbersValidity(int M, int N)  //Проверяем числа на валидность условию задачи
{
    if (M <= 0 || N <= 0) Console.WriteLine("Числа должны быть натуральными, то есть больше 0!");  // Проверяем что числа натуральные
    else if (M > N) Console.WriteLine($"Число M={M} должно быть меньше числа N={N}!");  // Проверяем что число M меньше числа N
    else Console.WriteLine($"Сумма натуральных чисел от {M} до {N} -> {GetSumNumber(M, N)}");
}

int GetNumber(string name)  // Ввод числа с клавиатуры
{
    Console.Write($"Введите число {name}: ");
    return Convert.ToInt32(Console.ReadLine());
}

int GetSumNumber(int M, int N)    //Считаем сумму натуральных чисел
{
    if (M == N) return M;
    return M + GetSumNumber(M + 1, N);
}
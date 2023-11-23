// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29* 
// * Согласно таблице значений функции Аккермана m = 3, n = 2 -> 29. А для m = 2, n = 3 -> 9

int M = GetNumber("m");
int N = GetNumber("n");
CheckNumbersValidity(M, N);

void CheckNumbersValidity(int m, int n)  //Проверяем числа на валидность условию задачи
{
    if (M < 0 || N < 0) Console.WriteLine("Числа должны быть не отрицательные");  // Проверяем что числа не неотрицательные
    else Console.WriteLine($"Результат функции Аккермана от m = {m} и n = {n} -> {AckermannАunctions(m, n)}");
}

int GetNumber(string name)  // Ввод числа с клавиатуры
{
    Console.Write($"Введите число {name}: ");
    return Convert.ToInt32(Console.ReadLine());
}

int AckermannАunctions(int m, int n)    //Вычисляем функцию Аккермана
{
    if (m == 0) return n + 1;
    else if (n == 0) return AckermannАunctions(m - 1, 1);
    else return AckermannАunctions(m - 1, AckermannАunctions(m, n - 1));    
}
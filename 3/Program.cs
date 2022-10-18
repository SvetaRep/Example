//  Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

int m = 0;
int n = 0;
int.TryParse(Console.ReadLine(), out m);
int.TryParse(Console.ReadLine(), out n);

int functionAkkerman = A(m, n);
Console.Write($"Функция Аккермана = {functionAkkerman} ");
int  A(int m, int n)
{
    if (m == 0) return n+1;
    else
    if (n == 0) return A(m-1, 1);
    else return A(m - 1, A(m, n - 1));
}
    

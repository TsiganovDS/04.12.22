Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int SumNumbers (int M, int N)
{
    if (M == N)
    {
        return N;
    }
    else 
    {
        N += SumNumbers (M, N-1);
    }
    return N;
}

Console.Write ($"Сумма чисел от {M} до {N} - {SumNumbers (M, N)}");
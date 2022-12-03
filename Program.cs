Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int funсtionAkkerman(int M, int N)
{
    if (M == 0)
    {
        return N + 1;
    }
    else if (M > 0 && N == 0)
    {
        N = funсtionAkkerman(M - 1, 1);
        return N;
    }
    else if (M > 0 && N > 0)
    {
        N = funсtionAkkerman(M, N - 1);
        N = funсtionAkkerman(M - 1, N);
    }
    return N;
}

Console.Write($"A({M},{N}) = {funсtionAkkerman(M, N)}");

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

void PrintRange (int N)
{
  if (N == 0) 
  {
    return;
  }
     if (N == 1)
     {
      Console.Write(N);
     }    
    else
    Console.Write(N + ",");
    PrintRange (N - 1);
}

PrintRange(N);

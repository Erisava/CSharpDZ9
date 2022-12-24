// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int M = InputNumbers("Введите первое число: ");
int N = InputNumbers("Введите второе число: ");
int temp = M;
            
if (M > N)
{
    M = N;
    N = temp;
}
            
PrintSumm(M, N, temp=0);
            
void PrintSumm(int M, int N, int summ)
{
    summ = summ + N;
    if (N <= M)
    {
        Console.Write($"Сумма элементов: {summ} ");
        return;
    }
    PrintSumm(M, N - 1, summ);
}
            
int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

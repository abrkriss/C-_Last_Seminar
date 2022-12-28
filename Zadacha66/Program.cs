void Zadacha66()
{
    //Задайте значения M и N. Напишите рекурсивный метод, 
    //который найдёт сумму натуральных элементов в промежутке от M до N.

    int M = 3;
    int N = 9;
    int counter = M;
    int sum = 0;
    Recursion(N, M, counter, sum);


}
void Recursion(int N, int M, int counter, int sum)
{
    if (counter > N) return;
    for (counter = M; counter <= N; counter++)
    {
        sum += counter;
    }
    Console.WriteLine(sum);
}

Zadacha66();


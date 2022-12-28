void Zadacha64()
{
    // Задайте значения M и N. Напишите рекурсивный метод,
    //который выведет все натуральные числа кратные 3-ём в промежутке от M до N.

    int number1= 5;
    int number2 = 15;
    int counter = number1;
    Recursion(number1, number2, counter);
} 
Zadacha64();

void Recursion(int number1, int number2, int counter)
{
    if (counter > number2) return;
    {
        {
        if (counter % 3 == 0)
        Console.Write($"{counter} ");
        counter++;
        Recursion(number1,number2, counter);
        }
    }
}
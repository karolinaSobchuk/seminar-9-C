// Найти сумму элементов от M до N, N и M заданы

void NumberSum (int numberM, int numberN, int sum)
{
    if (numberM > numberN) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (numberM);
    NumberSum(numberM, numberN, sum);
}



Console.WriteLine("Введите начальное число M:");
int numberM = int.Parse(Console.ReadLine());
Console.WriteLine("Введите начальное число M:");
int numberN = int.Parse(Console.ReadLine());
NumberSum(numberM, numberN, 0);

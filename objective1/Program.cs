// Показать натуральные числа от N до 1, N задано

string Numbers(int n)
{
    if(n <= 15) return Numbers(n + 1) + $"{n}";
    else return String.Empty;
}
Console.WriteLine(Numbers(1));
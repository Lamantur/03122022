int Prompt(string message)
{
    System.Console.WriteLine($"{message} >");
    return Convert.ToInt32(Console.ReadLine());
}
int Sum(int number)
{
    int res = number % 10;
    for (int i = number; i / 10 > 0; i /= 10)
    {
        res = res + i % 10;
    }
    return res;
}
System.Console.WriteLine("сумма цифр этого числа: " + Sum(Prompt("введите число")));
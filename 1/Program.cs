int Prompt(string message)
{
    System.Console.WriteLine($"{message} >");
    return Convert.ToInt32(Console.ReadLine());
}
int result = 1;

int Power(int number, int power)
{
    for (int i = 1; i < power; i++)
    {
        result = result * number;
    }
    return result;
}
System.Console.WriteLine(Power(Prompt("Введите число: "), Prompt("Введите степень: ")));
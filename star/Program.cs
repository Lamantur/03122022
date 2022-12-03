int[] GenerateArray(int Length, int minRange, int maxRange)
{
    int[] array = new int[Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minRange, maxRange + 1);
    }
    return array;
}
void PrintArray(int[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write(array[j] + " ");

    }

}
int Prompt(string message)
{
    System.Console.WriteLine($"{message} >");
    return Convert.ToInt32(Console.ReadLine());
}

int SecondMax(int[] array)
{
    int Max = 0;
    int Second = 0;

    for (int j = 0; j < array.Length; j++)
    {
        if (array[j] < Max)
        {
            if (array[j] > Second)
            {
                Second = array[j];
            }
        }
        else
        {
            Second = Max;
            Max = array[j];
        }
    }
    return Second;
}


int[] arr = GenerateArray(Prompt("Введите количество элементов массива"), Prompt("Введите минимальный порог случайных значений"), Prompt("Введите максимальный порог случайных значений"));
PrintArray(arr);
System.Console.WriteLine("Второй максимальный элемент: " + SecondMax(arr));

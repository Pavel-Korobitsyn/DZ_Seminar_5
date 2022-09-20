int InNumber()
{
    while (true)
    {
        string text = Console.ReadLine();
        if (int.TryParse(text, out int number))
        {
            return number;
        }
        else
        {
            Console.Write("Не удалось распознать число. \nВведите число ещё раз: ");
        }
    }
}

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}
void PrintArray(int[] array)
{
    Console.Write("Массив заполнен: [ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write("]");
}
Console.Write("Введите размер массива: ");

int size = InNumber();
int[] array = new int[size];

FillArray(array);
PrintArray(array);

int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        count++;
    }
}

Console.WriteLine($"\nКоличество чётных элементов масива: {count}");

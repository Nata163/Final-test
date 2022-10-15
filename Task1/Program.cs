// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

string[] FillArray(int x)
{
    string[] array = new string[x];
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите элемент массива с индексом {i}:");
        array[i] = Console.ReadLine();
    }
    return array;
}

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
        Console.Write(" ");
    }
}

string[] GetNewArray(string[] arr)
{
    int count = 0; //определяем длину нового массива
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            count = count + 1;
        }
    }

    string[] array = new string[count]; //создаем новый массив и заполняем нужными значениями
    int position = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            array[position] = arr[i];
            position = position + 1;
        }
    }
    return array;
}

try
{
    Console.WriteLine("Введите число элементов массива:");
    int x = int.Parse(Console.ReadLine());
    string[] array = FillArray(x);
    Console.WriteLine("Вывод массива:");
    PrintArray(array);
    Console.WriteLine(" ");
    string[] result = GetNewArray(array);
    Console.WriteLine("Массив из строк, длина которых меньше либо равна 3 символа:");
    PrintArray(result);
}

catch
{
    Console.WriteLine("Нужно ввести число");
}


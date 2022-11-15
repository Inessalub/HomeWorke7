//Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента
void FillArray(int[,,] array, int min, int max)
{
    for (int n = 0; n < array.GetLength(0); n++)
        for (int m = 0; m < array.GetLength(1); m++)
            for (int l = 0; l < array.GetLength(2); l++)
            {
                array[n, m, l] = new Random().Next(min, max);
            }
}

void PrintArray(int[,,] array)
{
    for (int n = 0; n < array.GetLength(0); n++)
    {
        for (int m = 0; m < array.GetLength(1); m++)
        {
            for (int l = 0; l < array.GetLength(2); l++)
            {
                Console.Write($"|{m}| {array[n, m, l]}; ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int Array3D(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

int a = Array3D("Введите размер первого массива: ");
int b = Array3D("Введите размер второго массива: ");
int c = Array3D("Введите размер третьего массива: ");

int[,,] array = new int[a, b, c];
FillArray(array, 0, 99);
Console.WriteLine("Массив: ");
PrintArray(array);
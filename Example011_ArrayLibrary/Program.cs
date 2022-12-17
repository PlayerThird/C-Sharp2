void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] col, int found)
{
    int count = col.Length;
    int index = 0;
    int position = -1; // Чтобы было понятно, что такого числа в массиве нет
    while (index < count)
    {
        if (col[index] == found)
        {
            position = index;
            break;// После того как нашел первый раз позицию числа выходит из цикла
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array); // вызвали метод передав в него массив
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);// Передаём массив, в котором будем искать позицию цифры 4
Console.WriteLine(pos);
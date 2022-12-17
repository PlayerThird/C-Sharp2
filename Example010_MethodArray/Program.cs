int[] array = {12,32,31,44,55,456,767,878};

int n = array.Length;
int find = 878;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;

}
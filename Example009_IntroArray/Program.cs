void FillArray(int [] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next (1,10);
        index++;
    }
}
void PrintArray (int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position]+" ");
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int length = collection.Length;
    int position = 0;
    int index = -1;
    while (position < length)
    {
        if (collection[position] == find)
        {
            index = position;
            break;
        }
        position++;
    }
    return index;
    }

int [] array = new int[10];
FillArray(array);
PrintArray(array);
Console.WriteLine();
int pos = IndexOf(array, 9);
Console.WriteLine(pos);

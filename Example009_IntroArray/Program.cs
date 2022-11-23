int[] array = {1,32,23,44,53,6,79,88,9};
int n = array.Length;
int find = 44;
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
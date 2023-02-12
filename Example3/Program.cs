int[] array = { 11, 12, 31, 41, 151, 61, 71, 18, 41 };
int n = array.Length;
int find = 41;
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

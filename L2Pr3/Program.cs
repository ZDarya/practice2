int[] array = { 12, 233, 344, 43, 5, 6, 233, 8 };
int n = array.Length;
int find = 233;
int index = 0;
while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
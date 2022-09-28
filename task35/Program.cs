// task 35
int[] GetArray(int size,int leftRange,int rightRange)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for(int i = 0;i<size;i++)
    {
        arr[i]=rand.Next(leftRange,rightRange + 1);
    }
    return arr;
}

int[ ] array = GetArray(123,0,150);
Console.WriteLine(string.Join(", ",array));
int count = 0;
for(int i=0;i<array.Length;i++)
{
    if (array [i] >=10 && array [i]<=99)
    {
        count++;
    }
}
Console.WriteLine($"Kоличество элементов массива, значения которых лежат в отрезке [10,99] = {count}");
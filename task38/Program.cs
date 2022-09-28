// task38
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


int[ ] array = GetArray(4,1,100);
Console.WriteLine(string.Join(", ",array));
int max = array[0];
for(int i=1;i<array.Length;i++)
{
    if(array[i] > max)
    {
        max=array[i];
    }
}
int min = array[0];
for(int i=1;i<array.Length;i++)
{
    if(array[i] < min)
    {
        min=array[i];
    }
}
int sum = max - min ;
Console.WriteLine($"Разница между максимальным и минимальным элементов массива = {sum}");

// task 27
Console.WriteLine("Введите число ");
int number= Convert.ToInt32(Console.ReadLine());
number=Math.Abs(number);
int count = Convert.ToString(number).Length;
int res = 0;
int n2 =0;
for (int i = 0;i< count;i++)
{
    n2=number-number%10;
    res=res+(number-n2);
    number=number/10;
}
Console.WriteLine($"{res}");
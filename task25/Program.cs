// task25
Console.WriteLine("Введите число 1");
int number= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2");
int number2= Convert.ToInt32(Console.ReadLine());
int res = 1;
if (number >= 1 & number2 >= 1) 
{
    for (int i=1;i<=number2;i++)
    {
        res = res*number;
    }
    Console.WriteLine($"{res}");
}
else 
{
    Console.WriteLine("Введено  число");
};
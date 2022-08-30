Console.WriteLine("Введите число а: ");
int a = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for(int x = 1; a / x >= 1; x = x * 10)
{
    if ((a / x) % 10 == 0)
       continue;
    if(a % ((a / x) % 10) == 0)
    {
        sum += (a / x) % 10;
    }
}
Console.WriteLine(sum);
Console.WriteLine("Введите число А: ");
double A = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число B: ");
double B = Convert.ToDouble(Console.ReadLine());
B = Convert.ToInt32(Math.Abs(B));
double New_digit = A;
for(int i = 1; i < B; i++)
{
    New_digit = New_digit * A;
}
Console.WriteLine($"А в натуральной степени В = {New_digit}");
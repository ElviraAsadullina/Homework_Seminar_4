Console.WriteLine("Введите количество элементов в Вашем массиве: ");
int N = Convert.ToInt32(Console.ReadLine()); 
int[] array = new int [N];
int index = 0;
Console.WriteLine("Полученный массив из интересных чисел: ");
while(index < N)
{
    int number = new Random().Next();
    int mult = 1;
    int sum = 0;
    int temp = number;
    for(int x = 1; number / x >= 1; x = x * 10)
    {
        int digit = temp % 10;
        mult = mult * digit;
        sum = sum + digit;
        temp = temp / 10;
    }
    if (mult % sum ==0)
    {
        array[index] = number;
    }
    Console.WriteLine(array[index]);
    index++;       
}  
void Zadacha16(int numb1, int numb2)
{
    if(numb1 * numb1 == numb2 || numb2 * numb2 == numb1)
    {
        Console.WriteLine("Одно число является квадратом другого");
    }
    else
    {
        Console.WriteLine("Одно число не является квадратом другого");
    }
}

Console.WriteLine("Введите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());

Zadacha16(number1, number2);
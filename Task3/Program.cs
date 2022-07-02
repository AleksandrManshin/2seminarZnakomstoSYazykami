void Kratnost(int numb1, int numb2)
{
    if( numb1 % numb2 == 0)
    {
        Console.WriteLine("Число " + numb1 + " кратно числу " + numb2);
    }
    else
    {
        Console.WriteLine("Первое число не картно второму, остаток от деления равен " + numb1 % numb2);
    }
}


Console.WriteLine("Введите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());
Kratnost(number1, number2);



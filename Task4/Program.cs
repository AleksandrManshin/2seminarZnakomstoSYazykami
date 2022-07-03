void Zadacha14(int numb)
{
    if(numb % 7 == 0)
    {
        if(numb % 23 == 0)
        {
            Console.WriteLine("Да");
        }
        else
        {
            Console.WriteLine("Нет");
        }
    } 
    else
    {
        Console.WriteLine("Нет");
    }
}

Console.WriteLine("Введите число, и я скажу явлеяется ли оно одновременно кратно 7 и 23:");
int number = Convert.ToInt32(Console.ReadLine());

Zadacha14(number);
Random rand = new Random();
int number = rand.Next(10, 100);
Zadacha9(number);
number = rand.Next(10, 100);
//Console.WriteLine(number);

//int digitFirst = number/10;
//int digitSecond = number%10;
//if(digitFirst > digitSecond)
//{
//    Console.WriteLine(digitFirst);
//}
//else if(digitFirst < digitSecond)
//{
//    Console.WriteLine(digitSecond);
//}
//else
//{
   // Console.WriteLine("Цифры числа равны");
//}


void Zadacha9(int currentNumber) //f(x)
{
  Console.WriteLine(currentNumber);
 int digitFirst = currentNumber/10;
 int digitSecond = currentNumber%10;
 if(digitFirst > digitSecond)
  Console.WriteLine(digitFirst);
  else if(digitFirst < digitSecond)
  Console.WriteLine(digitSecond);
  else
   Console.WriteLine("Цифры числа равны");
}

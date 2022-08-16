
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number > 99)
{
   if(number < 1000)
   {
    int lastdDigit = number % 10;
    Console.WriteLine(lastdDigit);
   }
   else 
   {
    Console.WriteLine("Третьей цифры нет");
   }
}
else
{
    Console.WriteLine("Третьей цифры нет");
}

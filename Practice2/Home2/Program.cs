// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите любое число");
int num = Convert.ToInt32(Console.ReadLine());
int GetThirdRank(int num)
{
    while (num > 999)
{
    num /= 10;
}
return num % 10;}
Console.WriteLine(GetThirdRank(num));

if (num < 100)
{
    Console.WriteLine("Третьей цифры нет, введите число больше 99");
}
else if ((num>=100) && (num<1000))
{
    int result = num%10;
    Console.WriteLine(result);
}
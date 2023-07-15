// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
int i = new Random().Next(10, 99);
Console.WriteLine(i); 
int des = i/10;
int ed = i%10;
Console.WriteLine(des);
Console.WriteLine(ed);
if (des>ed)
{
    Console.Write("Наибольшее число: ");
    Console.Write(des);
}
else
{
    Console.Write("Наибольшее число: ");
    Console.Write(ed);
}
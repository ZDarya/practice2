// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
int rnd = new Random().Next(100, 1000);
Console.WriteLine(rnd); 
int sot = rnd/100;
int ed = rnd%10;
Console.Write(sot);
Console.Write(ed);
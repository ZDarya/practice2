int Max (int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 1;
int b1 = 2;
int c1 = 588;
int a2 = 8; 
int b2 = 155; 
int c2 = 10;
int a3 = 94;
int b3 = 44;
int c3 = 56;

// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);
// int max = Max (max1, max2, max3);

int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));
// Console.WriteLine(max1);
// Console.WriteLine(max2);
// Console.WriteLine(max3);
Console.WriteLine(max);
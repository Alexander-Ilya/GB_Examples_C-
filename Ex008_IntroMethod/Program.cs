﻿int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2>result) result = arg2;
    if(arg3>result) result = arg3;
    return result;
}
int a1 =10, b1=13, c1=15;
int a2 =10, b2=13, c2=15;
int a3 =10, b3=13, c3=25;

int max= Max(Max(a1,b1,c1), Max(a2,b2,c2), Max(a3, b3, c3));
Console.WriteLine(max);
﻿int a = 5;
int b = 6;

Add(a, b);
Add(10, 100);
Add(56583, 658686);

Multiply(a, b);
Multiply(10, 100);
Multiply(56583, 1);

Substract(a, b);    
Substract(10, 3); 

static void Add(int x, int y)
{
    Console.WriteLine($"{x}+ {y} = {x + y}");
}

static void Multiply(int x, int y)
{
    Console.WriteLine($"{x} * {y} = {x * y}");
}
static void Substract(int x, int y) // x - y
{
    Console.WriteLine($"{x} - {y} = {x - y}");
}
static void Divide(int x, int y) //x / y
{
    Console.WriteLine($"{x} / {y} = {x / y}");
}
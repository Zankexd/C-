﻿int a = new Random().Next(1,10);
int b = new Random().Next(1,10);
int c = new Random().Next(1,10);
int d = new Random().Next(1,10);
int v = new Random().Next(1,10);

Console.Write (a+",");
Console.Write (b+",");
Console.Write (c+",");
Console.Write (d+",");
Console.Write (v+",");

int max = a;

if ( a > max ) max = a;
if ( b > max ) max = b;
if ( c > max ) max = c;
if ( d > max ) max = d;
if ( v > max ) max = v;


Console.WriteLine("max="+max);



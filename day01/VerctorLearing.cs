using System;
Vector x,y;
x = new Vector();
x.Value = 30;
y = x;
Console.WriteLine(y.Value);
y.Value = 50;
Console.WriteLine(x.Value);
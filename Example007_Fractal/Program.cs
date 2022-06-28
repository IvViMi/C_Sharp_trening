﻿Console.Clear();
//Console.SetCursorPosition(10, 4);
//Console.WriteLine("+");
int xa = 1, ya = 1,
    xb = 1, yb = 10,
    xc = 15, yc = 10;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = xb;

int count = 0;

while(count < 10000) // должно быть фрактальное изображение треугольник Серпинского (https://elementy.ru/posters/fractals/Sierpinski)
// но проблемы с размерами консоли у леново т470, а на макепро работает >:(
{
    int what = new Random().Next(0, 3); // [0;3) 0 1 2
    if(what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }

    if(what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }

    if(what == 2)
    {
        x = (x+xc) / 2;
        y = (y+yc) / 2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count = count + 1;
}
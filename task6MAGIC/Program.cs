Console.Clear();


int  xa = 20, ya = 1,
     xb = 11, yb = 30,
     xc = 40, yc = 30;

Console.SetCursorPosition(xa, ya);
Console.WriteLine ("+");
Console.SetCursorPosition(xb, yb);
Console.WriteLine ("+");
Console.SetCursorPosition(xc, yc);
Console.WriteLine ("+");

int x = xa, y = xb;

int count = 0

while (count < 10)
{
    int what = new Random().Next (0, 3)
 if (what == 0)
 {
    x = (x + xa) / 2;
 }   
}
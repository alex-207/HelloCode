Console.Clear();

int xa = 40, ya = 1,
    xb = 1, yb = 30,
    xc = 80, yc = 30;

// ОТРИСОВАТЬ ПЕРВОНАЧАЛЬНЫЙ ТРЕУГОЛЬНИК
Console.SetCursorPosition(xa, ya);  // отступ слева 40 символов, верх 1
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = xb;  // случайные точки

int count = 0;  // счетчик

// ЦИКЛ ОТРИСОВКИ
while(count < 10000) {
    int what = new Random().Next(0, 3);  // определить случайное число 0 1 2

    // УСЛОВИЯ ОПРЕДЕЛЕНИЯ СЕРЕДИНЫ 
    if(what == 0) {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }

    if(what == 1) {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }

    if(what == 2) {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }

    // ПОСТАВИТЬ ТОЧКУ ПО СЕРЕДИНЕ
    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");

    count++;  // увеличить счетчик
}
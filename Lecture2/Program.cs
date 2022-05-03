//Напишем программу, которая будет реагировать на каждого по особеннму исп If  Else :Э

//Console.Write("Введите имя пользователя:  ");
//string username = Console.ReadLine();

//if(username.ToLower() == "маша")
//{
   //Console.WriteLine("Ура, это же Маша! ");
//}
//else
//{
    //Console.Write("Привет, ");
    //Console.WriteLine(username);
//}

//Задача№ 6 : 

//int a = 1;
//int b = 2;
//int c = 6;
//int d = 8;
//int e = 4;

//int max = a;

//if (a > max ) max = a;
//if (b > max ) max = b;
//if (c > max ) max = c;
//if (d > max ) max = d;
//if (e > max ) max = e;

//Console.Write("max = ");
//Console.WriteLine(max);


//НОВОЕ Приложение Magic

Console.Clear();
//Console.SetCursorPosition(10, 4);
//Console.WriteLine("+");

int xa = 40; 
int ya = 1;
int xb = 1;
int yb = 30;
int xc = 80;
int yc = 30;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = xb;

int count = 0;

while(count < 10000)
{
    int what = new Random().Next(0, 3);  // (0;3) 0 1 2
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
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count++;        //или  count = count + 1;
}
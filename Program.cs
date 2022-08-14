// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.

// Console.WriteLine("введите пятизначное число");
// string? array = Console.ReadLine();
// if (array[0] == array[4] && array[1] == array[3]) Console.WriteLine("это палиндром");
// else Console.WriteLine("это НЕ палиндром");


// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

// Console.WriteLine("введите координаты первой точки по оси Х");
// int X1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите координаты  первой точки по оси Y");
// int Y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите координаты  первой точки по оси Z");
// int Z1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите координаты второй точки по оси Х");
// int X2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите координаты  второй точки по оси Y");
// int Y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите координаты  второй точки по оси Z");
// int Z2 = Convert.ToInt32(Console.ReadLine());
// int diffX = 0;
// if (X2 > X1) diffX = X2 - X1;
// if (X1 > X2) diffX = X1 - X2;
// int diffY = 0;
// if (Y2 > Y1) diffY = Y2 - Y1;
// if (Y1 > Y2) diffY = Y1 - Y2;
// int diffZ= 0;
// if (Z2 > Z1) diffZ = Z2 - Z1;
// if (Z1 > Z2) diffY = Z1 -Z2;

// double Lenght = Math.Sqrt(diffX*diffX+diffY*diffY+diffZ*diffZ);
// Console.WriteLine(Math.Round(Lenght,2));

// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

// Console.WriteLine("введите число");
// int N = Convert.ToInt32(Console.ReadLine());
// int Count = 0;
// int index = 1;
// while (index <= N)
// {
//    Count = index*index*index;
//    Console.WriteLine(Count);
//    index ++;
// }
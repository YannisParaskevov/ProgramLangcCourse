// принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве
Console.Clear();
Console.Write("Введите координату x точки А: ");
double xa = double.Parse(Console.ReadLine());
Console.Write("Введите координату y точки А: ");
double ya = double.Parse(Console.ReadLine());
Console.Write("Введите координату x точки B: ");
double xb = double.Parse(Console.ReadLine());
Console.Write("Введите координату y точки B: ");
double yb = double.Parse(Console.ReadLine());
double S = Math.Sqrt((xa-xb)*(xa-xb) + (ya-yb)*(ya-yb));
Console.WriteLine($"A({xa};{ya}); B({xb};{yb}) -> S = {S:f3}");
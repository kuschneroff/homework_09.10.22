/*Задача 21
Напишите программу, которая принимает на вход координаты 
двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53

AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)*2*/

void GetDistanceBetweenThreePoints(int firstX, int secondX, 
                                    int firstY, int secondY,
                                    int firstZ, int secondZ)
{
    double result = 0;
    double TempX = Math.Pow(secondX - firstX, 2); 
    double TempY = Math.Pow(secondY - firstY, 2);
    double TempZ = Math.Pow(secondZ - firstZ, 2);
    result = Math.Sqrt(TempX + TempY + TempZ);
    Console.WriteLine();
    Console.WriteLine($"Расстояние между двумя точками {result}");
    Console.WriteLine();    
}
GetDistanceBetweenThreePoints(3, 2, 6, 1, 8, -7);
GetDistanceBetweenThreePoints(7, 1, -5, -1, 0, 9);
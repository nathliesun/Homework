Console.WriteLine("Для уравнения y = k1 * x + b1, y = k2 * x + b2 введите значения b1, k1, b2 и k2 ");
Console.WriteLine(" b1");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(" k1");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(" b2");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(" k2");
double k2 = Convert.ToDouble(Console.ReadLine());


double[] FindPoint(double b1, double k1, double b2, double k2)
{

 double[] koord = new double[2];
 koord[0]=(b2-b1)/(k1-k2);
 koord[1]=(k1*b2-k2*b1)/(k1-k2);
return koord;  
}

if (k1==k2)
Console.WriteLine("Прямые параллельны и не имеют точек пересечения");
else {
double[] a = FindPoint(b1, k1, b2, k2);

Console.Write("Точка пересечения двух прямых");
Console.Write(" Координата Х:");
Console.Write(a[0]);
Console.Write(" Координата Y:");
Console.Write(a[1]);
}
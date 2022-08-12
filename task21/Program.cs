double distance(double x1, double y1, double z1, double x2, double y2, double z2)
{
   double result = Math.Pow (Math.Pow ((x2-x1), 2) + Math.Pow ((y2-y1), 2) + Math.Pow ((z2-z1), 2), 0.5);
return result;
}
double dis = distance(2,8,6,9,7,8);

Console.WriteLine(dis);

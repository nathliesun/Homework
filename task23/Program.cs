Console.WriteLine("введите число");
double number = Convert.ToInt32(Console.ReadLine());

for (double i =1; i <= number; i++)
{
double result = Math.Pow (i, 3);
Console.WriteLine(result);
}

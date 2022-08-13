Console.WriteLine("введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
string str_number = number.ToString();
char a1= str_number[0];
char a2= str_number[1];
char a3= str_number[2];
char a4= str_number[3];
char a5= str_number[4];
// int b1 =number % 10;
// int b2 = number / 10 % 10;
// int b3 = number / 100 % 10; 
// int b4 = number / 1000 % 10;
// int b5 = number /10000;
if ((a1 == a5) && (a2 == a4))
Console.WriteLine("число является палиндромом");
else 
Console.WriteLine("число не является палиндромом");
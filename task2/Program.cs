Console.WriteLine("введите трехзначное число");

int number = Convert.ToInt32(Console.ReadLine());

string str_number = number.ToString();
char digit= str_number[1];
Console.WriteLine("вторая цифра");
System.Console.WriteLine (digit);

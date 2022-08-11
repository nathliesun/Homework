Console.WriteLine("введите  число");

string str_number = Console.ReadLine();

if (str_number.Length < 3)
   Console.WriteLine(" третьей цифры нет");
else 
{
    char digit= str_number[2];
    Console.WriteLine(" третья цифра");
    System.Console.WriteLine(digit);
}
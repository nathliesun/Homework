Console.WriteLine("введите  день недели цифрой от 1 до 7");

int number = Convert.ToInt32(Console.ReadLine());

if (number <= 5)
   Console.WriteLine(" это будний день");
else if (number <= 7)
    Console.WriteLine(" это выходной");
else  
    Console.WriteLine(" это не день недели, введите число от 1 до 7");
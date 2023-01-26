// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число 1");
string number1Str=Console.ReadLine();
int number1=Convert.ToInt32(number1Str);
Console.WriteLine("Введите число 2");
string number2Str=Console.ReadLine();
int number2=Convert.ToInt32(number2Str);
Console.WriteLine("Введите число 3");
string number3Str=Console.ReadLine();
int number3=Convert.ToInt32(number3Str);
int max=number1;
if (number2 > max)
max=number2;
if (number3 > max)
max=number3;
Console.WriteLine($"Максимальное число {max}");
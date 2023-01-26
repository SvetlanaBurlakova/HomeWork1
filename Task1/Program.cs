// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число 1");
string number1Str=Console.ReadLine();
int number1=Convert.ToInt32(number1Str);
Console.WriteLine("Введите число 2");
string number2Str=Console.ReadLine();
int number2=Convert.ToInt32(number2Str);
if (number1 > number2)
Console.WriteLine($"число {number1} больше, чем число {number2}");
else
Console.WriteLine($"число {number2} больше, чем число {number1}");

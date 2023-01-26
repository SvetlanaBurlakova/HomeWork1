// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число");
string numberStr=Console.ReadLine();
int number=Convert.ToInt32(numberStr);
if (number%2==0)
Console.WriteLine($"число {number} четное");
else
Console.WriteLine($"число {number} нечетное");  

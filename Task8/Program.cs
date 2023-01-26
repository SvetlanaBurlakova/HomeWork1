Console.WriteLine("Введите число");
string numberStr=Console.ReadLine();
int number=Convert.ToInt32(numberStr);
int index=2;
if (number>=2)
{while (index<=number)
    {
        Console.Write($"{index}, ");
        index+=2;
    }
}
else
Console.WriteLine("четных чисел в этом диапазоне нет");

Console.WriteLine("Напишите первое число:");
string? number1string = Console.ReadLine();
int number1 = int.Parse(number1string!);
Console.WriteLine("Напишите второе число:");
string? number2string = Console.ReadLine();
int number2 = int.Parse(number2string!);
Console.WriteLine("Напишите третье число:");
string? number3string = Console.ReadLine();
int number3 = int.Parse(number3string!);
if (number1 == number2 & number1 == number3)
{
    Console.WriteLine("Неверный ввод чисел. Числа равны между собой.");
}
else if (number1 > number2 & number1 > number3)
{
    Console.WriteLine("Наибольшее число равно " + number1 + ".");
}
else if (number2 > number3)
{
    Console.WriteLine("Наибольшее число равно " + number2 + ".");
}
else Console.WriteLine("Наибольшее число равно " + number3 + ".");
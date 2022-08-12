Console.WriteLine("Напишите целое число:");
string? numberstring = Console.ReadLine();
int number = int.Parse(numberstring!);
if (number%2 == 0) Console.WriteLine("Число " + number + " является чётным.");
else Console.WriteLine("Число " + number + " не является чётным.");
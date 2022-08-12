Console.WriteLine("Напишите целое число больше 0:");
string? numberstring = Console.ReadLine();
int number = int.Parse(numberstring!);
if (number < 2) Console.Write("Чётных чисел нет.");
else 
{
    Console.WriteLine("Чётные числа в диапазоне от 2 до " + number + ":");
    for (int i = 2; i <= number; i+=2) Console.Write(i + " ");
}

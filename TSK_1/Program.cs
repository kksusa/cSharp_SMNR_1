Console.WriteLine("Напишите первое число:");
string? number1string = Console.ReadLine();
int number1 = int.Parse(number1string!);
Console.WriteLine("Напишите второе число:");
string? number2string = Console.ReadLine();
int number2 = int.Parse(number2string!);
if (number1 == number2) {
    Console.WriteLine("Неверный ввод чисел. Числа равны между собой.");
}
else if (number1 > number2){
    Console.WriteLine("Максимальное число равно " + number1 + "."); 
    Console.WriteLine("Минимальное число равно " + number2 + "."); 
}
else {
    Console.WriteLine("Максимальное число равно " + number2 + ".");  
    Console.WriteLine("Минимальное число равно " + number1 + ".");
}
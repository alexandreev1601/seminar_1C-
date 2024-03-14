// System.Console.WriteLine("Hello, World!");
// System.Console.Write("Hello, World!");

// Команда выводит текст

// Напишите программу, которая на вход
// Принимает два целых числа и провераяет,
// является ли первое число квадратом второго.
// а = 25, b = 5 => да
System.Console.WriteLine("Введите число");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 / num2 == num2) {
    System.Console.WriteLine("Да");
}
else {
    System.Console.WriteLine("Нет");
}
// System.Console.WriteLine("Hello, World!");
// System.Console.Write("Hello, World!");

// Команда выводит текст

// Напишите программу, которая на вход
// Принимает два целых числа и провераяет,
// является ли первое число квадратом второго.
// а = 25, b = 5 => да
// System.Console.WriteLine("Введите число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите второе число");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num1 / num2 == num2) {
//     System.Console.WriteLine("Да");
// }
// else {
//     System.Console.WriteLine("Нет");
// }

// Напишите программу которая на вход принимает
// целове число N, а на выходе показывает все целые числа в промежутке от -N до N.
// Примеры
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4

// System.Console.Write("Введите число: ");
// int num1 = Convert.ToInt32(System.Console.ReadLine());
// int num2 = num1 * -1;

// while(num2 <= num1)
// {
//     System.Console.Write(num2);
//     System.Console.Write(", ");
//     num2 = num2 + 1;
// }

// Напишите программу, которая принимает на вход трёхзнаечное целое число и на выходе показываает сумму первой и последнней цифры этого числа.
// 756 => 10
using System.Reflection;

System.Console.Write("Введите число: ");
// int num1 = Convert.ToInt32(System.Console.ReadLine()); // && - и, || - или

// if(num1 > 99 && num1 < 1000)
// {
//     int firstnum = num1/ 100;
//     int lastnum = num1 % 10;
//     int result = firstnum + lastnum;
//     Console.WriteLine(result);
// }

// else
// {
//     System.Console.WriteLine("Число не подходит");
// }
// using System;

// public class Answer {
//     static void CompareNumbers(int firstNumber, int secondNumber)
//     {
//         // Введите свое решение ниже
//       if(firstNumber < secondNumber){
//         Console.WriteLine("второе число больше")
//       }
//       if(firstNumber > secondNumber){
//         Console.WriteLine("первое число больше")
//       }
//       if(firstNumber == secondNumber){
//         Console.WriteLine("числа равны")
//       }

//     }


//   // Не удаляйте и не меняйте метод Main! 
//     static public void Main(string[] args) {
//         int firstNumber, secondNumber;

//         if (args.Length >= 2) {
//             firstNumber = int.Parse(args[0]);
//             secondNumber = int.Parse(args[1]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//             firstNumber = 7;
//             secondNumber = 5;
//         }

//         // Не удаляйте строки ниже
//         CompareNumbers(firstNumber, secondNumber);
//     }
// }


public class Answer {
    static void PrintEvenNumbers(int number)
    {
      // Введите свое решение ниже
      int num = 0;
      while (num <= number)
      {
        if (num % 2 == 0)
        {
          Console.Write(num);
          Console.Write(' ');
          num = num + 1;
        }
      }

    }


  // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 6;
        }

        // Не удаляйте строки ниже
        PrintEvenNumbers(number);
    }
}
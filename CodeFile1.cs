using System;


class Program
{
    static void Main(string[] args)


    {

        int number, num, num1;
        double num2,num3,del,procent;
        string word;

        Console.WriteLine("\t\t\t\t\tВас привествует калькулятор!");
        
        
        Console.Write("Арифметические операции: ");
        Console.WriteLine("\n1-Вычитание\n2-Сложение\n3-Умножение\n4-Деление\n5-Процент от числа\n6-Квадратный корень");
        Console.WriteLine();
        Console.Write("Введите номер арифметической операции: ");
        number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        switch (number)
        {
            case 0:
                Console.Write("Введите номер арифметической операции: ");
                number = Convert.ToInt32(Console.ReadLine());
                if (number == 1)
                {
                    goto case 1;
                }
                else if (number == 2)
                {
                    goto case 2;
                }
                else if (number == 3)
                {
                    goto case 3;
                }
                else if (number == 4)
                {
                    goto case 4;
                }
                else if (number == 5)
                {
                    goto case 5;
                }
                else if (number == 6)
                {
                    goto case 6;
                }
                else break;


            case 1:
                Console.Write("Введите первое число: ");
                num= Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите второе число: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Результат вычитания: " + (num - num1));
                Console.WriteLine("Хотите продолжить? да/нет");
                word=Console.ReadLine();
                if(word=="да")
                {
                    goto case 0;
                }
                else
                {
                    break;
                }
            case 2:
                Console.Write("Введите первое число: ");
                num = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите второе число: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Результат сложения: " + (num + num1));
                Console.WriteLine("Хотите продолжить? да/нет");
                word = Console.ReadLine();
                if (word == "да")
                {
                    goto case 0;
                }
                else
                {
                    break;
                }
            case 3:
                Console.Write("Введите первое число: ");
                num = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите второе число: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Результат умножения: " + (num * num1));
                Console.WriteLine("Хотите продолжить? да/нет");
                word = Console.ReadLine();
                if (word == "да")
                {
                    goto case 0;
                }
                else
                {
                    break;
                }
            case 4:
                Console.Write("Введите первое число: ");
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите второе число: ");
                num3 = Convert.ToInt32(Console.ReadLine());
                del =num2 / num3;
                Console.WriteLine("Результат деления: " + del);
                Console.WriteLine("Хотите продолжить? да/нет");
                word = Console.ReadLine();
                if (word == "да")
                {
                    goto case 0;
                }
                else
                {
                    break;
                }
            case 5:
                Console.Write("Введите  число: ");
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите процент от числа: ");
                num3 = Convert.ToInt32(Console.ReadLine());
                procent = (num2 / 100) * num3;
                Console.WriteLine($"Результат процента от числа: {procent}% "); ;
                Console.WriteLine("Хотите продолжить? да/нет");
                word = Console.ReadLine();
                if (word == "да")
                {
                    goto case 0;
                }
                else
                {
                    break;
                }
            case 6:
                Console.Write("Введите  число: ");
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Результат квадратного корня: " + Math.Sqrt(num2));
                Console.WriteLine("Хотите продолжить? да/нет");
                word = Console.ReadLine();
                if (word == "да")
                {
                    goto case 0;
                }
                else
                {
                    break;
                }
        }
    }


    
}

        
                






              















    





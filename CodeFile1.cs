using System;


class Program
{
    static void Main(string[] args)


    {


        //Задание 1.
        for (int i = 1; i <= 99; i++)
        {
            if (i % 2 == 1)
            {
                Console.WriteLine(i);
            }

        }
        // Задание 2.
        for (int i = 5; i > 0; i--)
        {
            Console.WriteLine(i);

        }

        //Задание 3.
        Console.Write("Введите число: ");
        int num = Convert.ToInt32(Console.ReadLine());


        for (int i = 1; i <= num; i++)
        {
            Console.WriteLine(i);

        }
        //Задание 4.

        int num = 98, numOne = 0;


        while (numOne < num)
        {
            numOne = numOne + 7;


            Console.Write(numOne + " ");
        }
        Console.WriteLine();
        //Задание 5.
        int num = 5;
        for (int i = 0; i < 10; i++)
        {

            num = num - 5;

            Console.Write(num + ", ");
        }
        Console.WriteLine();
        //Задание 6.
        double num = 0;
        for (int i = 10; i <= 20; i++)
        {


            num = Math.Pow(i, 2);

            Console.Write(num + ", ");
        }
        Console.WriteLine();

        //Массивы Задание 0.

        int[] intArr = new int[5] { 5, 2, 6, 7, 100 };

        Console.Write("Введите число: ");
        int num = Convert.ToInt32(Console.ReadLine());


        if (Array.IndexOf(intArr, num) == -1)
        {
            Console.WriteLine("Данное число не входит в массив");
        }
        else
        {
            Console.WriteLine("Данное число  входит в массив");
        }

        //Задание 1.

        int[] source = { 5, 4, 7, 2, 9, 7, 10 };
        Console.Write("Введите число для его удаления из массива: ");
        int numberReadLine = Convert.ToInt32(Console.ReadLine());
        int futureArrayLength = 0;
        Console.WriteLine("Текущий массив:");

        for (int i = 0; i < source.Length; i++)
        {
            Console.Write(source[i] + " ");

        }
        foreach (int item in source)
        {
            if (item != numberReadLine)
            {
                futureArrayLength++;
            }

        }

        int[] resultArray = new int[futureArrayLength];
        int iterationForAppend = 0;

        for (int i = 0; i < source.Length; i++)
        {
            if (source[i] != numberReadLine)
            {
                if (iterationForAppend != resultArray.Length)
                {
                    resultArray[iterationForAppend] = source[i];
                    iterationForAppend++;

                }

            }

        }
        Console.WriteLine("\nНовый массив:");
        for (int i = 0; i < resultArray.Length; i++)
        {
            Console.Write(resultArray[i] + " ");
        }
        Console.WriteLine();
        //Задание 2.

        int min, max, indexMax = 0, indexMin = 0, sum = 0;

        Console.Write("Введите количество элементов в массиве: ");
        int nums = Convert.ToInt32(Console.ReadLine());
        int[] myArr = new int[nums];
        min = myArr[indexMin];
        max = myArr[indexMax];
        Random random = new Random();

        for (int i = 0; i < myArr.Length; i++)
        {
            myArr[i] = random.Next(1, 20);
            sum = sum + myArr[i];

            max = myArr[indexMax];
            min = myArr[indexMin];
            Console.WriteLine(myArr[i]);

            if (myArr[i] > max)
            {

                max = myArr[i];

                indexMax = i;




            }
            if (myArr[i] < min)
            {

                min = myArr[i];

                indexMin = i;




            }

        }
        Console.WriteLine();

        Console.WriteLine("Максимальное значение в массиве: " + max);
        Console.WriteLine("Минимальное значение в массиве: " + min);
        Console.WriteLine("Среднее значение массива: " + (double)sum / nums);


        //Задание 3.
        int sum = 0, sum1 = 0;
        double avaregeValue, avaregeValue1;
        int[] myArr = new int[5] { 1, 2, 3, 70, 5 };
        int[] myArr1 = new int[5] { 1, 2, 4, 70, 5 };
        Console.WriteLine("Первый массив");
        for (int i = 0; i < myArr.Length; i++)
        {
            sum = sum + myArr[i];
            Console.Write(myArr[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Второй массив");
        for (int j = 0; j < myArr1.Length; j++)
        {
            sum1 = sum1 + myArr1[j];
            Console.Write(myArr1[j] + " ");
        }
        Console.WriteLine();
        avaregeValue = (double)sum / 5;
        avaregeValue1 = (double)sum1 / 5;
        Console.WriteLine("Среднее арифметическое первого массива: " + avaregeValue);
        Console.WriteLine("Среднее арифметическое второго массива: " + avaregeValue1);
        if (avaregeValue > avaregeValue1)
        {
            Console.WriteLine("Среднее арифметическое первого массива больше второго");
        }
        if (avaregeValue < avaregeValue1)
        {
            Console.WriteLine("Среднее арифметическое второго массива  больше первого");
        }
        if (avaregeValue == avaregeValue1)
        {
            Console.WriteLine("Среднее арифметическое массивов равны");
        }



    }
}
        
                






              















    





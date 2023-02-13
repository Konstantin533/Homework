using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Schema;

class Program
{
    static void Main(string[] args)


    {


        //Задание 5. String
        Console.Write("Введите текст: ");
        string myText = Console.ReadLine();

        string duplicatText;

        for (int i = 0; i < myText.Length; i++)
        {

            duplicatText = string.Concat(myText[i], myText[i]);
            Console.Write(duplicatText);

        }
        Console.WriteLine();

        //Задание 2.
        string word = "Желтый красный зеленый лук поле чтотооченьбольшое чтотосуперпупербольшоеочень шар";
        Console.WriteLine("Наш массив:\n" + word);
        int index = 0, indexMin = 0;
        string[] clubs = word.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int max = clubs[index].Length;
        int min = clubs[indexMin].Length;


        for (int i = 0; i < clubs.Length; i++)
        {

            max = clubs[index].Length;
            min = clubs[indexMin].Length;

            if (max <= clubs[i].Length)
            {


                max = clubs[i].Length;
                index = i;


            }
            if (min >= clubs[i].Length)
            {
                min = clubs[i].Length;
                indexMin = i;
            }

        }
        Console.Write("Максимальное количество букв в слове: " + clubs[index]);
        Console.WriteLine();
        Console.Write("Минимальное количество букв в слове: " + clubs[indexMin]);
        Console.WriteLine();
        //Задание 4.
        string words = "дед привет доход мяч довод магазин";
        Console.WriteLine(words);

        Console.Write("Введите номер слова которое хотите проверить: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num == 0 || num > 6)
        {
            Console.WriteLine("Вы ввели неверное значение");

        }
        num = num - 1;

        string[] clubs = words.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string[] clubsTwo = words.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        StringBuilder dude = new StringBuilder(clubs[num]);
        StringBuilder dudeTwo = new StringBuilder(clubsTwo[num]);
        for (int i = 0; i < dudeTwo.Length; i++)
        {
            dudeTwo[i] = dude[dude.Length - i - 1];
            clubsTwo[num] = dudeTwo.ToString();

        }


        if (clubsTwo[num].Equals(clubs[num]))
        {
            Console.WriteLine("Это слово является палиндромом: " + clubs[num]);

        }
        else
        {
            Console.WriteLine("НЕ является палиндромом!!");
        }



    }
}
        
                






              















    





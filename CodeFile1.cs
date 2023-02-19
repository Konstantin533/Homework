
using Project1;
using System;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;



class Program
{
    static void Main(string[] args)


    {
        //Задание 1.
        Phone phoneOne = new Phone(78999019909, "Nokia", 5);
        Phone phoneTwo = new Phone(79019992323, "Samsung");
        Phone phoneThree = new Phone();
        phoneOne.ReceiveCall("Сергей");
        phoneTwo.ReceiveCall("Артём");
        phoneThree.ReceiveCall("Илья");
        Console.WriteLine(phoneOne.GetNumber());
        phoneTwo.GetNumber();
        phoneThree.GetNumber(79919231212);
        phoneOne.ReceiveCall("Дмитрий", 79889011717);
        phoneTwo.ReceiveCall();
        phoneThree.ReceiveCall();
        phoneOne.SendMessage(79889011717, 79919231212, 78005553535, 79099776523);



        ////Задание 2.
        Patient patient = new Patient();
        patient.Plan(1);


        //Задание 3.
        CreditCard creditCard = new CreditCard(1232133212,45000);
        CreditCard creditCardOne = new CreditCard(69696969696, 25000);
        CreditCard creditCardTwo = new CreditCard(777777777, 50000);
        creditCard.CurrentShow();
        creditCard.ChargeMoney();
        creditCard.CurrentShow();
        creditCard.ChargeMoney();
        creditCard.CurrentShow();
        creditCard.TakeoffMoney();
        creditCard.CurrentShow();

        creditCardOne.CurrentShow();
        creditCardOne.ChargeMoney();
        creditCardOne.CurrentShow();
        creditCardOne.ChargeMoney();
        creditCardOne.CurrentShow();
        creditCardOne.TakeoffMoney();
        creditCardOne.CurrentShow();

        creditCardTwo.CurrentShow();
        creditCardTwo.ChargeMoney();
        creditCardTwo.CurrentShow();
        creditCardTwo.ChargeMoney();
        creditCardTwo.CurrentShow();
        creditCardTwo.TakeoffMoney();
        creditCardTwo.CurrentShow();
    }
}
        
                






              















    





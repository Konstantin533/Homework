
using Project1;
using System;
using System.Linq;
using System.Text;



class Program
{
    static void Main(string[] args)


    {
        Phone phoneOne = new Phone(78999019909,"Nokia",5);
        Phone phoneTwo = new Phone(79019992323,"Samsung");
        Phone phoneThree = new Phone();
        phoneOne.ReceiveCall("Сергей");
        phoneTwo.ReceiveCall("Артём");
        phoneThree.ReceiveCall("Илья");
        phoneOne.GetNumber();
        phoneTwo.GetNumber();
        phoneThree.GetNumber(79919231212);
        
    }
}
        
                






              















    





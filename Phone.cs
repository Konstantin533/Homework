using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class Phone
    {
        public long number;
        public string model;
        public int weight;
        public string name;

        public Phone()
        {
        }
        public Phone(long numberInit, string modelInit)
        {
            number = numberInit;
            model = modelInit;
        }
        public Phone(long numberInit, string modelInit, int weghtInit) : this (numberInit, modelInit)
        {
            
            number = numberInit;
            model = modelInit;
            weight = weghtInit;

        }
        
        

        public void ReceiveCall(string nameInit)
        {
            name = nameInit;
            Console.WriteLine($"Звонит {name}");
            
        }
       
        public string GetNumber()
        {
            
            string result = string.Format("{0:+# (###) ###-##-##}", number);
            return result;
        }
        public string GetNumber(long numberInit)
        {
            number=numberInit;
            string result = string.Format("{0:+# (###) ###-##-##}", number);
            return result;
        }

       
       
        public void ReceiveCall()
        {
            
            string result = string.Format("{0:+# (###) ###-##-##}", number);
            Console.WriteLine($"Вам звонит {name} , номер телефона {result}");
        }
        public void ReceiveCall(string nameInit, long number)
        {
            name = nameInit;
            string result = string.Format("{0:+# (###) ###-##-##}", number);
            Console.WriteLine($"Вам звонит {name}, номер телефона {result}");
        }
        public void SendMessage(params long [] array ) 
        {

            
            for (int i = 0; i < array.Length; i++)
            {
                
                string result = string.Format("{0:+# (###) ###-##-##}", array[i]);
                Console.WriteLine($"Телефон на который придёт сообщение: {result}");
            }


            Console.WriteLine();
        }
    }
}
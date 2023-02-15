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
        


        public Phone(long numberInit, string modelInit, int weghtInit)
        {
             number = numberInit;
             model = modelInit;
             weight = weghtInit;

        }
        public Phone(long numberInit, string modelInit)
        {
            number = numberInit;
            model = modelInit;
           

        }
        public Phone()
        {
          

        }

        public void ReceiveCall(string name)
        {
            Console.WriteLine($"Звонит {name}");
        }
        public string  GetNumber()
        {
            
           string result = string.Format("{0:+# (###) ###-##-##}", number);
           return result;
        }
        public string GetNumber(long number)
        {

            string result = string.Format("{0:+# (###) ###-##-##}", number);
            return result;
        }

    }
}

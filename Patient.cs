using Project1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class Patient
    {
        public void Plan(int code)
        {
            if (code == 1)
            {
                Surgeon.Treat();
            }
            if (code == 2)
            {
                Dentist.Treat();
            }

            if(code !=1 & code !=2)
            {
                Therapist.Treat();
            }
                
        }
         



        




    }
}

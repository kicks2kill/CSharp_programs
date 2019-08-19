using System;
using System.Collections.Generic;


namespace SchoolTracker
{
    interface IPayee 
    {
        void Pay();
    }
    class Payroll 
    {
        Teacher teacher1 = new Teacher();
        Teacher teacher2 = new Teacher();
        Principal principal = new Principal();
        
        public void PayAll() 
        {
            teacher1.Pay();
            teacher2.Pay();
            principal.Pay();
        }
    }

}
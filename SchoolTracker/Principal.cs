using System;
using System.Collections.Generic;


namespace SchoolTracker
{
    class Principal : Member, IPayee
    {   
        public void Pay()
        {
              Console.WriteLine("paying principal");
        }
    }

}
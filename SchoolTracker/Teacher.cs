using System;
using System.Collections.Generic;


namespace SchoolTracker
{
    class Teacher : Member, IPayee
    {   

        public string Subject; 

        public void Pay()
        {
            Console.WriteLine("paying teacher");
        }
    }

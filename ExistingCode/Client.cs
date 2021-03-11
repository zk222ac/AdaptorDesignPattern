using AdaptorDesignPattern.ClientInterface;
using AdaptorDesignPattern.Adaptor_Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdaptorDesignPattern.ExistingCode
{
   public class Client
    {
        
        public static void CallMethod()
        {
            ITarget target = new Adaptor();
            foreach (var emp in target.GetListEmployees())
            {
                Console.WriteLine(emp);
            }

        }
       
       
    }
}

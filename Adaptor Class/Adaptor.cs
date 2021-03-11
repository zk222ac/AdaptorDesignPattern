using AdaptorDesignPattern.ClientInterface;
using AdaptorDesignPattern.External_Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdaptorDesignPattern.Adaptor_Class
{
    public class Adaptor : ThirdPartyLibrary, ITarget
    {
       
        public List<string> GetListEmployees()
        {
            // Get data from Third party source and return to the adaptor
            return GetEmployeesFromThirdPartySource();
        }
    }
}

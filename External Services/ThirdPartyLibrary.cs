using System;
using System.Collections.Generic;
using System.Text;

namespace AdaptorDesignPattern.External_Services
{
  public class ThirdPartyLibrary
    {
        public List<string> GetEmployeesFromThirdPartySource()
        {
            return new List<string> { "emp1","emp2","emp3","emp4","emp5"};
        }
    }
}
